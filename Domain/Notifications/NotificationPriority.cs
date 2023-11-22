using System.Runtime.Serialization;

namespace PSPublicMessagingAPI.Domain.Notifications;

public enum NotificationPriority
{
    Low = 1,
    Medium = 2,
    High = 3,
    Critical = 4,
}