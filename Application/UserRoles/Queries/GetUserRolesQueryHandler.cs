using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.ClientActions.Queries;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.UserRoles.Queries;

internal sealed class GetUserRolesQueryHandler : IQueryHandler<GetUserRolesQuery, IReadOnlyList<UserRoleResponse>>
{


    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetUserRolesQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<IReadOnlyList<UserRoleResponse>>> Handle(GetUserRolesQuery request, CancellationToken cancellationToken)
    {


        using var connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                               *
                           FROM UserRole

                           """;

        var apartments = await connection
            .QueryAsync<UserRoleResponse>(
                sql
            );

        return apartments.ToList();
    }
}