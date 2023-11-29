
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
    Task<List<NotificationDto>> GetAllNotifications();
    Task<Guid> RemoveNotification(Guid notificationId);
    Task<NotificationDto> SaveNotification(NotificationDto selectedNotification);
}