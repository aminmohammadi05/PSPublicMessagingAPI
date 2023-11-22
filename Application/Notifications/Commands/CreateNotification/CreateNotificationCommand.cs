using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;

public record CreateNotificationCommand(
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
    string lastModifiedUser) : ICommand<Guid>;