using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Domain.Notifications.Events;

public sealed record NotificationStateChangedDomainEvent(Guid NotificationId) : IDomainEvent;