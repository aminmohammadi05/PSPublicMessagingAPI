//using Carter;
//using MassTransit;
//using MediatR;
//using Microsoft.AspNetCore.Http.HttpResults;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http;
//using PSPublicMessagingAPI.Application.ClientActions.Queries;
//using PSPublicMessagingAPI.Application.Notifications.Commands.CreateNotification;
//using PSPublicMessagingAPI.Application.Notifications.Commands.DeleteNotification;
//using PSPublicMessagingAPI.Application.Notifications.Commands.UpdateNotification;
//using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
//using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsAll;
//using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserName;
//using PSPublicMessagingAPI.Contract;
//using PSPublicMessagingAPI.Domain.Notifications;
//using PSPublicMessagingAPI.Domain.Abstractions;

//namespace PSPublicMessagingWebAPI.Controllers.Notifications;


//public class NotificationEndpoints : ICarterModule
//{
//    public void AddRoutes(IEndpointRouteBuilder app)
//    {
//        var group = app.MapGroup("api/notifications");
//        group.MapPost("", CreateNotification);
//        group.MapGet("", GetNotifications);
//        group.MapGet("{id}", GetNotification);
//        group.MapGet("{username}", GetNotificationsByUserName);
//        group.MapPut("", UpdateNotificationStatus);
//        group.MapDelete("{id}", DeleteNotification);
//    }

   
//    public static async Task<Results<Ok<List<NotificationResponse>>, NotFound<string>>> GetNotifications(ISender sender,
//        CancellationToken cancellationToken)
//    {
//        var query = new GetNotificationsAllQuery();

//        var result = await sender.Send(query, cancellationToken);

//        return result.IsSuccess ? TypedResults.Ok(result.Value) : TypedResults.NotFound("");
//    }
   
//    public async Task<Results<Ok<NotificationResponse>, NotFound<string>>> GetNotification(ISender sender, Guid id, CancellationToken cancellationToken)
//    {
//        var query = new GetNotificationByIdQuery(id);

//        var result = await sender.Send(query, cancellationToken);

//        return result.IsSuccess ? TypedResults.Ok(result.Value) : TypedResults.NotFound("");
//    }
   
//    public async Task<Results<Ok<List<NotificationResponse>>, NotFound<string>>> GetNotificationsByUserName(ISender sender, string username, CancellationToken cancellationToken)
//    {
//        var query = new GetNotificationsByUserNameQuery(username);

//        var result = await sender.Send(query, cancellationToken);

//        return result.IsSuccess ? TypedResults.Ok(result.Value) : TypedResults.NotFound("");
//    }


   
//    public async Task<Results<Ok<Guid>, BadRequest<string>>> CreateNotification(
//        CreateNotificationRequest request,
//        ISender sender,
//        CancellationToken cancellationToken)
//    {
//        var command = new CreateNotificationCommand(
//            request.possibleActionId,
//             request.notificationTitle,
//             request.notificationText,
//             request.clientUserName,
//             request.clientGroup,
//             request.targetClientUserName,
//             request.targetClientGroup,
//             request.targetGroup,
//             request.clientFullName,
//             request.targetClientFullName,
//             request.notificationStatus,
//             request.notificationPriority,
//             request.methodParameter,
//             request.lastModifiedUser);

//        var result = await sender.Send(command, cancellationToken);

//        if (result.IsFailure)
//        {
//            return TypedResults.BadRequest(result.Error.Name);
//        }
        
//        return TypedResults.Ok(result.Value);
//    }

    
//    public async Task<Results<Ok<Guid>, BadRequest<string>>> UpdateNotificationStatus(ISender sender,
//        UpdateNotificationRequest request,
//        CancellationToken cancellationToken)
//    {
//        var command = new UpdateNotificationCommand(
//            request.Id, 
//            request.possibleActionId,
//            request.notificationTitle,
//            request.notificationText,
//            request.clientUserName,
//            request.clientGroup,
//            request.targetClientUserName,
//            request.targetClientGroup,
//            request.targetGroup,
//            request.clientFullName,
//            request.targetClientFullName,
//            request.notificationStatus,
//            request.notificationPriority,
//            request.methodParameter,
//            request.lastModifiedUser);

//        var result = await sender.Send(command, cancellationToken);

//        if (result.IsFailure)
//        {
//            return TypedResults.BadRequest(result.Error.Name);
//        }

//    return TypedResults.Ok(result.Value);
//}

   
//    public async Task<Results<Ok<Guid>, BadRequest<string>>> DeleteNotification(ISender sender,
//        Guid id,
//        CancellationToken cancellationToken)
//    {
//        var command = new DeleteNotificationCommand(id);

//        var result = await sender.Send(command, cancellationToken);

//    if (result.IsFailure)
//    {
//        return TypedResults.BadRequest(result.Error.Name);
//    }

//    return TypedResults.Ok(result.Value);
//}

    
//}