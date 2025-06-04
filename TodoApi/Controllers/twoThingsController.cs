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


    [HttpGet("{p1}/{p2}")]
    public IEnumerable<int> Get(int p1, int p2)
    {
        // tarkista löytyykö annetut p1 ja p2 levylle kirjoitetusta tiedostosta.

        return Enumerable.Range(p1, p2).ToArray();
    }

    [HttpPost("{p1}/{p2}")]
    public IEnumerable<int> Post(int p1, int p2)
    {
        // kirjoita annetut arvot tiedostoon levylle.
        // katso esim.file.writeAllLines.
        // C# file.writeAllLines example (Googlaa tämä)

        return Enumerable.Range(p1, p2).ToArray();
    }
}
