using System.Net;
using CounterDeck.Domain.Exceptions.Interfaces;

namespace CounterDeck.Domain.Exceptions.User;

public class DuplicateEmailException : Exception, IException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;
    public string ErrorMessage => "Email already exist";
}
