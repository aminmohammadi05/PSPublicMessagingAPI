using MassTransit;
using PSPublicMessagingAPI.Contract;


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
