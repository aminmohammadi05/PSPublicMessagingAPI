using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsAll;

public sealed record GetNotificationsAllQuery() : IQuery<List<NotificationResponse>>;