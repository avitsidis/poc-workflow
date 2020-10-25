using System.Collections.Generic;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hosting.Controllers
{
	[ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
		private readonly IWeatherForecastService service;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
        {
            _logger = logger;
			this.service = service;
		}

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return service.Get();
        }
    }
}
