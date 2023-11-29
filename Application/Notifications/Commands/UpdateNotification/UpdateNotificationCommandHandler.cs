using MassTransit;
using PSPublicMessagingAPI.Application.Abstractions.Clock;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Domain.Abstractions;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Application.Notifications.Commands.UpdateNotification;

public class UpdateNotificationCommandHandler : ICommandHandler<UpdateNotificationCommand, Guid>
{
    private readonly INotificationRepository _notificationRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly IPublishEndpoint _publishEndpoint;

    public UpdateNotificationCommandHandler(
        INotificationRepository notificationRepository,
        IUnitOfWork unitOfWork,
        IDateTimeProvider dateTimeProvider,
        IPublishEndpoint publishEndpoint)
    {
        _notificationRepository = notificationRepository;
        _unitOfWork = unitOfWork;
        _dateTimeProvider = dateTimeProvider;
        _publishEndpoint = publishEndpoint;
    }

    public async Task<Result<Guid>> Handle(UpdateNotificationCommand request, CancellationToken cancellationToken)
    {


        try
        {
            var notification = Notification.Update(
                request.Id,
                request.possibleActionId,
                new NotificationTitle(request.notificationTitle),
                new NotificationText(request.notificationText),
                new UserName(request.clientUserName),
                new ClientGroup(request.clientGroup),
                new UserName(request.targetClientUserName),
                new ClientGroup(request.targetClientGroup),
                new ActiveDirectoryGroupName(request.targetGroup),
                new ClientName(request.clientFullName),
                new ClientName(request.targetClientFullName),
                request.notificationStatus,
                request.notificationPriority,
                _dateTimeProvider.UtcNow,
                MethodParameter.Create(request.methodParameter),
                new UserName(request.lastModifiedUser));

            Notification notifi = await _notificationRepository.UpdateNotification(notification);

            await _unitOfWork.SaveChangesAsync(cancellationToken);
            await _publishEndpoint.Publish(
                new NotificationUpdatedEvent(
                    notifi.Id,
                    notifi.NotificationTitle.Value,
                    notifi.NotificationDate)
                , cancellationToken);

            return notification.Id;
        }
        catch (ConcurrencyException)
        {
            return Result.Failure<Guid>(NotificationErrors.NotReserved);
        }
    }
}