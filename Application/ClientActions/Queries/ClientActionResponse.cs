using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Application.ClientActions.Queries;

public sealed class ClientActionResponse
{
    public Guid Id { get; set; }
    public Guid PossibleActionId { get; set; }

    public string ClientUserName { get; set; }

    public string TargetClientUserName { get; set; }
}