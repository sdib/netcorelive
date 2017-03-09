using System;
using System.Collections.Generic;
using System.Linq;

namespace netcorelive.Controllers.WheatherForecast
{
    public class RealDataService : IDataService
    {
         private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

       public IEnumerable<WeatherForecast> GetWeatherForecasts(int startDateIndex)
        {
             var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

    }

}