using Microsoft.Extensions.DependencyInjection;
using PSPublicMessagingAPI.Desktop.Config;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.Views;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;
using AutoMapper;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.DesktopWinforms.Properties;
using PSPublicMessagingAPI.SharedToastMessage.Services;


namespace DesktopWinforms
{
    static class Program
    {

        
        [STAThread]
        private static void  Main()
        {

            try
            {
                IServiceCollection services = new ServiceCollection();
                var _services = IocConfig.CreateServiceProvider(services);
                CultureInfo culture = CultureInfo.CreateSpecificCulture("fa-IR");

                // The following line provides localization for the application's user interface.  
                Thread.CurrentThread.CurrentUICulture = culture;

                // The following line provides localization for data formats.  
                Thread.CurrentThread.CurrentCulture = culture;

                // Set this culture as the default culture for all threads in this application.  
                // Note: The following properties are supported in the .NET Framework 4.5+ 
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
                System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
                System.Windows.Forms.Application.Run(new MyCustomApplicationContext(_services));


            }
            catch (Exception ex)
            {

                System.Diagnostics.EventLog.WriteEntry("Public Messaging", ex.StackTrace,
                    System.Diagnostics.EventLogEntryType.Warning);
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                
                Application.ExitThread();

                Environment.Exit(0);
            }
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
