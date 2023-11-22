using MediatR;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.Notifications.Events;

namespace PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;

internal sealed class NotificationCreatedDomainEventHandler : INotificationHandler<NotificationCreatedDomainEvent>
{
    private readonly INotificationRepository _notificationRepository;

    public NotificationCreatedDomainEventHandler(
        INotificationRepository notificationRepository)
    {
        _notificationRepository = notificationRepository;
    }

    public async Task Handle(NotificationCreatedDomainEvent notification, CancellationToken cancellationToken)
    {
        var notificationResult = await _notificationRepository.GetByIdAsync(notification.NotificationId, cancellationToken);

        if (notificationResult is null)
        {
            return;
        }

       // publish to rabbitmq
    }
}