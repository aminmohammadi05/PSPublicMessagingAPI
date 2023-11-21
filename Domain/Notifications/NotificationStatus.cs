using System.Runtime.Serialization;

namespace PSPublicMessagingAPI.Domain.Notifications;

public enum NotificationStatus
{
    Expired = 0,
    New = 1,
    Read = 2,
    ReadyToPublish = 3
}