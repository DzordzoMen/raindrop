using System;

namespace RaindropApi.Model.Tanks {
	public class TankHistory {
		public int TankId { get; set; }
		public DateTime UpdatedAt { get; set; }
		public decimal CurrentVolume { get; set; }
	}
}