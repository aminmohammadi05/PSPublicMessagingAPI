using MassTransit;
using Microsoft.AspNetCore.SignalR;
using PSNotificationServiceAPI.Hubs;
using PSPublicMessagingAPI.Contract;

namespace PSNotificationServiceAPI.Consumers;

public class NotificationCreatedConsumer: IConsumer<NotificationCreatedEvent>
{
    private readonly IHubContext<NotificationHub> _hubContext;

    public NotificationCreatedConsumer(IHubContext<NotificationHub> hubContext)
    {
        _hubContext = hubContext;
    }
    public async Task Consume(ConsumeContext<NotificationCreatedEvent> context)
    {
        Console.WriteLine("---> Notification created message received");
        await _hubContext.Clients.All.SendAsync("NotificationCreated", context.Message);
        //await _hubContext.Clients.All.SendCoreAsync("NotificationCreated ", new object[] { context.Message });
    }
}