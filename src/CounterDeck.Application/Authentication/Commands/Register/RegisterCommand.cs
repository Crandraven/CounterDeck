using CounterDeck.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace CounterDeck.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string UserName,
    string Email,
    string Password
) : IRequest<ErrorOr<AuthenticationResult>>;
