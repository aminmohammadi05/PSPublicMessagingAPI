using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Domain.Notifications.Events;

public sealed record NotificationRemovedDomainEvent(Guid NotificationId) : IDomainEvent;