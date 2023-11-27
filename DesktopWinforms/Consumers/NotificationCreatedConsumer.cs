using System;
using System.Threading.Tasks;
using AutoMapper;
using DesktopWinforms.Services;
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
    public IDispatcher _dispatcher { get; set; }
    public NotificationCreatedConsumer(ILogger<NotificationCreatedEvent> logger, IDispatcher dispatcher)
    {
        _logger = logger;
        _dispatcher = dispatcher;
    }

    public async Task Consume(ConsumeContext<NotificationCreatedEvent> context)
    {
        //Notification notif = _communicationService.GetNotificationById(e.Entity.NotificationId);
        _logger.LogInformation("Received Text: {Text}", context.Message.notificationTitle);
        await _dispatcher.RunAsync();

    }
}