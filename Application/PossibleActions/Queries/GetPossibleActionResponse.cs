using PSPublicMessagingAPI.Domain.PossibleActions;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Application.PossibleActions.Queries;

public sealed class GetPossibleActionResponse
{
    public Guid Id { get; set; }
    public string PossibleActionName { get; set; }

    public string ModuleName { get; set; }

    public string TargetGroup { get; set; }

    public string FormName { get; set; }

    public string MethodToCall { get; set; }
}