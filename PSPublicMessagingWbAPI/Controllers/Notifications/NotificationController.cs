using Application.Notifications.Queries.GetNotificationById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PSPublicMessagingAPI.Application.ClientActions.Queries;
using PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;

namespace PSPublicMessagingWbAPI.Controllers.Notifications;

[ApiController]
[Route("api/clientactions")]
public class NotificationController : ControllerBase
{
    private readonly ISender _sender;

    public NotificationController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> GetNotifications(
        CancellationToken cancellationToken)
    {
        var query = new GetClientActionQuery();

        var result = await _sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetNotification(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetNotificationByIdQuery(id);

        var result = await _sender.Send(query, cancellationToken);

        return result.IsSuccess ? Ok(result.Value) : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> CreateNotification(
        CreateNotificationRequest request,
        CancellationToken cancellationToken)
    {
        var command = new CreateNotificationCommand(
            request.possibleActionId,
             request.notificationTitle,
             request.notificationText,
             request.clientUserName,
             request.clientGroup,
             request.targetClientUserName,
             request.targetClientGroup,
             request.targetGroup,
             request.clientFullName,
             request.targetClientFullName,
             request.notificationStatus,
             request.notificationPriority,
             request.methodParameter,
             request.lastModifiedUser);

        var result = await _sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return CreatedAtAction(nameof(GetNotification), new { id = result.Value }, result.Value);
    }
}