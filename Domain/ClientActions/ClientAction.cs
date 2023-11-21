using PSPublicMessagingAPI.Domain.Abstractions;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Domain.ClientActions;
public sealed class ClientAction : Entity
{
    public ClientAction(Guid id) : base(id)
    {
        
    }
    
    public Guid PossibleActionId { get; private set; }
    
    public UserName ClientUserName { get; private set; }
    
    public UserName TargetClientUserName { get; private set; }
}
