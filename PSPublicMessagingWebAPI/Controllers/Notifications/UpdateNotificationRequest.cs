using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingWebAPI.Controllers.Notifications;

public sealed record UpdateNotificationRequest(Guid Id,
    Guid possibleActionId,
    string notificationTitle,
    string notificationText,
    string clientUserName,
    string clientGroup,
    string targetClientUserName,
    string targetClientGroup,
    string targetGroup,
    string clientFullName,
    string targetClientFullName,
    NotificationStatus notificationStatus,
    NotificationPriority notificationPriority,
    string methodParameter,
    string lastModifiedUser);