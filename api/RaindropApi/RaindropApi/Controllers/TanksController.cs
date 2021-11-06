using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RaindropApi.Model.Tanks;

namespace RaindropApi.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class TanksController : ControllerBase {
		private readonly IMapper _mapper;

		public TanksController(IMapper mapper) {
			_mapper = mapper;
		}
		[HttpGet("id")]
		public TankStatusDto GetById(int id) {
			return _mapper.Map<TankStatusDto>(TanksStore.TankStatusList.Single(a => a.Id == id));
		}
		
		[HttpGet]
		public IEnumerable<TankStatusDto> Get() {
			return TanksStore.TankStatusList.Select(a => _mapper.Map<TankStatusDto>(a));
		}
		
		[HttpPost]
		public TankStatusDto Post(TankStatusPost post) {
			TankStatus tankStatus = new TankStatus() {
				Id = TanksStore.TankStatusList.Count + 1,
				Name = post.Name,
				CurrentAmount = 0,
				MaxAmount = post.MaxAmount,
				UpdatedAt = DateTime.Now,
			};
			TanksStore.TankStatusList.Add(tankStatus);
			return _mapper.Map<TankStatusDto>(tankStatus);
		}
		
		[HttpPut("id")]
		public ActionResult<TankStatusDto> Put(int id, TankStatusPut put) {
			var tankStatus = TanksStore.TankStatusList.SingleOrDefault(a => a.Id == id);
			if (tankStatus == null) return NotFound();

			_mapper.Map(put, tankStatus);
			
			return _mapper.Map<TankStatusDto>(tankStatus);
		}
		
		[HttpDelete("id")]
		public IActionResult Delete(int id) {
			var tankStatus = TanksStore.TankStatusList.SingleOrDefault(a => a.Id == id);
			if (tankStatus == null) return NotFound();
			TanksStore.TankStatusList.Remove(tankStatus);
			return Ok();
		}
	}
}