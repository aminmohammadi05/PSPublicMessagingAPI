using PSPublicMessagingAPI.Application.Abstractions.Messaging;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;

public sealed record GetNotificationByIdQuery(Guid notificationId) : IQuery<NotificationResponse>;