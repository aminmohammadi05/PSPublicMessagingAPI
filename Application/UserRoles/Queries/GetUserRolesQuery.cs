using PSPublicMessagingAPI.Application.Abstractions.Messaging;
using PSPublicMessagingAPI.Application.ClientActions.Queries;

namespace PSPublicMessagingAPI.Application.UserRoles.Queries;

public sealed record GetUserRolesQuery(string username) : IQuery<UserRoleResponse>;