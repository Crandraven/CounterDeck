using System.Net;

namespace CounterDeck.Domain.Exceptions.Interfaces;

public interface IException
{
    public HttpStatusCode StatusCode { get; }

    public string ErrorMessage { get; }
}
