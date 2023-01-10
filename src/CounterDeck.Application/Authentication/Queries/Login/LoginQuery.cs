using CounterDeck.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace CounterDeck.Application.Authentication.Queries.Login;

public record LoginQuery(string UserName, string Password) : IRequest<ErrorOr<AuthenticationResult>>;
