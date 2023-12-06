using PSPublicMessagingAPI.Application.Abstractions.Messaging;

namespace PSPublicMessagingAPI.Application.ClientActions.Queries.ClientActionByUsername;


public sealed record GetClientActionsByUsernameQuery(string username) : IQuery<List<ClientActionResponse>>;