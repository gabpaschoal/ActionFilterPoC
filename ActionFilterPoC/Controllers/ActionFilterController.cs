using Microsoft.AspNetCore.Mvc;

namespace ActionFilterPoC.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActionFilterController : ControllerBase
{
    // GET: api/<ActionFilterController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }
}