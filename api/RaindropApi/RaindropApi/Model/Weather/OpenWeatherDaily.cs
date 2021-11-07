using System.Collections.Generic;

namespace RaindropApi.Model.Weather {
	public class OpenWeatherDaily {
		/// <summary>
		/// Rain in mm
		/// </summary>
		public decimal Rain { get; set; }
		
		public decimal DayTemperature { get; set; }
		
		public OpenWeatherTemperature Temp { get; set; }

		public List<OpenWeatherCondition> Weather { get; set; }
	}
}