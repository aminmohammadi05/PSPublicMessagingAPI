using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.UserRoles;

namespace PSPublicMessagingAPI.Desktop.Presenter;

public interface ICommunicationApplicationController
{
    IList<object> GetUserActions(string user);
    List<object> ClientActions { get; set; }

    Task<List<Notification>> GetUserUnreadNotifications(string user, string OU);
    Notification SetNotificationStatus(Guid notification, string lastModifierUser, NotificationStatus read);
    Notification GetNotificationById(Guid notificationId);
    Task<List<Notification>> GetAllNotifications(string user, string OU);
    Task<List<Notification>> GetNotificationsByStatus(string user, string OU, NotificationStatus status);
    Task<Notification> SaveNotification(Notification notification);


    #region Notification
    Task<List<Notification>> GetAllNotifications();
    Task<List<UserRole>> GetUserRole(string userName);
    void RunCreateNewNotification();
    Task<int> RemoveNotification(Guid notificationId);
    #endregion


}