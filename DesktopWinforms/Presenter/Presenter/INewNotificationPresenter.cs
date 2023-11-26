
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter.Shared;
using PSPublicMessagingAPI.Desktop.Presenter.View;
using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingAPI.Desktop.Presenter.Presenter;

public interface INewNotificationPresenter : IPresenter<INewNotification>
{
    Task<List<Notification>> GetAllNotifications();
    Task<int> RemoveNotification(Guid notificationId);
    Task<Notification> SaveNotification(Notification selectedNotification);
}