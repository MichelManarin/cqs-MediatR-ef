using GrantTest.Domain.Commands.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace GrantTest.Controlers {

  [ApiController]
  [Route("v1/product")]
  public class ProductController: ControllerBase {
    [HttpGet]
    [Route("")] 
    [Authorize]
    public async Task<IActionResult> GetProducts(
      [FromServices]IMediator mediator
    ) {
      try {
        var result = await mediator.Send(new ProductRequest());
        return Ok(result);
      } 
      catch (ArgumentException ex)
      {
        return BadRequest(new { error = ex.Message });
      }
    }
  }

}