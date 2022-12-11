using CounterDeck.Application.Authentication.Commands.Register;
using CounterDeck.Application.Authentication.Common;
using CounterDeck.Application.Authentication.Queries.Login;
using CounterDeck.Contracts.Authentication;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CounterDeck.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public AuthenticationController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = _mapper.Map<RegisterCommand>(request);
        AuthenticationResult authResult = await _mediator.Send(command);

        var response = _mapper.Map<AuthenticationResponse>(authResult);

        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = _mapper.Map<LoginQuery>(request);
        AuthenticationResult authResult = await _mediator.Send(query);

        var response = _mapper.Map<AuthenticationResponse>(authResult);

        return Ok(response);
    }
}
