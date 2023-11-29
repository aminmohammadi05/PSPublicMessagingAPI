using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserName;

public sealed record GetNotificationsByUserNameQuery(string username) : IQuery<List<NotificationResponse>>;