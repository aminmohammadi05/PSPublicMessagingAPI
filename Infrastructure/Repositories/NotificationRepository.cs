using PSPublicMessagingAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingAPI.Infrastructure.Repositories;
internal sealed class NotificationRepository : Repository<Notification>, INotificationRepository
{
    public NotificationRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}
