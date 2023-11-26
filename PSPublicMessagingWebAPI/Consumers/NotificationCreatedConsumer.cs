using MassTransit;
using PSPublicMessagingAPI.Contract;


namespace PSPublicMessagingWebAPI.Consumers
{
    internal sealed class NotificationCreatedConsumer : IConsumer<NotificationCreatedEvent>
    {
        public Task Consume(ConsumeContext<NotificationCreatedEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
