using PSPublicMessagingAPI.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWinforms.Models
{
    public sealed class NotificationDto
    {


        public Guid Id { get; set; }
        

        public string NotificationTitle { get; set; }

        public string NotificationText { get; set; }

        public Guid PossibleActionId { get; set; }

        public string ClientUserName { get; set; }

        public string ClientGroup { get; set; }

        public string TargetClientUserName { get; set; }

        public string TargetClientGroup { get; set; }

        public string TargetGroup { get; set; }

        public NotificationStatus NotificationStatus { get; set; }
       

        public NotificationPriority NotificationPriority { get; set; }

        public DateTime NotificationDate { get; set; }

        public string MethodParameter { get; set; }

        public string ClientFullName { get; set; }

        public string TargetClientFullName { get; set; }

        public string LastModifierUser { get; set; }

        internal void ChangeStatus(NotificationStatus @new)
        {
            NotificationStatus = @new;
        }

        
    }
}
