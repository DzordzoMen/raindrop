using System;
using System.Collections.Generic;
using RaindropApi.Controllers;

namespace RaindropApi.Model.Tanks {
	public static class TanksStore {
		static TanksStore() {
			TankStatusList = new List<TankStatus>() {
				new() {
					Id = 1,
					Name = "Zbiornik w ogrodzie",
					CurrentAmount = 2077.12m,
					MaxAmount = 10_000,
					UpdatedAt = DateTime.Now.Subtract(TimeSpan.FromMinutes(1)),
					History = TankDataGenerator.Generate(1),
				}
			};
		}

		public static List<TankStatus> TankStatusList { get; }
	}
}