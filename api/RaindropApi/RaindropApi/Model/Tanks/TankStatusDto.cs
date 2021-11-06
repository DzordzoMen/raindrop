using System;
using System.Collections.Generic;

namespace RaindropApi.Model.Tanks {
	public class TankStatusDto {
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal CurrentAmount { get; set; }
		public decimal MaxAmount { get; set; }
		public DateTime UpdatedAt { get; set; }
		public decimal TotalCollectedAmount { get; set; }
	}
}