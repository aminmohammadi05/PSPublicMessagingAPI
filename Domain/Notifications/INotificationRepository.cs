namespace PSPublicMessagingAPI.Domain.Notifications;
public interface INotificationRepository
{
    Task<Notification?> GetNotificationByIdAsync(Guid id, CancellationToken cancellationToken = default);
    void Add(Notification notification);
    Task<Notification?> UpdateNotification(Notification notification, CancellationToken cancellationToken = default);
    Task<Notification> DeleteById(Guid id, CancellationToken cancellationToken = default);
}
