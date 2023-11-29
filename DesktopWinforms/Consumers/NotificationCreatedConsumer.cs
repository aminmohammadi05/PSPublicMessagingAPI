using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using AutoMapper;
using Desktop.Views.Shared;
using DesktopWinforms.Models;
using DesktopWinforms.Services;
using DevExpress.Utils.MVVM.Services;
using MassTransit;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Desktop.Models;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using PSPublicMessagingAPI.Desktop.Views;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.SharedToastMessage;
using PSPublicMessagingAPI.SharedToastMessage.Models;
using PSPublicMessagingAPI.SharedToastMessage.Services;
using Notification = PSPublicMessagingAPI.Domain.Notifications.Notification;

namespace PSPublicMessagingAPI.Desktop.Consumers;

public class NotificationCreatedConsumer :ViewModelBase,  IConsumer<NotificationCreatedEvent>
{
    private readonly ICommunicationApplicationController _communicationAppController;
    private readonly IToastService _toastService;
    private readonly IActiveDirectoryService _activeDirectoryService;
    private readonly IMapper _mapper;
    private readonly IFontService _fontService;
    private readonly IConfigurationManagerService _configurationManagerService;
    private readonly Dispatcher _dispatcher;
    private NotificationCreatedEvent _message;
    private NotificationViewModel notification;


    public event EventHandler<PropertyChangedEventArgs> MessageReceived;
    public NotificationCreatedConsumer(
        ICommunicationApplicationController communicationAppController,
        IToastService toastService,
        IActiveDirectoryService activeDirectoryService,
        IMapper mapper,
        IFontService fontService,
        IConfigurationManagerService configurationManagerService,
        Dispatcher dispatcher)
    {
        _communicationAppController = communicationAppController;
        _toastService = toastService;
        _activeDirectoryService = activeDirectoryService;
        _mapper = mapper;
        _fontService = fontService;
        _configurationManagerService = configurationManagerService;
        _dispatcher = dispatcher;
    }

    public NotificationViewModel Notification
    {
        get => notification;
        set
        {
            notification = value;
            OnPropertyChanged(nameof(Notification));
            OnMessageReceived(nameof(Notification));
        }
    }
    
    public async Task Consume(ConsumeContext<NotificationCreatedEvent> context)
    {
        NotificationDto notifi = await _communicationAppController.GetNotificationByIdAsync(context.Message.Id);
        if (notifi == null)
        {

            return;
        }

        NotificationViewModel notification = _mapper.Map<NotificationViewModel>(notifi);
        Notification = notification;
        if ((notification.TargetGroup == "All") ||
            (!string.IsNullOrEmpty(notification.TargetGroup) && notification.TargetGroup == _activeDirectoryService.OU) ||
            (string.IsNullOrEmpty(notification.TargetGroup) && notification.TargetClientUserName == _activeDirectoryService.CurrentUser))
        {
            StaThreadWrapper(() =>
            {
                ShowMessage(notification.NotificationText, ToastType.Info);
            });
            //_dispatcher.Invoke(() => ShowMessage(notification.NotificationText, ToastType.Info), DispatcherPriority.Background);
            if (_configurationManagerService.Silent)
            {
                StaThreadWrapper(() =>
                {
                    ShowMessage(notification.NotificationText, ToastType.Info);
                });
                
            } else
            {
                _dispatcher.Invoke(() =>
                {
                    var msg = new Message(notification, _communicationAppController, _activeDirectoryService, _mapper, _fontService);
                    msg.TopMost = true;
                    msg.Show();
                }, DispatcherPriority.Background);

            }

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
    private void OnMessageReceived(string propertyName)
    {

        MessageReceived?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


    protected void ShowMessage(string message, ToastType toastType)
    {
        _toastService.ToastMessage = new Toast()
        {
            Message = message,
            ToastType = toastType
        };
        var notify = new ToastMessageView(_toastService);
        notify.Show();
    }
}