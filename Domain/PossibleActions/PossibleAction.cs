using PSPublicMessagingAPI.Domain.Abstractions;
using System.Runtime.Serialization;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Domain.PossibleActions;
public sealed class PossibleAction : Entity
{
    private PossibleAction(Guid id) : base(id)
    {
        
    }
    public PossibleActionName PossibleActionName { get; set; }
    
    public ModuleName ModuleName { get; set; }
    
    public ActiveDirectoryGroupName TargetGroup { get; set; }
    
    public FormName FormName { get; set; }
    
    public MethodToCall MethodToCall { get; set; }
    
   
}
