using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using AutoMapper;
using RaindropApi.Controllers;

namespace RaindropApi.Model.Tanks {
	public class TankProfileMap : Profile {
		public TankProfileMap() {
			CreateMap<TankStatusPut, TankStatus>();
			CreateMap<TankStatusDto, TankStatus>();
			CreateMap<TankStatus, TankStatusDto>()
				.ForMember(a => a.TotalCollectedAmount,
					builder =>
						builder.MapFrom(a => a.History
						                      .GroupBy(x => x.UpdatedAt.Date)
						                      .Select(x =>
							                      x.Last().CurrentVolume - x.First().CurrentVolume)
						                      .Sum()))
				.ForMember(a => a.History, c =>
					c.MapFrom(a => GetHistory(a)));
		}

		private IEnumerable<TankHistoryDay> GetHistory(TankStatus statusList) {
			var grouped = statusList.History
			                        .GroupBy(x => x.UpdatedAt.Date);

			var history = new List<TankHistoryDay>();
			var previous = 0m;
			foreach (var g in grouped) {
				var amounts = g.Select(a => a.CurrentVolume).ToList();
				var tankHistoryDay = new TankHistoryDay() {
					Date = g.Key,
					AmountCollected = CalculateCollected(amounts, previous),
					AmountConsumption = CalculateConsumption(amounts, previous),
				};
				history.Add(tankHistoryDay);
				previous = amounts.Last();
			}
			return history;
		}

		private decimal CalculateCollected(IEnumerable<decimal> decimals, decimal previous) {
			decimal total = 0;
			foreach (var current in decimals) {
				if (current > previous) {
					total += current - previous;
				}

				previous = current;
			}

			return total;
		}

		private decimal CalculateConsumption(IEnumerable<decimal> decimals, decimal previous) {
			decimal total = 0;
			foreach (var current in decimals) {
				if (current < previous) {
					total += previous - current;
				}

				previous = current;
			}

			return total;
		}
	}
}