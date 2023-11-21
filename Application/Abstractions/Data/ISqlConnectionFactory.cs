using System.Data;

namespace PSPublicMessagingAPI.Application.Abstractions.Data;

public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}