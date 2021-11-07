using System.Collections.Generic;

namespace RaindropApi.Model.Weather {
	public class OpenWeatherForecast {
		public List<OpenWeatherDaily> Daily { get; set; }
	}
}