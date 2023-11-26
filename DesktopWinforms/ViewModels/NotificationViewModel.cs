using PSPublicMessagingAPI.Domain.Notifications;
using System;
using System.Runtime.Serialization;

namespace PSPublicMessagingAPI.Desktop.ViewModels;

public class NotificationViewModel : ObservableObject
{
    private Guid notificationId = Guid.Empty;
    private string notificationTitle;
    private string notificationText;
    private int possibleActionId;
    private string clientUserName;
    private string clientGroup;
    private string targetClientUserName;
    private string targetClientGroup;
    private string targetGroup;
    private NotificationStatus notificationStatus;
    private string notificationStatusText;
    private string notificationStatusIcon;
    private NotificationPriority notificationPriority;
    private string notificationPriorityText;
    private string notificationPriorityIcon;
    private DateTime notificationDate;
    private string notificationDatePersian;
    private string notificationTimePersian;
    private string possibleActionMethodToCall;
    private string possibleActionFormName;
    private string methodParameter;
    private string possibleActionName;
    private string possibleActionModuleName;
    private string clientFullName;
    private string targetClientFullName;
    private string lastModifierUser;
    private bool sendToAll;

    
    public Guid NotificationId
    {
        get => notificationId;
        set
        {
            notificationId = value;
            OnPropertyChanged(nameof(NotificationId));

        }
    }
    
    public string NotificationTitle
    {
        get => notificationTitle;
        set
        {
            notificationTitle = value;
            OnPropertyChanged(nameof(NotificationTitle));
        }
    }
    
    public string NotificationText
    {
        get => notificationText; set
        {
            notificationText = value;
            OnPropertyChanged(nameof(NotificationText));
        }
    }
    
    public int PossibleActionId
    {
        get => possibleActionId; set
        {
            possibleActionId = value;
            OnPropertyChanged(nameof(PossibleActionId));
        }
    }
    
    public string ClientUserName
    {
        get => clientUserName; set
        {
            clientUserName = value;
            OnPropertyChanged(nameof(ClientUserName));
        }
    }
    
    public string ClientGroup
    {
        get => clientGroup; set
        {
            clientGroup = value;
            OnPropertyChanged(nameof(ClientGroup));
        }
    }
    
    public string TargetClientUserName
    {
        get => targetClientUserName; set
        {
            targetClientUserName = value;
            OnPropertyChanged(nameof(TargetClientUserName));
        }
    }
    
    public string TargetClientGroup
    {
        get => targetClientGroup; set
        {
            targetClientGroup = value;
            OnPropertyChanged(nameof(TargetClientGroup));
        }
    }
    
    public string TargetGroup
    {
        get => targetGroup;
        set
        {

            targetGroup = value;
            OnPropertyChanged(nameof(TargetGroup));
        }
    }
    
    public NotificationStatus NotificationStatus
    {
        get => notificationStatus; set
        {
            notificationStatus = value;
            OnPropertyChanged(nameof(NotificationStatus));
        }
    }
    
    public string NotificationStatusText
    {
        get => notificationStatusText; set
        {
            notificationStatusText = value;
            OnPropertyChanged(nameof(NotificationStatusText));
        }
    }
    
    public string NotificationStatusIcon
    {
        get => notificationStatusIcon; set
        {
            notificationStatusIcon = value;
            OnPropertyChanged(nameof(NotificationStatusIcon));
        }
    }
    
    public NotificationPriority NotificationPriority
    {
        get => notificationPriority; set
        {
            notificationPriority = value;
            OnPropertyChanged(nameof(NotificationPriority));
        }
    }
    
    public string NotificationPriorityText
    {
        get => notificationPriorityText; set
        {
            notificationPriorityText = value;
            OnPropertyChanged(nameof(NotificationPriorityText));
        }
    }
    
    public string NotificationPriorityIcon
    {
        get => notificationPriorityIcon; set
        {
            notificationPriorityIcon = value;
            OnPropertyChanged(nameof(NotificationPriorityIcon));
        }
    }
    
    public DateTime NotificationDate
    {
        get => notificationDate; set
        {
            notificationDate = value;
            OnPropertyChanged(nameof(NotificationDate));
        }
    }
    
    public string NotificationDatePersian
    {
        get => notificationDatePersian; set
        {
            notificationDatePersian = value;
            OnPropertyChanged(nameof(NotificationDatePersian));
        }
    }
    
    public string NotificationTimePersian
    {
        get => notificationTimePersian; set
        {
            notificationTimePersian = value;
            OnPropertyChanged(nameof(NotificationTimePersian));
        }
    }
    
    public string MethodParameter
    {
        get => methodParameter; set
        {
            methodParameter = value;
            OnPropertyChanged(nameof(MethodParameter));
        }
    }
    
    public string PossibleActionName
    {
        get => possibleActionName; set
        {
            possibleActionName = value;
            OnPropertyChanged(nameof(PossibleActionName));
        }
    }
    
    public string PossibleActionModuleName
    {
        get => possibleActionModuleName; set
        {
            possibleActionModuleName = value;
            OnPropertyChanged(nameof(PossibleActionModuleName));
        }
    }
    
    public string ClientFullName
    {
        get => clientFullName; set
        {
            clientFullName = value;
            OnPropertyChanged(nameof(ClientFullName));
        }
    }
    
    public string TargetClientFullName
    {
        get => targetClientFullName; set
        {
            targetClientFullName = value;
            OnPropertyChanged(nameof(TargetClientFullName));
        }
    }
    
    public string LastModifierUser
    {
        get => lastModifierUser;
        set
        {
            lastModifierUser = value;
            OnPropertyChanged(nameof(LastModifierUser));
        }
    }

    public string PossibleActionMethodToCall
    {
        get => possibleActionMethodToCall;
        set
        {
            possibleActionMethodToCall = value;
            OnPropertyChanged(nameof(PossibleActionMethodToCall));
        }
    }
    public string PossibleActionFormName
    {
        get => possibleActionFormName;
        set
        {
            possibleActionFormName = value;
            OnPropertyChanged(nameof(PossibleActionFormName));
        }
    }

}