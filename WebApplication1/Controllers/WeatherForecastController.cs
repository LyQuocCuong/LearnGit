using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool"
        ];


        const string Nick = "Nick Editted (commit_3)";


        const string Favorite = "Commit 1";

        const string Title = "Weather Forecast API";
        const string Nick = "Nick";


        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            Console.WriteLine("Commit 1: GetWeatherForecast method called.");
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
