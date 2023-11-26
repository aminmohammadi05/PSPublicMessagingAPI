using PSPublicMessagingAPI.Domain.Abstractions;
using System.Runtime.Serialization;

namespace PSPublicMessagingAPI.Domain.UserRoles;

public sealed class UserRole : Entity
{
    
    public string UserName { get;  set; }
    
    public string RoleName { get;  set; }
}