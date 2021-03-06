using System;
using System.Collections.Generic;
using Bogus;

namespace RaindropApi.Model.Tanks {
	public class TankDataGenerator {
		public static IEnumerable<TankHistory> Generate(int tankId, int count = 60 * 24 * 7) {
			var faker = new Faker();
			var list = new List<TankHistory>() {
				new TankHistory() {
					TankId = tankId,
					CurrentVolume = 0,
					UpdatedAt = DateTime.Today.AddDays(-7)
				}
			};

			for (int i = 1; i < count; i++) {
				var previous = list[i - 1];
				var tankHistory = new TankHistory() {
					TankId = tankId,
					CurrentVolume = previous.CurrentVolume - faker.Random.Decimal(-2m, 1),
					UpdatedAt = previous.UpdatedAt.AddMinutes(1)
				};
				list.Add(tankHistory);
			}

			return list;
		}
	}
}