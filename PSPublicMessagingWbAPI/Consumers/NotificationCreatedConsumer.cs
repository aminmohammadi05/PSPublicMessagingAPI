using MassTransit;
using PSPublicMessagingAPI.Application.Contracts;

namespace PSPublicMessagingWbAPI.Consumers
{
    internal sealed class NotificationCreatedConsumer : IConsumer<NotificationCreatedEvent>
    {
        public Task Consume(ConsumeContext<NotificationCreatedEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
