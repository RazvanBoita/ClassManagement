using ClassManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagement.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }
    
    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return _weatherService.GetForecast();
    }    
}

public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
