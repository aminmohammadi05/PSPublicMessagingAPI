namespace PSPublicMessagingAPI.Contract;

public record NotificationUpdatedEvent(Guid Id, string notificationTitle, DateTime notificationDate);