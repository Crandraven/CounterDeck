namespace CounterDeck.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string UserName,
    string Email,
    string Token
);
