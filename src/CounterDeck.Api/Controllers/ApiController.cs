using CounterDeck.Api.Common.http;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace CounterDeck.Api.Controllers;

[ApiController]
public class ApiController : ControllerBase
{
    protected IActionResult Problem(Error error, int statusCode)
    {
        var errors = new List<Error>();
        errors.Add(error);

        HttpContext.Items[HttpContextItemKeys.Errors] = errors;
        return Problem(statusCode: statusCode, title: error.Description);
    }
    protected IActionResult Problem(List<Error> errors)
    {
        HttpContext.Items[HttpContextItemKeys.Errors] = errors;
        var firstError = errors[0];

        var statusCode = firstError.Type switch
        {
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };

        return Problem(statusCode: statusCode, title: firstError.Description);
    }
}
