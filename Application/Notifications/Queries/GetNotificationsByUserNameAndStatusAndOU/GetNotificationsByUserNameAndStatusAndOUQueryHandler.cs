using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserNameAndStatus;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserNameAndStatusAndOUQuery;

public class GetNotificationsByUserNameAndStatusAndOUQueryHandler : IQueryHandler<GetNotificationsByUserNameAndStatusAndOUQuery, List<NotificationResponse>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetNotificationsByUserNameAndStatusAndOUQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<List<NotificationResponse>>> Handle(GetNotificationsByUserNameAndStatusAndOUQuery request, CancellationToken cancellationToken)
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
                           WHERE (targetClientUserName = @username AND
                           [NotificationStatus] = @status AND
                           [TargetGroup] = @OU) OR [TargetGroup] = 'ALL'
                           """;

        var notification = await connection.QueryAsync<NotificationResponse>(
            sql,

            new
            {
                request.username,
                request.status,
                request.OU
            });

        return notification.ToList();
    }
}