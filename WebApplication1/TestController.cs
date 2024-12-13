using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

public class TestController : Controller
{
    [Authorize]
    public IActionResult Authed()
    {
        return Ok();
    }

    public IActionResult NotAuthed()
    {
        return Ok();
    }
}