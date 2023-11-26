using System;
using System.Threading.Tasks;
using MassTransit;
using PSPublicMessagingAPI.Contract;

namespace PSPublicMessagingAPI.Desktop.Consumers;

internal class NotificationCreatedConsumer : IConsumer<NotificationCreatedEvent>
{
    public Task Consume(ConsumeContext<NotificationCreatedEvent> context)
    {
        throw new NotImplementedException();
    }
}