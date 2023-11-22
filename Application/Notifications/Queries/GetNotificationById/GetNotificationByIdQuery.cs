using PSPublicMessagingAPI.Application.Abstractions.Messaging;

namespace Application.Notifications.Queries.GetNotificationById;

public sealed record GetNotificationByIdQuery(Guid notificationId) : IQuery<NotificationResponse>;