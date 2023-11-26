using MediatR;
using Microsoft.AspNetCore.Mvc;
using PSPublicMessagingAPI.Application.ClientActions.Queries;
using PSPublicMessagingAPI.Application.UserRoles.Queries;

namespace PSPublicMessagingWbAPI.Controllers.UserRoles;

[ApiController]
[Route("api/userroles")]
public class UserRoleController : ControllerBase
{
    private readonly ISender _sender;

    public UserRoleController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> GetUserRoles(
        CancellationToken cancellationToken)
    {
        var query = new GetUserRolesQuery();

        var result = await _sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }
}