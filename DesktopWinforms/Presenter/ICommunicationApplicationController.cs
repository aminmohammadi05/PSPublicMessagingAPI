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

    Task<List<NotificationDto>> GetUserUnreadNotificationsAsync(string user, string OU);
    Task<NotificationDto> SetNotificationStatusAsync(NotificationDto notification);
    Task<NotificationDto> GetNotificationByIdAsync(Guid notificationId);
    NotificationDto GetNotificationById(Guid notificationId);
    Task<List<NotificationDto>> GetAllNotificationsByUsernameAsync(string user, string OU);
    Task<List<NotificationDto>> GetNotificationsByStatusAsync(string user, string OU, NotificationStatus status);
    Task<NotificationDto> SaveNotificationAsync(NotificationDto notification);


    #region Notification
    Task<List<NotificationDto>> GetAllNotificationsAsync();
    Task<UserRole> GetUserRoleAsync(string userName);
    void RunCreateNewNotification();
    Task<Guid> RemoveNotificationAsync(Guid notificationId);
    #endregion


}