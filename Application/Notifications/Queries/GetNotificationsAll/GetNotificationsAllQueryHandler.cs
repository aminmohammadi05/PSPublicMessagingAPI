using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationsAll;

public class GetNotificationsAllQueryHandler : IQueryHandler<GetNotificationsAllQuery, List<NotificationResponse>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetNotificationsAllQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<List<NotificationResponse>>> Handle(GetNotificationsAllQuery request, CancellationToken cancellationToken)
    {
        using var connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                               *
                           FROM Notification
                           """;

        var notification = await connection.QueryAsync<NotificationResponse>(
            sql);

        return notification.ToList();
    }
}