using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaindropApi.Model.Weather;
using RaindropApi.Services;

namespace RaindropApi.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase {
		private readonly OpenWeatherService _weatherService;

		public WeatherForecastController(OpenWeatherService weatherService) {
			_weatherService = weatherService;
		}

		[HttpGet]
		public async Task<IEnumerable<WeatherDaily>> Get() {
			return await _weatherService.GetForecast(50.049683m,19.944544m);
		}
	}
}