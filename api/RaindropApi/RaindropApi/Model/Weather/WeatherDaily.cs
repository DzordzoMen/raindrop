using System.Collections.Generic;

namespace RaindropApi.Model.Weather {
	public class WeatherDaily {
		/// <summary>
		/// Rain in mm
		/// </summary>
		public decimal Rain { get; set; }

		public decimal DayTemperature { get; set; }

		public List<WeatherCondition> Weather { get; set; }
	}
}