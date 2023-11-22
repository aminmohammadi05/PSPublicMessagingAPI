using MassTransit;
using PSPublicMessagingAPI.Application.Abstractions.Clock;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Contracts;
using PSPublicMessagingAPI.Domain.Abstractions;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.Notifications.Events;
using PSPublicMessagingAPI.Domain.Shared;
using ConcurrencyException = PSPublicMessagingAPI.Application.Exceptions.ConcurrencyException;

namespace PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;

internal sealed class CreateNotificationCommandHandler : ICommandHandler<CreateNotificationCommand, Guid>
{
    private readonly INotificationRepository _notificationRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly IPublishEndpoint _publishEndpoint;

    public CreateNotificationCommandHandler(
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

    public async Task<Result<Guid>> Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
    {
        

        try
        {
            var newNotification = Notification.Create(
                request.possibleActionId,
                new NotificationTitle(request.notificationTitle),
                new NotificationText(request.notificationText),
                new UserName(request.clientUserName),
                new ClientGroup( request.clientGroup),
                new UserName( request.targetClientUserName),
                new ClientGroup(request. targetClientGroup),
                new ActiveDirectoryGroupName( request.targetGroup),
                new ClientName( request.clientFullName),
                new ClientName( request.targetClientFullName),
                request.notificationStatus,
                request.notificationPriority,
                _dateTimeProvider.UtcNow,
                MethodParameter.Create( request.methodParameter),
                new UserName( request.lastModifiedUser));

            _notificationRepository.Add(newNotification);

            await _unitOfWork.SaveChangesAsync(cancellationToken);
            await _publishEndpoint.Publish(
                new NotificationCreatedEvent( 
                newNotification.Id,
                newNotification.NotificationTitle.Value,
                newNotification.NotificationDate)
                , cancellationToken);

            return newNotification.Id;
        }
        catch (ConcurrencyException)
        {
            return Result.Failure<Guid>(NotificationErrors.NotReserved);
        }
    }
}