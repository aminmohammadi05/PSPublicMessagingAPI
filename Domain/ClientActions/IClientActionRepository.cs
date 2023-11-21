using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingAPI.Domain.ClientActions;

public interface IClientActionRepository
{
    Task<ClientAction?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}