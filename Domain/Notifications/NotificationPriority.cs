using System.Runtime.Serialization;

namespace PSPublicMessagingAPI.Domain.Notifications;

public enum NotificationPriority
{
    Low = 0,
    Medium = 1,
    High = 2,
    Critical = 3,
}