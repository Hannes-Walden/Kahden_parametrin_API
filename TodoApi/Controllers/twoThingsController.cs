using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("api")]
public class twoThingsController : ControllerBase
{

    [HttpGet(Name = "Kahden_parametrin_API")]
    public IEnumerable<int> Get()
    {
        return Enumerable.Range(1, 5000).ToArray();
    }

    public IEnumerable<int> Get(int p1, int p2)
    {
        return Enumerable.Range(p1, p2).ToArray();
    }
}
