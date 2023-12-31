using MassTransit;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Hosting;
using PSPublicMessagingAPI.Desktop.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using DesktopWinforms.Models;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.ViewModels;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.SharedToastMessage.Models;
using PSPublicMessagingAPI.SharedToastMessage;
using PSPublicMessagingAPI.SharedToastMessage.Services;

namespace DesktopWinforms.Services
{
    public class Worker : BackgroundService
    {
        private readonly IServiceProvider _services;
        private HubConnection hub;
        public Worker(IServiceProvider services)
        {
            this._services = services;
            hub = new HubConnectionBuilder()
                .WithUrl($"{_services.GetRequiredService<IConfigurationManagerService>().SignalHost}/notifications")
                .WithAutomaticReconnect()
                .Build();
        }
        
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                hub.On<NotificationCreatedEvent>("NotificationCreated",  (NotificationCreatedEvent notification) =>
                {
                    if (_services.GetRequiredService<IConfigurationManagerService>().MainWindowIsOpen)
                    {
                        return;
                    }

                    NotificationDto notifi = _services.GetRequiredService<ICommunicationApplicationController>().GetNotificationByIdAsync(notification.Id);
                    if (notifi == null)
                    {

                        return;
                    }

                    NotificationViewModel message = _services.GetRequiredService<IMapper>().Map<NotificationViewModel>(notifi);

                    if (message.Id == Guid.Empty)
                    {
                        return;
                    }

                    if (message.NotificationStatus == NotificationStatus.ReadyToPublish)
                    {
                        return;
                    }

                    if ((!string.IsNullOrEmpty(message.TargetGroup) && message.TargetGroup.Split(new char[','])
                            .Select(x => x.Trim()).Where(x => !String.IsNullOrEmpty(x)).Count() > 0) ||
                        (!string.IsNullOrEmpty(message.TargetGroup) && message.TargetGroup.Split(new char[','])
                            .Select(x => x.Trim()).Where(x => !String.IsNullOrEmpty(x))
                            .Any(x => x.ToLower() == _services.GetRequiredService<IActiveDirectoryService>().OU.ToLower())))
                    {
                        if (_services.GetRequiredService<IConfigurationManagerService>().Silent)
                        {
                            ShowMessage(message.NotificationText, ToastType.Info);
                        }
                        else
                        {
                             StaThreadWrapper(() =>
                            {
                                var msg = new PSPublicMessagingAPI.Desktop.Views.Message(message,
                                    _services.GetRequiredService<ICommunicationApplicationController>(),
                                    _services.GetRequiredService<IActiveDirectoryService>(),
                                    _services.GetRequiredService<IMapper>(),
                                    _services.GetRequiredService<IFontService>());
                                msg.TopMost = true;
                                msg.Show();
                            });


                        }
                        
                    }

                });
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            try
            {
                await hub.StartAsync();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
           

        }
        public void StaThreadWrapper(Action action)
        {
            var t = new Thread(o =>
            {
                action();
                System.Windows.Threading.Dispatcher.Run();
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }
        protected virtual void ShowMessage(string message, ToastType toastType)
        {
            StaThreadWrapper(() =>
            {
                _services.GetRequiredService<IToastService>().ToastMessage = new Toast()
                {
                    Message = message,
                    ToastType = toastType
                };
                var notify = new ToastMessageView(_services.GetRequiredService<IToastService>());
                notify.Show();
            });
            
        }
    }
}
