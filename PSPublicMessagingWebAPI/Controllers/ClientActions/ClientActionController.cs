
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PSPublicMessagingAPI.Application.ClientActions.Queries;

namespace PSPublicMessagingWebAPI.Controllers.ClientActions;

[ApiController]
[Route("api/clientactions")]
public class ClientActionController : ControllerBase
{
    private readonly ISender _sender;

    public ClientActionController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> GetClientActions(
        CancellationToken cancellationToken)
    {
        var query = new GetClientActionQuery();

        var result = await _sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }
}