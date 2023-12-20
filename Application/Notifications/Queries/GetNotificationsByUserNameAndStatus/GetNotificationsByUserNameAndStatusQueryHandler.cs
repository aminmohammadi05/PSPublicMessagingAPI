﻿using Dapper;
using Newtonsoft.Json;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserNameAndStatus;

public sealed class GetNotificationsByUserNameAndStatusQueryHandler : IQueryHandler<GetNotificationsByUserNameAndStatusQuery, List<NotificationResponse>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetNotificationsByUserNameAndStatusQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<List<NotificationResponse>>> Handle(GetNotificationsByUserNameAndStatusQuery request, CancellationToken cancellationToken)
    {
        using var connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                            [Id]
                           ,[NotificationTitle]
                           ,[NotificationText]
                           ,[PossibleActionId]
                           ,[ClientUserName]
                           ,[ClientGroup]
                           ,[TargetClientUserName]
                           ,[TargetClientGroup]
                           ,[TargetGroup]
                           ,[ClientFullName]
                           ,[TargetClientFullName]
                           ,[NotificationStatus]
                           ,[NotificationPriority]
                           ,[NotificationDate]
                           ,[MethodParameter_Parameter] as MethodParameter
                           ,[LastModifierUser]
                           FROM Notification
                           WHERE targetClientUserName = @username AND
                           [NotificationStatus] = @status
                           """;

        var notification = await connection.QueryAsync<NotificationResponse>(
            sql,
            
            new
            {
                request.username,
                request.status
            });

        return notification.ToList();
    }
}