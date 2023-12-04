using PSPublicMessagingAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Domain.Notifications;
using Microsoft.EntityFrameworkCore;
using PSPublicMessagingAPI.Domain.UserRoles;

namespace PSPublicMessagingAPI.Infrastructure.Repositories;
internal sealed class NotificationRepository : Repository<Notification>, INotificationRepository
{
    public NotificationRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }

    public async Task<Notification> DeleteById(Guid id, CancellationToken cancellationToken)
    {
        var notificationToDelete =
            await DbContext.Set<Notification>().FirstOrDefaultAsync(x => x.Id == id);
        if (notificationToDelete == null)
        {
            throw new ArgumentException("Notification cannot be deleted");
           
        }


        return DbContext.Set<Notification>().Remove(notificationToDelete).Entity;

    }

    public async Task<Notification?> UpdateNotification(Notification notification, CancellationToken cancellationToken = default)
    {
        var notificationToUpdate =
            await DbContext.Set<Notification>().FirstOrDefaultAsync(x => x.Id == notification.Id);
        if (notificationToUpdate == null)
        {
            throw new ArgumentException("Notification cannot be updated");
        }
     

        DbContext.Set<Notification>().Update(notification);

        return notification;
    }
}
