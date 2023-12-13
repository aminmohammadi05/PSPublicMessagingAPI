using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesktopWinforms.Models;
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
    #region Notification

    public async Task<List<NotificationDto>> GetAllNotifications()
    {
        return await _communicationAppController.GetAllNotificationsAsync();
    }
    public async Task<NotificationDto> GetNotificationById(Guid id)
    {
        return await _communicationAppController.GetNotificationByIdAsync(id);
    }

    public async Task<Guid> RemoveNotification(Guid notificationId)
    {
        return await _communicationAppController.RemoveNotificationAsync(notificationId);
    }
    public async Task<Guid> SaveNotification(NotificationDto selectedNotification)
    {
        return await _communicationAppController.SaveNotificationAsync(selectedNotification);
    }
    public async Task<Guid> SetNotificationStatus(NotificationDto selectedNotification)
    {
        return await _communicationAppController.SetNotificationStatusAsync(selectedNotification);
    }
    #endregion

    #region Possible Action
    public async Task<List<PossibleActionDto>> GetAllPossibleActions()
    {
        return await _communicationAppController.GetAllPossibleActionsAsync();
    }
    #endregion

    public void Run()
    {
        _view.Run();
    }


}