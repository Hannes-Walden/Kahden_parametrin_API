using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("api")]
public class twoThingsController : ControllerBase
{

    [HttpGet(Name = "Kahden_parametrin_API")]
    public IEnumerable<int> Get()
    {
        return Enumerable.Range(1, 5).ToArray();
    }
}
