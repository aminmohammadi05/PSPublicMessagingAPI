namespace PSPublicMessagingAPI.Application.Contracts;

public record NotificationCreatedEvent(Guid Id, string notificationTitle, DateTime notificationDate);