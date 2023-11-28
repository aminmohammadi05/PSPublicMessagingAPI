using System;
using Desktop.Views.Shared;
using DevExpress.XtraEditors;
using PSPublicMessagingAPI.Desktop.Models;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Threading;
using AutoMapper;
using PSPublicMessagingAPI.Desktop.Consumers;
using PSPublicMessagingAPI.Desktop.Views;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Domain.Notifications;
using System.ComponentModel;

namespace PSPublicMessagingAPI.DesktopWinforms.Controllers;

public class PSMessangerMainController : IPSMessangerMainController
{
    private IToastService _toastService;
    private IActiveDirectoryService _activeDirectoryService;
    public SynchronizationContext _uiSyncContext = null;
    private readonly IMapper _mapper;
    private ICommunicationApplicationController _communicationAppController;
    private readonly IConfigurationManagerService _configurationManagerService;
    IFontService _fontService;
    public List<NotificationViewModel> NotificationList { get; set; }
    XtraUserControl messagesView;
    private Dispatcher Dispatcher;


    NotificationCreatedConsumer _consumer;
    public PSMessangerMainController(ICommunicationApplicationController communicationAppController, IToastService toastService, IActiveDirectoryService activeDirectoryService, NotificationCreatedConsumer consumer, IMapper mapper, IFontService fontService, IConfigurationManagerService configurationManagerService, Dispatcher dispatcher)
    {
        _configurationManagerService = configurationManagerService;
        _communicationAppController = communicationAppController;
        _fontService = fontService;
        _consumer = consumer;
        Dispatcher = dispatcher;
        
       
        _mapper = mapper;
        _toastService = toastService;
        _activeDirectoryService = activeDirectoryService;

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
