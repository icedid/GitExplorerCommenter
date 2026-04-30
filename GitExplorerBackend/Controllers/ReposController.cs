using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("auth")]
public class ReposController : ControllerBase
{
    [HttpGet("{id}/commits")]
    public IActionResult GetCommits(int id)
    {
        return Ok();
    }
}