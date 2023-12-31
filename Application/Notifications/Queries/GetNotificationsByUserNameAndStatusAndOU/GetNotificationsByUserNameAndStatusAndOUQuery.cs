using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserNameAndStatusAndOUQuery;

public record GetNotificationsByUserNameAndStatusAndOUQuery(string username, int status, string OU) : IQuery<List<NotificationResponse>>;