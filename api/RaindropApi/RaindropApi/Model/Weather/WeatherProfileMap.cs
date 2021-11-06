using AutoMapper;

namespace RaindropApi.Model.Weather {
	public class WeatherProfileMap : Profile {
		public WeatherProfileMap() {
			CreateMap<OpenWeatherForecast, WeatherForecast>();
			CreateMap<OpenWeatherDaily, WeatherDaily>();
			CreateMap<OpenWeatherCondition, WeatherCondition>();
		}
	}
}