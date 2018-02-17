using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netdbdemo.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<Models.WeatherForecast> WeatherForecasts()
        {

            return Enumerable.Range(1, 5).Select(index =>
            {
                var forecast = Models.WeatherForecast.NewRandom();
                forecast.DateFormatted = DateTime.Now.AddDays(index).ToString("d");
                
                return forecast;
            });
        }
    }
}
