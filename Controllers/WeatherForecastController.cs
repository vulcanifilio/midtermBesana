using Microsoft.AspNetCore.Mvc;


namespace midtermBesana.Controllers;

[ApiController]
[Route("[controller]")]
public class testController : ControllerBase
{
    private readonly ILogger<testController> _logger;

    public testController(ILogger<testController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetCosine")]
    public IEnumerable<Cosine> GetCosine()
    {
        return Enumerable.Range(0, 1).Select(index => new Cosine
        {
            degree = 60
        })
        .ToArray();
    }[HttpGet("GetSine")]
    public IEnumerable<Sine> GetSine()
    {
        return Enumerable.Range(0, 1).Select(index => new Sine
        {
            degree = 30
        })
        .ToArray();
    }

    public IEnumerable<Tangent> GetTangent()
    {
        return Enumerable.Range(0, 1).Select(index => new Tangent
        {
            degree = 90
        })
        .ToArray();
    }

}