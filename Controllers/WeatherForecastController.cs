using Microsoft.AspNetCore.Mvc;

namespace midtermBesana.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecasters> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecasters
        {
            Numb = Random.Shared.Next(1, 24),
        })
        .ToArray();
    }
}

public class SineFunctionController : ControllerBase
{
    private readonly ILogger<SineFunctionController> _logger;

    public SineFunctionController(ILogger<SineFunctionController> logger)
    {
        _logger = logger;
    }
[HttpGet(Name = "GetSineFunction")]
    public IEnumerable<SineFunctions> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new SineFunctions
        {
            Numbe = Random.Shared.Next(1, 24),
        })
        .ToArray();
    }
}