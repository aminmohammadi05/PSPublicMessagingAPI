using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingAPI.Domain.PossibleActions;

public interface IPossibleActionRepository
{
    Task<PossibleAction?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}