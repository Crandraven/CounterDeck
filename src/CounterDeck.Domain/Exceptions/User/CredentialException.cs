using System.Net;
using CounterDeck.Domain.Exceptions.Interfaces;

namespace CounterDeck.Domain.Exceptions.User;

public class WrongCredentialsException : Exception, IException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Unauthorized;

    public string ErrorMessage => "Incorrect username and/or password";
}
