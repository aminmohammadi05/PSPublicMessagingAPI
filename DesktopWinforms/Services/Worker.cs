using MassTransit;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesktopWinforms.Services
{
    public class Worker : BackgroundService
    {
        readonly IBus _bus;

        public Worker(IBus bus)
        {
            _bus = bus;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                //await _bus.Publish(new Message (Guid.NewGuid(), $"The time is {DateTimeOffset.Now}",  DateTime.Now), stoppingToken);

                //await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
