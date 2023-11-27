using DesktopWinforms.Properties;
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
using DesktopWinforms.Services;
using Microsoft.Extensions.Hosting;
using PSPublicMessagingAPI.Desktop.Consumers;
using MassTransit;
using SuperSimpleTcp;


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
        private static async Task Main()
        {
            await CreateHostBuilder().Build().RunAsync();
        }
        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddMassTransit(x =>
                    {
                        // elided...
                        x.AddConsumer<NotificationCreatedConsumer>();
                        x.UsingRabbitMq((context, cfg) =>
                        {
                            cfg.Host("localhost", "/", h =>
                            {
                                h.Username("guest");
                                h.Password("guest");
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
        IServiceProvider serviceProvider;
        private SimpleTcpServer server = new SimpleTcpServer("127.0.0.1:13000");
        IConfigurationManagerService configurationManagerService;
        public MyCustomApplicationContext()
        {
            serviceProvider = IocConfig.CreateServiceProvider();
         
            configurationManagerService = serviceProvider.GetService<IConfigurationManagerService>();
            var encryptedUsername = configurationManagerService.UserName;
            var encryptedPassword = configurationManagerService.Password;
            if (!string.IsNullOrEmpty(encryptedUsername) && !string.IsNullOrEmpty(encryptedPassword))
            {
                LDAPUser user = serviceProvider.GetRequiredService<IActiveDirectoryService>().LoginToActiveDirectoryUser(encryptedUsername, encryptedPassword);
                if (user != null)
                {
                    
                }
                //LoginCommand.Execute(encryptedPassword);
            }
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


            MainWindow window = serviceProvider.GetRequiredService<MainWindow>();
            window.Height = Screen.PrimaryScreen.WorkingArea.Height;
            window.StartPosition = FormStartPosition.Manual;
            window.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - window.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - window.Height);
            window.Presenter = serviceProvider.GetRequiredService<IMainViewPresenter>();
            window.ShowDialog();
        }
        void ShowAbout(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it


            About window = new About(serviceProvider.GetRequiredService<IFontService>(), serviceProvider.GetRequiredService<IConfigurationManagerService>());
            window.Show();
        }
    }
}
