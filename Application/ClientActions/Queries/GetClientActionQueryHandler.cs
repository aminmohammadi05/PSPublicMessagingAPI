using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.ClientActions.Queries;

internal sealed class GetClientActionQueryHandler : IQueryHandler<GetClientActionQuery, IReadOnlyList<ClientActionResponse>>
{


    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetClientActionQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<IReadOnlyList<ClientActionResponse>>> Handle(GetClientActionQuery request, CancellationToken cancellationToken)
    {


        using var connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                               *
                           FROM ClientAction
                           
                           """;

        var apartments = await connection
            .QueryAsync<ClientActionResponse>(
                sql
               );

        return apartments.ToList();
    }
}