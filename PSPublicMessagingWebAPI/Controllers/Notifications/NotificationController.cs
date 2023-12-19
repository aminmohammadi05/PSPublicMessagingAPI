using MassTransit;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PSPublicMessagingAPI.Application.ClientActions.Queries;
using PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;
using PSPublicMessagingAPI.Application.Notifications.Commands.DeleteNotification;
using PSPublicMessagingAPI.Application.Notifications.Commands.UpdateNotification;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsAll;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserName;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserNameAndStatus;
using PSPublicMessagingAPI.Contract;

namespace PSPublicMessagingWebAPI.Controllers.Notifications;

[ApiController]
[Route("api/notifications")]
public class NotificationController : ControllerBase
{
    private readonly ISender _sender;
    

    public NotificationController(ISender sender, IPublishEndpoint publishEndpoint)
    {
        _sender = sender;
        
    }

    [HttpGet]
    public async Task<IActionResult> GetNotifications(
        CancellationToken cancellationToken)
    {
        var query = new GetNotificationsAllQuery();

        var result = await _sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }
    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetNotification(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetNotificationByIdQuery(id);

        var result = await _sender.Send(query, cancellationToken);

        return result.IsSuccess ? Ok(result.Value) : NotFound();
    }
    [HttpGet( "{username}")]
    public async Task<IActionResult> GetNotificationsByUserName(string username, CancellationToken cancellationToken)
    {
        var query = new GetNotificationsByUserNameQuery(username);

        var result = await _sender.Send(query, cancellationToken);

        return result.IsSuccess ? Ok(result.Value) : NotFound();
    }

    [HttpGet("{username}/{status:int}")]
    public async Task<IActionResult> GetNotificationsByUserNameAndStatus(string username, int status, CancellationToken cancellationToken)
    {
        var query = new GetNotificationsByUserNameAndStatusQuery(username, status);

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
             request.lastModifierUser);

        var result = await _sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }
        
        return CreatedAtAction(nameof(GetNotification), new { id = result.Value }, result.Value);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateNotificationStatus(
        UpdateNotificationRequest request,
        CancellationToken cancellationToken)
    {
        var command = new UpdateNotificationCommand(
            request.Id, 
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
            request.lastModifierUser);

        var result = await _sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return CreatedAtAction(nameof(GetNotification), new { id = result.Value }, result.Value);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteNotification(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new DeleteNotificationCommand(id);

        var result = await _sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return Ok(result);
    }
}