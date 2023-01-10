using CounterDeck.Domain.Entities;

namespace CounterDeck.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByUserName(string userName);
    void Add(User user);
}
