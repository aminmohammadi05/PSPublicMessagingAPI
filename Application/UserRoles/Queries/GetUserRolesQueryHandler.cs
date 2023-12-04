using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.ClientActions.Queries;
using PSPublicMessagingAPI.Application.Notifications.Queries.GetNotificationById;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.UserRoles.Queries;

internal sealed class GetUserRolesQueryHandler : IQueryHandler<GetUserRolesQuery, UserRoleResponse>
{


    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetUserRolesQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<UserRoleResponse>> Handle(GetUserRolesQuery request, CancellationToken cancellationToken)
    {


        using var connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                               *
                           FROM UserRole
                           WHERE userName = @username
                           """;

        var userRole = await connection
            .QueryFirstOrDefaultAsync<UserRoleResponse>(
                sql,
                new
                {
                    request.username
                }
            );

        return userRole;
    }
}