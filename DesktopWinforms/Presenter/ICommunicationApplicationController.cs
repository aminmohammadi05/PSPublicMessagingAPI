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

    
    #region Client Actions

    Task<List<ClientActionDto>> GetAllClientActionsAsync();
    #endregion
    #region Possible Actions
    Task<List<PossibleActionDto>> GetAllPossibleActionsAsync();
    #endregion  

    #region Notification
    Task<List<NotificationDto>> GetAllNotificationsAsync();
    Task<UserRole> GetUserRoleAsync(string userName);
    void RunCreateNewNotification();
    Task<Guid> RemoveNotificationAsync(Guid notificationId);
    Task<Guid> SetNotificationStatusAsync(NotificationDto notification);
    NotificationDto GetNotificationByIdAsync(Guid notificationId);
    NotificationDto GetNotificationById(Guid notificationId);
    Task<List<NotificationDto>> GetAllNotificationsByOUAsync(string OU);
    Task<List<NotificationDto>> GetNotificationsByStatusAsync(string OU, NotificationStatus status);
    Task<Guid> SaveNotificationAsync(NotificationDto notification);
    #endregion


}