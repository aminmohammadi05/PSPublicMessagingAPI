using PSPublicMessagingAPI.Domain.PossibleActions;

namespace PSPublicMessagingAPI.Domain.UserRoles;

public interface IUserRoleRepository
{
    Task<UserRole?> GetByUserNameAsync(string userName, CancellationToken cancellationToken = default);
}