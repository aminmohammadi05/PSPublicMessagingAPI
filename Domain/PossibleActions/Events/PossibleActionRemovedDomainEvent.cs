using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Domain.PossibleActions.Events;

public sealed record PossibleActionRemovedDomainEvent(Guid PossibleActionId) : IDomainEvent;