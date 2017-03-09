using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netcorelive.Controllers.WheatherForecast
{
    [Route("api/[controller]")]
    public partial class SampleDataController : Controller
    {
        private readonly IDataService _dataService;

        public SampleDataController(IDataService dataService){
            _dataService = dataService;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts(int startDateIndex)
        {
            return _dataService.GetWeatherForecasts(startDateIndex);
        }
    }
}
