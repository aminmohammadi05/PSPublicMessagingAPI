using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingWbAPI.Controllers.Notifications;

public sealed record CreateNotificationRequest(
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