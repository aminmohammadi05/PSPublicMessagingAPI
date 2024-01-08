using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserNameAndStatus;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByOUQuery;

public class GetNotificationsByOUQueryHandler : IQueryHandler<GetNotificationsByOUQuery, List<NotificationResponse>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetNotificationsByOUQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<List<NotificationResponse>>> Handle(GetNotificationsByOUQuery request, CancellationToken cancellationToken)
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
                           WHERE
                           [TargetGroup] = @OU 
                           """;

        var notification = await connection.QueryAsync<NotificationResponse>(
            sql,

            new
            {
                request.OU
            });

        return notification.ToList();
    }
}