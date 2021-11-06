using AutoMapper;

namespace RaindropApi.Model.Weather {
	public class WeatherProfileMap : Profile {
		public WeatherProfileMap() {
			CreateMap<OpenWeatherForecast, WeatherForecast>();
			CreateMap<OpenWeatherDaily, WeatherDaily>()
				.ForMember(a => a.DayTemperature, 
					c => 
						c.MapFrom(a => a.Temp.Day));
			CreateMap<OpenWeatherCondition, WeatherCondition>();
		}
	}
}