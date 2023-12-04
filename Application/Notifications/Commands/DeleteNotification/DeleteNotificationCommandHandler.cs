using MassTransit;
using PSPublicMessagingAPI.Application.Abstractions.Clock;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Domain.Abstractions;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Application.Notifications.Commands.DeleteNotification;

public class DeleteNotificationCommandHandler : ICommandHandler<DeleteNotificationCommand, Guid>
{
    private readonly INotificationRepository _notificationRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly IPublishEndpoint _publishEndpoint;

    public DeleteNotificationCommandHandler(
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

    public async Task<Result<Guid>> Handle(DeleteNotificationCommand request, CancellationToken cancellationToken)
    {


        try
        {
           

            Notification result = await _notificationRepository.DeleteById(request.id, cancellationToken);
            
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            await _publishEndpoint.Publish(
                new NotificationDeletedEvent(result.Id)
                , cancellationToken);

            return result.Id;
        }
        catch (ConcurrencyException)
        {
            return Result.Failure<Guid>(NotificationErrors.NotReserved);
        }
    }
}