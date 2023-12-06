using PSPublicMessagingAPI.Domain.PossibleActions;
using PSPublicMessagingAPI.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWinforms.Models
{
    public sealed class PossibleActionDto
    {
        public Guid Id { get; set; }
        public string PossibleActionName { get; set; }

        public string ModuleName { get; set; }

        public string TargetGroup { get; set; }

        public string FormName { get; set; }

        public string MethodToCall { get; set; }
    }
}
