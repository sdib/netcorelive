using System;
using System.Collections.Generic;
using System.Linq;

namespace netcorelive.Controllers.WheatherForecast
{
    public class MockDataService : IDataService
    {

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        IEnumerable<WeatherForecast> IDataService.GetWeatherForecasts(int startDateIndex)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToString("d"),
                TemperatureC = 20,
                Summary = Summaries[6]
            });
        }
    }

}