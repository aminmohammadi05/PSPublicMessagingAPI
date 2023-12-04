using MediatR;
using Microsoft.AspNetCore.Mvc;
using PSPublicMessagingAPI.Application.ClientActions.Queries;
using PSPublicMessagingAPI.Application.UserRoles.Queries;

namespace PSPublicMessagingWebAPI.Controllers.UserRoles;

[ApiController]
[Route("api/user-roles")]
public class UserRoleController : ControllerBase
{
    private readonly ISender _sender;

    public UserRoleController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("{username}")]
    public async Task<IActionResult> GetUserRoles(string username,
        CancellationToken cancellationToken)
    {
        var query = new GetUserRolesQuery(username);

        var result = await _sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }
}