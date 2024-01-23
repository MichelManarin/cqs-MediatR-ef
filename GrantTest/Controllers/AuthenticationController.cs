using GrantTest.Domain.Commands.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace GrantTest.Controlers {

  [ApiController]
  [Route("v1/authentication")]
  [AllowAnonymous]
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