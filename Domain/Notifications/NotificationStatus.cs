using System.Runtime.Serialization;

namespace PSPublicMessagingAPI.Domain.Notifications;

public enum NotificationStatus
{
    Expired = 1,
    New = 2,
    Read = 3,
    ReadyToPublish = 4
}