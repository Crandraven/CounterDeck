namespace CounterDeck.Contracts.Authentication;

public record LoginRequest(
    string UserName,
    string Password
);
