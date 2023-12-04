using PSPublicMessagingAPI.Application.Abstractions.Messaging;

namespace PSPublicMessagingAPI.Application.Notifications.Commands.DeleteNotification;

public sealed record DeleteNotificationCommand(Guid id) : ICommand<Guid>;