using AutoMapper;
using RaindropApi.Controllers;

namespace RaindropApi.Model.Tanks {
	public class TankProfileMap : Profile {
		public TankProfileMap() {
			CreateMap<TankStatusPut, TankStatus>();
		}
	}
}