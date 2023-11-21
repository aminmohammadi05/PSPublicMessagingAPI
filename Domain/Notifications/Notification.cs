

using PSPublicMessagingAPI.Domain.Abstractions;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Domain.Notifications;
public sealed class Notification : Entity
{
    public Notification(Guid id) : base(id)
    {

    }

    public NotificationTitle NotificationTitle { get; private set; }

    public NotificationText NotificationText { get; private set; }
    //
    //public string ModuleName { get; set; }

    public int PossibleActionId { get; private set; }

    public UserName ClientUserName { get; private set; }

    public ClientGroup ClientGroup { get; private set; }

    public UserName TargetClientUserName { get; private set; }

    public ClientGroup TargetClientGroup { get; private set; }

    public ActiveDirectoryGroupName TargetGroup { get; private set; }

    public ClientName ClientFullName { get; private set; }

    public ClientName TargetClientFullName { get; private set; }

    public NotificationStatus NotificationStatus { get; private set; }

    public NotificationPriority NotificationPriority { get; private set; }

    public DateTime NotificationDate { get; private set; }

    public MethodParameter MethodParameter { get; private set; }

    public UserName LastModifierUser { get; private set; }
}
