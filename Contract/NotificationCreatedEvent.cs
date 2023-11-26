namespace PSPublicMessagingAPI.Contract;

public record NotificationCreatedEvent(Guid Id, string notificationTitle, DateTime notificationDate);