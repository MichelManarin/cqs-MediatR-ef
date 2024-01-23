using GrantTest.Domain.Commands.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GrantTest.Controlers {

  [ApiController]
  [Route("v1/authentication")]
  public class AuthenticationController: ControllerBase {
    [HttpPost]
    [Route("")]
    public async Task<IActionResult> Authenticate(
      [FromServices]IMediator mediator,
      [FromBody]AuthenticationRequest command
    ) {
      try {
        var result = await mediator.Send(command);
        return Ok(result);
      } 
      catch (ArgumentException ex)
      {
        return BadRequest(new { error = ex.Message });
      }
    }
  }

}