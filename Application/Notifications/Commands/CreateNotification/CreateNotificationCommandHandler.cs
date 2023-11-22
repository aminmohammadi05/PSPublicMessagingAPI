using PSPublicMessagingAPI.Application.Abstractions.Clock;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Exceptions;
using PSPublicMessagingAPI.Domain.Abstractions;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;

internal sealed class CreateNotificationCommandHandler : ICommandHandler<CreateNotificationCommand, Guid>
{
    private readonly INotificationRepository _notificationRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDateTimeProvider _dateTimeProvider;

    public CreateNotificationCommandHandler(
        INotificationRepository notificationRepository,
        IUnitOfWork unitOfWork,
        IDateTimeProvider dateTimeProvider)
    {
        _notificationRepository = notificationRepository;
        _unitOfWork = unitOfWork;
        _dateTimeProvider = dateTimeProvider;
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

            return newNotification.Id;
        }
        catch (ConcurrencyException)
        {
            return Result.Failure<Guid>(NotificationErrors.NotReserved);
        }
    }
}