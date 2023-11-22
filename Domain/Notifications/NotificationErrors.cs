using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Domain.Notifications;

public static class NotificationErrors
{
    public static Error NotFound = new(
        "Notification.Found",
        "The booking with the specified identifier was not found");

    public static Error Overlap = new(
        "Notification.Overlap",
        "The current booking is overlapping with an existing one");

    public static Error NotReserved = new(
        "Notification.NotReserved",
        "The booking is not pending");

    public static Error NotConfirmed = new(
        "Notification.NotReserved",
        "The booking is not confirmed");

    public static Error AlreadyStarted = new(
        "Notification.AlreadyStarted",
        "The booking has already started");
}