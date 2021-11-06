using System.Collections.Generic;

namespace RaindropApi.Model.Weather {
	public class WeatherForecast {
		public List<WeatherDaily> Daily { get; set; }
	}

	public class WeatherDaily {
		/// <summary>
		/// Rain in mm
		/// </summary>
		public decimal Rain { get; set; }

		public List<WeatherCondition> Weather { get; set; }
	}
}