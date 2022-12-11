using CounterDeck.Domain.Entities;

namespace CounterDeck.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
