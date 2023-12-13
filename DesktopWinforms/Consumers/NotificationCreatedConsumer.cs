using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using AutoMapper;
using DesktopWinforms.Models;
using MassTransit;
using Microsoft.Toolkit.Uwp.Notifications;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using PSPublicMessagingAPI.Desktop.Views;
using PSPublicMessagingAPI.SharedToastMessage;
using PSPublicMessagingAPI.SharedToastMessage.Models;
using PSPublicMessagingAPI.SharedToastMessage.Services;

namespace PSPublicMessagingAPI.Desktop.Consumers;

public class NotificationCreatedConsumer :ViewModelBase,  IConsumer<NotificationUpdatedEvent>
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
    
    public async Task Consume(ConsumeContext<NotificationUpdatedEvent> context)
    {
        if (_configurationManagerService.MainWindowIsOpen)
        {
            return;
        }

        NotificationDto notifi = await _communicationAppController.GetNotificationByIdAsync(context.Message.Id);
        if (notifi == null)
        {

            return;
        }

        NotificationViewModel notification = _mapper.Map<NotificationViewModel>(notifi);
        Notification = notification;
        if ((!string.IsNullOrEmpty(notification.TargetGroup) && notification.TargetGroup.Split(new char[',']).Select(x => x.Trim()).Where(x => !String.IsNullOrEmpty(x)).Count() > 0) ||
            (!string.IsNullOrEmpty(notification.TargetGroup) && notification.TargetGroup.Split(new char[',']).Select(x => x.Trim()).Where(x => !String.IsNullOrEmpty(x)).Any(x => x.ToLower() == _activeDirectoryService.OU.ToLower())))
        {

            //_dispatcher.Invoke(() => ShowMessage(notification.NotificationText, ToastType.Info), DispatcherPriority.Background);
            if (_configurationManagerService.Silent)
            {
                new ToastContentBuilder()
                    .AddArgument(notification.Id.ToString(), 9813)
                    .AddHeader(notification.Id.ToString(), notification.NotificationTitle, new ToastArguments())
                    .AddText(notification.NotificationText)
                    .Show();

            }
            else
            {
                StaThreadWrapper(() =>
                {
                    var msg = new Message(notification, _communicationAppController, _activeDirectoryService, _mapper, _fontService);
                    msg.TopMost = true;
                    msg.Show();
                });


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
        t.Join();
    }
    private void OnMessageReceived(string propertyName)
    {

        MessageReceived?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


   
}