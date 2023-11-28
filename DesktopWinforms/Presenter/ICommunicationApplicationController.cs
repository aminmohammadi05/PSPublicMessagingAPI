using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesktopWinforms.Models;
using PSPublicMessagingAPI.Desktop.ViewModels;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.UserRoles;

namespace PSPublicMessagingAPI.Desktop.Presenter;

public interface ICommunicationApplicationController
{
    IList<object> GetUserActions(string user);
    List<object> ClientActions { get; set; }

    Task<List<NotificationDto>> GetUserUnreadNotifications(string user, string OU);
    Task<NotificationDto> SetNotificationStatus(Guid notification, string lastModifierUser, NotificationStatus read);
    Task<NotificationDto> GetNotificationByIdAsync(Guid notificationId);
    NotificationDto GetNotificationById(Guid notificationId);
    Task<List<NotificationDto>> GetAllNotifications(string user, string OU);
    Task<List<NotificationDto>> GetNotificationsByStatus(string user, string OU, NotificationStatus status);
    Task<NotificationDto> SaveNotification(NotificationDto notification);


    #region Notification
    Task<List<NotificationDto>> GetAllNotifications();
    Task<List<UserRole>> GetUserRole(string userName);
    void RunCreateNewNotification();
    Task<int> RemoveNotification(Guid notificationId);
    #endregion


}