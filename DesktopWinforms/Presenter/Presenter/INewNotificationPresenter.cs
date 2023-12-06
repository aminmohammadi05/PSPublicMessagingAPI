
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesktopWinforms.Models;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter.Shared;
using PSPublicMessagingAPI.Desktop.Presenter.View;
using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingAPI.Desktop.Presenter.Presenter;

public interface INewNotificationPresenter : IPresenter<INewNotification>
{
    #region Notification
    Task<List<NotificationDto>> GetAllNotifications();
    Task<Guid> RemoveNotification(Guid notificationId);
    Task<Guid> SaveNotification(NotificationDto selectedNotification);
    Task<NotificationDto> GetNotificationById(Guid result);
    #endregion
    #region Possible Action
    Task<List<PossibleActionDto>> GetAllPossibleActions();
   
    #endregion
}