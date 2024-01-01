using MassTransit;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;
using PSPublicMessagingAPI.Application.Notifications.Commands.DeleteNotification;
using PSPublicMessagingAPI.Application.Notifications.Commands.UpdateNotification;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsAll;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByOUAndStatus;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByOUQuery;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserName;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserNameAndStatus;

namespace PSPublicMessagingWebAPI.Controllers.Notifications
{
    [ApiController]
    [Route("api/publicnotifications")]
    public class PublicNotificationController : ControllerBase
    {
        private readonly ISender _sender;


        public PublicNotificationController(ISender sender, IPublishEndpoint publishEndpoint)
        {
            _sender = sender;

        }
        [HttpGet("{OU}")]
        public async Task<IActionResult> GetNotificationsByOU(string OU, CancellationToken cancellationToken)
        {
            var query = new GetNotificationsByOUQuery(OU);

            var result = await _sender.Send(query, cancellationToken);

            return result.IsSuccess ? Ok(result.Value) : NotFound();
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
        

        [HttpGet("{OU}/{status:int}")]
        public async Task<IActionResult> GetNotificationsByOUAndStatus(string OU, int status, CancellationToken cancellationToken)
        {
            var query = new GetNotificationsByOUAndStatusQuery(OU, status);

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
}
