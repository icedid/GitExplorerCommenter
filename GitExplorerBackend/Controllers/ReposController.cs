using Microsoft.AspNetCore.Mvc;

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