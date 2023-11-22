using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.ClientActions;

namespace PSPublicMessagingAPI.Application.PossibleActions.Queries;

public sealed record GetPossibleActionQuery : IQuery<IReadOnlyList<GetPossibleActionResponse>>;