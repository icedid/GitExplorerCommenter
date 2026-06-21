using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("auth")]
public class ReposController : ControllerBase
{
    public record LoadRepoRequest(string Owner, string RepoName);

    [HttpGet("{id}/commits")]
    public IActionResult GetCommits(int id)
    {
        return Ok();
    }
    [HttpPost("load")]
    public async Task<IActionResult> LoadRepo([FromBody] LoadRepoRequest request)
    {
        return Ok();
    }
}