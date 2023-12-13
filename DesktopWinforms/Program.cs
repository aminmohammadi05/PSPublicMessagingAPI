
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Microsoft.Extensions.DependencyInjection;
using PSPublicMessagingAPI.Desktop.Config;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Forms;
using PSPublicMessagingAPI.Desktop.Models;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using AutoMapper;
using DesktopWinforms.Services;
using Microsoft.Extensions.Hosting;
using PSPublicMessagingAPI.Desktop.Consumers;
using MassTransit;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.DesktopWinforms.Properties;
using PSPublicMessagingAPI.SharedToastMessage.Services;
using SuperSimpleTcp;
using Topshelf;
using Host = Microsoft.Extensions.Hosting.Host;


namespace DesktopWinforms
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main(string[] args)
        //{


        //    CultureInfo culture = CultureInfo.CreateSpecificCulture("fa-IR");

        //    // The following line provides localization for the application's user interface.  
        //    Thread.CurrentThread.CurrentUICulture = culture;

        //    // The following line provides localization for data formats.  
        //    Thread.CurrentThread.CurrentCulture = culture;

        //    // Set this culture as the default culture for all threads in this application.  
        //    // Note: The following properties are supported in the .NET Framework 4.5+ 
        //    CultureInfo.DefaultThreadCurrentCulture = culture;
        //    CultureInfo.DefaultThreadCurrentUICulture = culture;
        //    System.Windows.Forms.Application.EnableVisualStyles();
        //    System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

        //    System.Windows.Forms.Application.Run(new MyCustomApplicationContext());

        //}
        [STAThread]
        private static async Task  Main()
        {

            var host = CreateHostBuilder().Build();


            using (host)
            {
                //host.Run();
                await host.StartAsync();
                await host.StopAsync();
            }
        }
        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    IServiceProvider serviceProvider = IocConfig.CreateServiceProvider(services);
                    services.AddMassTransit(x =>
                    {
                        // elided...
                        x.AddConsumer<NotificationCreatedConsumer>();
                        x.AddConsumer<MainWindow>();

                        x.UsingRabbitMq((context, cfg) =>
                        {

                            cfg.ReceiveEndpoint("ps-notification-updated", e =>
                            {
                                //e.PrefetchCount = 16;
                                //e.UseMessageRetry(r => r.Interval(2, 10));
                                e.ConfigureConsumer<MainWindow>(context, c =>
                                {
                                    c.UseDelayedRedelivery(r => r.Intervals(TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(15), TimeSpan.FromMinutes(30)));
                                    c.UseMessageRetry(r => r.Immediate(5));
                                    c.UseInMemoryOutbox();
                                });
                                e.ConfigureConsumer<NotificationCreatedConsumer>(context, c =>
                                {
                                    c.UseDelayedRedelivery(r => r.Intervals(TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(15), TimeSpan.FromMinutes(30)));
                                    c.UseMessageRetry(r => r.Immediate(5));
                                    c.UseInMemoryOutbox();
                                });
                            });
                            var configurationManager = serviceProvider.GetRequiredService<IConfigurationManagerService>();
                            
                            cfg.Host(configurationManager.Host ,"/", h =>
                            {
                                
                                h.Username(configurationManager.RBUserName);
                                h.Password(configurationManager.RBPassword);
                            });

                            cfg.ConfigureEndpoints(context);
                        });
                    });
                    services.AddHostedService<Worker>();

                    
                });
        }
    }

    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        
        IPSMessangerMainController appController;
        IServiceProvider _serviceProvider;

        IConfigurationManagerService configurationManagerService;
        public MyCustomApplicationContext(IServiceProvider serviceProvider)
        {
            
            _serviceProvider = serviceProvider;
            // Initialize Tray Icon
         
            
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.New_Project,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items =
                    {
                        new ToolStripMenuItem("درباره پیامرسان پارس سویچ", null, new EventHandler(ShowAbout), "About"),
                        new ToolStripMenuItem("پیامرسان پارس سویچ", null, new EventHandler(ShowPSMessenger), "ShowPSMessenger"),
                        new ToolStripMenuItem("خروج", null, new EventHandler(Exit), "Exit")
                    }
                },
                Visible = true
            };
            
        }


        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            System.Windows.Forms.Application.Exit();
        }
        void ShowPSMessenger(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it


            MainWindow window = //_serviceProvider.GetRequiredService<MainWindow>();
                new MainWindow(_serviceProvider.GetRequiredService<ICommunicationApplicationController>(),
                _serviceProvider.GetRequiredService<IToastService>(),
                _serviceProvider.GetRequiredService<IActiveDirectoryService>(),
                _serviceProvider.GetRequiredService<IMapper>(),
                _serviceProvider.GetRequiredService<NotificationCreatedConsumer>(),
                _serviceProvider.GetRequiredService<IFontService>(),
                _serviceProvider.GetRequiredService<IConfigurationManagerService>(),
                Dispatcher.CurrentDispatcher);
            window.Height = Screen.PrimaryScreen.WorkingArea.Height;
            window.StartPosition = FormStartPosition.Manual;
            window.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - window.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - window.Height);
            window.Presenter = _serviceProvider.GetRequiredService<IMainViewPresenter>();
            window.Show();
        }
        void ShowAbout(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it


            About window = new About(_serviceProvider.GetRequiredService<IFontService>(), _serviceProvider.GetRequiredService<IConfigurationManagerService>());
            window.Show();
        }
    }
}
