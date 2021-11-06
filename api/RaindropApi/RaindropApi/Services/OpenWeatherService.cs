using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using RaindropApi.Model.Weather;
using RestSharp;

namespace RaindropApi.Services {
	public class OpenWeatherService {
		private readonly IConfiguration _configuration;
		private readonly IMapper _mapper;

		public OpenWeatherService(IConfiguration configuration, IMapper mapper) {
			_configuration = configuration;
			_mapper = mapper;
		}
		public async Task<IEnumerable<WeatherDaily>> GetForecast(decimal latitude, decimal longitude) {
			var httpClient = new RestClient("https://api.openweathermap.org/data/2.5/");
			var restRequest = new RestRequest("onecall");
			restRequest.AddQueryParameter("appid", _configuration["openWeatherApi"]);
			restRequest.AddQueryParameter("lat", latitude.ToString(CultureInfo.InvariantCulture));
			restRequest.AddQueryParameter("lon", longitude.ToString(CultureInfo.InvariantCulture));
			restRequest.AddQueryParameter("units", "metric");
			restRequest.AddQueryParameter("exclude", "current,minutely,hourly,alerts");
			var response = await httpClient.ExecuteGetAsync<OpenWeatherForecast>(restRequest);
			return _mapper.Map<List<WeatherDaily>>(response.Data.Daily);
		}
	}
}