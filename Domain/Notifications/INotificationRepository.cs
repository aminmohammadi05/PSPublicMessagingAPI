namespace PSPublicMessagingAPI.Domain.Notifications;
internal interface INotificationRepository
{
    Task<Notification?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
