using MediatR;
using Microsoft.AspNetCore.Mvc;
using PSPublicMessagingAPI.Application.ClientActions.Queries;
using PSPublicMessagingAPI.Application.PossibleActions.Queries;

namespace PSPublicMessagingWebAPI.Controllers.PossibleActions;

[ApiController]
[Route("api/possibleactions")]
public class PossibleActionController : ControllerBase
{
    private readonly ISender _sender;

    public PossibleActionController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> GetPossibleActions(
        CancellationToken cancellationToken)
    {
        var query = new GetPossibleActionQuery();

        var result = await _sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }
}