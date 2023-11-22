

using PSPublicMessagingAPI.Domain.Abstractions;
using PSPublicMessagingAPI.Domain.Notifications.Events;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Domain.Notifications;
public sealed class Notification : Entity
{
    private Notification(
        Guid id,
        Guid possibleActionId,
        NotificationTitle notificationTitle,
        NotificationText notificationText,
        UserName clientUserName,
        ClientGroup clientGroup,
        UserName targetClientUserName,
        ClientGroup targetClientGroup,
        ActiveDirectoryGroupName targetGroup,
        ClientName clientFullName,
        ClientName targetClientFullName,
        NotificationStatus notificationStatus,
        NotificationPriority notificationPriority,
        DateTime notificationDate,
        MethodParameter methodParameter,
        UserName lastModifiedUser) : base(id)
    {
        PossibleActionId = possibleActionId;
        NotificationTitle = notificationTitle;
        NotificationText = notificationText;
        ClientUserName = clientUserName;
        ClientGroup = clientGroup;
        TargetClientUserName = targetClientUserName;
        TargetClientGroup = targetClientGroup;
        TargetGroup = targetGroup;
        ClientFullName = clientFullName;
        TargetClientFullName = targetClientFullName;
        NotificationStatus = notificationStatus;
        NotificationPriority = notificationPriority;
        NotificationDate = notificationDate;
        MethodParameter = methodParameter;
        LastModifierUser = lastModifiedUser;
    }

    private Notification()
    {

    }

    public NotificationTitle NotificationTitle { get; private set; }

    public NotificationText NotificationText { get; private set; }
    //
    //public string ModuleName { get; set; }

    public Guid PossibleActionId { get; private set; }

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

    public static Notification Create(
        Guid possibleActionId,
        NotificationTitle notificationTitle,
        NotificationText notificationText,
        UserName clientUserName,
        ClientGroup clientGroup,
        UserName targetClientUserName,
        ClientGroup targetClientGroup,
        ActiveDirectoryGroupName targetGroup,
        ClientName clientFullName,
        ClientName targetClientFullName,
        NotificationStatus notificationStatus,
        NotificationPriority notificationPriority,
        DateTime notificationDate,
        MethodParameter methodParameter,
        UserName lastModifiedUser)
    {
        

        var notification = new Notification(
            Guid.NewGuid(),
            possibleActionId,
            notificationTitle,
            notificationText,
            clientUserName,
            clientGroup,
            targetClientUserName,
            targetClientGroup,
            targetGroup,
            clientFullName,
            targetClientFullName,
            notificationStatus,
            notificationPriority,
            notificationDate,
            methodParameter,
            lastModifiedUser);

        notification.RaiseDomainEvent(new NotificationCreatedDomainEvent(notification.Id));

        

        return notification;
    }
}
