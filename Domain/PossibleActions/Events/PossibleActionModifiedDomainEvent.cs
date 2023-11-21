﻿using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Domain.PossibleActions.Events;

public sealed record PossibleActionModifiedDomainEvent(Guid PossibleActionId) : IDomainEvent;