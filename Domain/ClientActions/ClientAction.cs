using PSPublicMessagingAPI.Domain.Abstractions;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Domain.ClientActions;
public sealed class ClientAction : Entity
{
    private ClientAction(Guid id) : base(id)
    {
        
    }

    private ClientAction()
    {
        
    }
    
    public Guid PossibleActionId { get; private set; }
    
    public UserName ClientUserName { get; private set; }
    
    public UserName TargetClientUserName { get; private set; }
}
