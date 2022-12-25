using Microsoft.AspNetCore.Mvc;

namespace CounterDeck.Api.Controllers;

[Route("[controller]")]
public class DecksController : ApiController
{
    [HttpGet]
    public IActionResult ListDecks()
    {
        return Ok(Array.Empty<string>());
    }
}
