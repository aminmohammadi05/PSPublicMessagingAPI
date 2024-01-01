using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByOUQuery;

public record GetNotificationsByOUQuery(string OU) : IQuery<List<NotificationResponse>>;