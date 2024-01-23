using GrantTest.Data.Repositories;
using GrantTest.Domain.Commands.Requests;
using GrantTest.Domain.Commands.Responses;
using GrantTest.Models;
using GrantTest.Service;
using MediatR;

namespace GrantTest.Domain.Commands.Handlers
{
  public class AuthenticationHandler : IRequestHandler<AuthenticationRequest, AuthenticationResponse>
    {          
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public AuthenticationHandler(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public Task<AuthenticationResponse> Handle(AuthenticationRequest request, CancellationToken cancellationToken)
        {
            User? userRequest = _userRepository.GetByLoginAndPassword(request.Login, request.Password) ?? throw new ArgumentException("Invalid credential");
            var result = new AuthenticationResponse
            {
                Token = _tokenService.GenerateToken(),
                Name = userRequest.Name
            };

            return Task.FromResult(result);
        }
    }

}