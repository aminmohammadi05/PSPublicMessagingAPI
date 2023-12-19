using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserNameAndStatus;

public sealed record GetNotificationsByUserNameAndStatusQuery(string username, int status) : IQuery<List<NotificationResponse>>;