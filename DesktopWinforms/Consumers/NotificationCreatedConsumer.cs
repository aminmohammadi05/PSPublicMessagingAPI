using System;
using System.Threading.Tasks;
using AutoMapper;
using DevExpress.Utils.MVVM.Services;
using MassTransit;
using Microsoft.Extensions.Logging;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingAPI.Desktop.Consumers;

internal class NotificationCreatedConsumer : IConsumer<NotificationCreatedEvent>
{
    readonly ILogger<NotificationCreatedEvent> _logger;
   
    public delegate void MessageEventHandler(object sender, NotificationCreatedEvent notification);
    public event MessageEventHandler MessageReceived;
    public NotificationCreatedConsumer(ILogger<NotificationCreatedEvent> logger)
    {
        _logger = logger;
       
    }

    public Task Consume(ConsumeContext<NotificationCreatedEvent> context)
    {
        //Notification notif = _communicationService.GetNotificationById(e.Entity.NotificationId);
        _logger.LogInformation("Received Text: {Text}", context.Message.notificationTitle);
        MessageReceived(this, context.Message);
        return Task.CompletedTask;
    }
}