using MassTransit;
using MediatR;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.Notifications.Events;

namespace PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;

internal sealed class NotificationCreatedDomainEventHandler : INotificationHandler<NotificationCreatedDomainEvent>
{
    private readonly INotificationRepository _notificationRepository;
    private readonly IPublishEndpoint _publishEndpoint;

    public NotificationCreatedDomainEventHandler(
        INotificationRepository notificationRepository, IPublishEndpoint publishEndpoint)
    {
        _notificationRepository = notificationRepository;
        _publishEndpoint = publishEndpoint;
    }

    public async Task Handle(NotificationCreatedDomainEvent notification, CancellationToken cancellationToken)
    {
        var notificationResult = await _notificationRepository.GetNotificationByIdAsync(notification.NotificationId, cancellationToken);

        if (notificationResult is null)
        {
            return;
        }

        await _publishEndpoint.Publish(
            new NotificationCreatedEvent(
                notificationResult.Id,
                notificationResult.NotificationTitle.Value,
                notificationResult.NotificationDate)
            , cancellationToken);
    }
}