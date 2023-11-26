using PSPublicMessagingAPI.Domain.ClientActions;
using PSPublicMessagingAPI.Infrastructure.Repositories;
using PSPublicMessagingAPI.Infrastructure;
using PSPublicMessagingAPI.Domain.UserRoles;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

internal sealed class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
{
    public UserRoleRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }

    public async Task<UserRole?> GetByUserNameAsync(string userName, CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<UserRole>()
            .FirstOrDefaultAsync(user => user.UserName == userName, cancellationToken);
    }
}