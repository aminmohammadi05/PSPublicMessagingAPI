using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Domain.Notifications.Events;

public sealed record NotificationCreatedDomainEvent(Guid NotificationId) : IDomainEvent;