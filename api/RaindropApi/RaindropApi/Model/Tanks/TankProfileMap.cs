using System.Linq;
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
						                      .Sum()));
		}
	}
}