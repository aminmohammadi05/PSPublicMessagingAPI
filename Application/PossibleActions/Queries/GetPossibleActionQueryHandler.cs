using Dapper;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Application.PossibleActions.Queries;

internal sealed class GetPossibleActionQueryHandler : IQueryHandler<GetPossibleActionQuery, IReadOnlyList<GetPossibleActionResponse>>
{


    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public GetPossibleActionQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<IReadOnlyList<GetPossibleActionResponse>>> Handle(GetPossibleActionQuery request, CancellationToken cancellationToken)
    {


        using var connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
                           SELECT
                               *
                           FROM PossibleAction
                           
                           """;

        var apartments = await connection
            .QueryAsync<GetPossibleActionResponse>(
                sql
               );

        return apartments.ToList();
    }
}