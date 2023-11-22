using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Infrastructure.Repositories;
using PSPublicMessagingAPI.Infrastructure;
using PSPublicMessagingAPI.Domain.PossibleActions;

namespace Infrastructure.Repositories;

internal sealed class PossibleActionRepository : Repository<PossibleAction>, IPossibleActionRepository
{
    public PossibleActionRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}