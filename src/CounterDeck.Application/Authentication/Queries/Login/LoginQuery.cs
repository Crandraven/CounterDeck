using CounterDeck.Application.Authentication.Common;
using MediatR;

namespace CounterDeck.Application.Authentication.Queries.Login;

public record LoginQuery(string Email, string Password) : IRequest<AuthenticationResult>;
