namespace PSPublicMessagingAPI.Domain.Notifications;
public interface INotificationRepository
{
    Task<Notification?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    void Add(Notification notification);
}
