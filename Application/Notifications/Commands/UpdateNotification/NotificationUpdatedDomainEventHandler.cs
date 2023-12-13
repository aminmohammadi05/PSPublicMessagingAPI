using MassTransit;
using MediatR;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.Notifications.Events;

namespace PSPublicMessagingAPI.Application.Notifications.Commands.UpdateNotification;

internal sealed class NotificationUpdatedDomainEventHandler : INotificationHandler<NotificationStateChangedDomainEvent>
{
    private readonly INotificationRepository _notificationRepository;
    private readonly IPublishEndpoint _publishEndpoint;

    public NotificationUpdatedDomainEventHandler(
        INotificationRepository notificationRepository, IPublishEndpoint publishEndpoint)
    {
        _notificationRepository = notificationRepository;
        _publishEndpoint = publishEndpoint;
    }

    public async Task Handle(NotificationStateChangedDomainEvent notification, CancellationToken cancellationToken)
    {
        var notificationResult = await _notificationRepository.GetNotificationByIdAsync(notification.NotificationId, cancellationToken);

        if (notificationResult is null)
        {
            return;
        }

        await _publishEndpoint.Publish(
            new NotificationUpdatedEvent(
                notificationResult.Id,
                notificationResult.NotificationTitle.Value,
                notificationResult.NotificationDate)
            , cancellationToken);
    }
}