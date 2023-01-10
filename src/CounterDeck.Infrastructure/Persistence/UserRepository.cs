using CounterDeck.Application.Common.Interfaces.Persistence;
using CounterDeck.Domain.Entities;

namespace CounterDeck.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();

    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByUserName(string userName)
    {
        return _users.SingleOrDefault(u => u.UserName == userName);
    }
}
