using CounterDeck.Application.Authentication.Common;
using CounterDeck.Application.Common.Interfaces.Authentication;
using CounterDeck.Application.Common.Interfaces.Persistence;
using CounterDeck.Domain.Entities;
using CounterDeck.Domain.Exceptions.User;
using MediatR;

namespace CounterDeck.Application.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, AuthenticationResult>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    public async Task<AuthenticationResult> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        if (_userRepository.GetUserByEmail(query.Email) is not User user
            || user.Password != query.Password)
        {
            throw new WrongCredentialsException();
        }

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}
