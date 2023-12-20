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

    public async Task<Notification> GetNotificationByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var notification =
            await DbContext.Set<Notification>().FirstOrDefaultAsync(x => x.Id == id);
        if (notification == null)
        {
            throw new ArgumentException("Notification cannot be deleted");

        }


        return notification;

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

    //public async Task<Notification?> UpdateNotification(Notification notification, CancellationToken cancellationToken = default)
    //{
    //    var notificationToUpdate =
    //        await DbContext.Set<Notification>().FirstOrDefaultAsync(x => x.Id == notification.Id);
    //    if (notificationToUpdate == null)
    //    {
    //        throw new ArgumentException("Notification cannot be updated");
    //    }
    //    var ii = DbContext.Set<Notification>().Where(s => s.Id == notification.Id).ExecuteUpdate(s =>
    //        s.SetProperty(e => e.NotificationStatus, e => notification.NotificationStatus)
    //            .SetProperty(e => e.NotificationPriority, e => notification.NotificationPriority)
    //            .SetProperty(e => e.NotificationDate, e => notification.NotificationDate)
    //            .SetProperty(e => e.NotificationText, e => notification.NotificationText)
    //            .SetProperty(e => e.NotificationTitle, e => notification.NotificationTitle)
    //            .SetProperty(e => e.TargetGroup, e => notification.TargetGroup)

    //    );

    //   // DbContext.Set<Notification>().Update(notification);

    //    return notification;
    //}
}
