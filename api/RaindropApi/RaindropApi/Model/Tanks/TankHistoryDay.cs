using System;

namespace RaindropApi.Model.Tanks {
	public class TankHistoryDay {
		public decimal AmountCollected { get; set; }
		public decimal AmountConsumption { get; set; }
		public decimal Balance => AmountCollected - AmountConsumption;
		public DateTime Date { get; set; }
	}
}