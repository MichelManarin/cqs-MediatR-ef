using GrantTest.Domain.Commands.Responses;
using MediatR;

namespace GrantTest.Domain.Commands.Requests
{

  public class AuthenticationRequest: IRequest<AuthenticationResponse>
  {
    public required string Login { get; set; }

    public required string Password { get; set; }
  }
}