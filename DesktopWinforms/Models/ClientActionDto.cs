using System;
using PSPublicMessagingAPI.Domain.Shared;

namespace DesktopWinforms.Models;

public class ClientActionDto
{
    public Guid Id { get; set; }
    public Guid PossibleActionId { get; private set; }

    public string ClientUserName { get; private set; }

    public string TargetClientUserName { get; private set; }
}