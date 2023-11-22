using PSPublicMessagingAPI.Domain.ClientActions;
using PSPublicMessagingAPI.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPublicMessagingAPI.Infrastructure.Repositories;
internal sealed class ClientActionRepository : Repository<ClientAction>, IClientActionRepository
{
    public ClientActionRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}
