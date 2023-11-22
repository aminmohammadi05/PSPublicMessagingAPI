using PSPublicMessagingAPI.Application.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Notifications.Queries.GetNotificationById;
using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
public sealed class GetNotificationByIdQueryHandler : IQueryHandler<GetNotificationByIdQuery, NotificationResponse>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetNotificationByIdQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<NotificationResponse>> Handle(GetNotificationByIdQuery request, CancellationToken cancellationToken)
    {
        using var connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                               *
                           FROM Notification
                           WHERE id = @notificationId
                           """;

        var notification = await connection.QueryFirstOrDefaultAsync<NotificationResponse>(
            sql,
            new
            {
                request.notificationId
            });

        return notification;
    }
}
