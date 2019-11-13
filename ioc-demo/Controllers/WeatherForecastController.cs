using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IocDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IocDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDateProvider _dateProvider;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDateProvider dateProvider)
        {
            try
            {
                _logger = logger;
                _dateProvider = dateProvider ?? throw new ArgumentNullException(nameof(dateProvider), "This will never throw");
            }
            catch (Exception ex)
            {
                Debug.Fail(ex.ToString());
            }
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
