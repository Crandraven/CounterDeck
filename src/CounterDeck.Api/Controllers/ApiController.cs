using CounterDeck.Api.Common.http;
using ErrorOr;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CounterDeck.Api.Controllers;

[ApiController]
[Authorize]
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
        if (errors.Count is 0)
        {
            return Problem();
        }
        if (errors.All(error => error.Type == ErrorType.Validation))
        {
            return ValidationProblem(errors);
        }

        HttpContext.Items[HttpContextItemKeys.Errors] = errors;

        return Problem(errors[0]);
    }

    private IActionResult Problem(Error error)
    {
        var statusCode = error.Type switch
        {
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };

        return Problem(statusCode: statusCode, title: error.Description);
    }

    private IActionResult ValidationProblem(List<Error> errors)
    {
        var modelStateDictionnary = new ModelStateDictionary();

        foreach (var error in errors)
        {
            modelStateDictionnary.AddModelError(error.Code, error.Description);
        }
        return ValidationProblem(modelStateDictionnary);
    }
}
