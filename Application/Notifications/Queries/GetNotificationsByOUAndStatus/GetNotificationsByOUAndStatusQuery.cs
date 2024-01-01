using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByOUAndStatus;

public record GetNotificationsByOUAndStatusQuery(string OU, int status) : IQuery<List<NotificationResponse>>;