using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

[ApiController]
[Route("comments")]

public class CommentsController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetComments()
    {
        return Ok();
    }
    [HttpPost]
    public IActionResult PostComment()
    {
        return StatusCode(201);
    }
}