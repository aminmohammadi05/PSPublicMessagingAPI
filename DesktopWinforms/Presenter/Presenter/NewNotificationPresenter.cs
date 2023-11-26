using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Desktop.Presenter.View;
using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingAPI.Desktop.Presenter.Presenter;

public class NewNotificationPresenter : INewNotificationPresenter
{
    private readonly INewNotification _view;
    private readonly ICommunicationApplicationController _communicationAppController;
    public NewNotificationPresenter(INewNotification view, ICommunicationApplicationController communicationAppController)
    {
        _view = view;
        _communicationAppController = communicationAppController;
        _view.Presenter = this;
    }
    public INewNotification View
    {
        get
        {
            return _view;
        }

    }

    public async Task<List<Notification>> GetAllNotifications()
    {
        return await _communicationAppController.GetAllNotifications();
    }

    public async Task<int> RemoveNotification(Guid notificationId)
    {
        return await _communicationAppController.RemoveNotification(notificationId);
    }

    public void Run()
    {
        _view.Run();
    }

    public async Task<Notification> SaveNotification(Notification selectedNotification)
    {
        return await _communicationAppController.SaveNotification(selectedNotification);
    }
}