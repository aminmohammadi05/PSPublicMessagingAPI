using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsByUserName;

public sealed class GetNotificationsByUserNameQueryHandler : IQueryHandler<GetNotificationsByUserNameQuery, NotificationResponse>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetNotificationsByUserNameQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<NotificationResponse>> Handle(GetNotificationsByUserNameQuery request, CancellationToken cancellationToken)
    {
        using var connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                               *
                           FROM Notification
                           WHERE targetClientUserName = @username
                           """;

        var notification = await connection.QueryFirstOrDefaultAsync<NotificationResponse>(
            sql,
            new
            {
                request.username
            });

        return notification;
    }
}