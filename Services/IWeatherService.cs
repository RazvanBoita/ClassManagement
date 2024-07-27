using ClassManagement.Controllers;

namespace ClassManagement.Services;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetForecast();
}