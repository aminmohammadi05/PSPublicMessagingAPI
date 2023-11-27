using MassTransit;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWinforms.Services
{
    public class Worker : BackgroundService
    {
        private readonly IServiceProvider _services;
        public Worker(IServiceProvider services)
        {
            this._services = services;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
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
            System.Windows.Forms.Application.Run(new MyCustomApplicationContext());

            return Task.CompletedTask;
        }
    }
}
