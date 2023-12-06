using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.ClientActions.Queries.ClientActionByUsername;

public class GetClientActionsByUsernameQueryHandler : IQueryHandler<GetClientActionsByUsernameQuery, List<ClientActionResponse>>
{
    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetClientActionsByUsernameQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<List<ClientActionResponse>>> Handle(GetClientActionsByUsernameQuery request, CancellationToken cancellationToken)
    {
        using var connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                               *
                           FROM ClientAction
                           WHERE ClientUserName = @username
                           """;

        var clientActions = await connection.QueryAsync<ClientActionResponse>(
            sql,
            new
            {
                request.username
            });

        return clientActions.ToList();
    }
}