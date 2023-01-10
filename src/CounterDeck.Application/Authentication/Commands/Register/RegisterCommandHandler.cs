using CounterDeck.Application.Authentication.Common;
using CounterDeck.Application.Common.Interfaces.Authentication;
using CounterDeck.Application.Common.Interfaces.Persistence;
using CounterDeck.Domain.Common.Errors;
using CounterDeck.Domain.Entities;
using ErrorOr;
using MediatR;

namespace CounterDeck.Application.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        if (_userRepository.GetUserByUserName(command.UserName) is not null)
        {
            return Errors.User.DuplicateUserName;
        }

        var user = new User
        {
            UserName = command.UserName,
            Email = command.Email,
            Password = command.Password
        };

        _userRepository.Add(user);

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}
