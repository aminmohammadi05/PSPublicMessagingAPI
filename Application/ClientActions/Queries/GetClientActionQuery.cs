using PSPublicMessagingAPI.Application.Abstractions.Messaging;

namespace PSPublicMessagingAPI.Application.ClientActions.Queries;

public sealed record GetClientActionQuery : IQuery<IReadOnlyList<ClientActionResponse>>;