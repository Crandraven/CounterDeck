using CounterDeck.Application.Authentication.Commands.Register;
using CounterDeck.Application.Authentication.Common;
using CounterDeck.Application.Authentication.Queries.Login;
using CounterDeck.Contracts.Authentication;
using Mapster;

namespace CounterDeck.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}
