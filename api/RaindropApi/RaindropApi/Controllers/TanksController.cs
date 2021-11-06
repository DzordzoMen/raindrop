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
		public TankStatus GetById(int id) {
			return TanksStore.TankStatusList.Single(a => a.Id == id);
		}
		
		[HttpGet]
		public IEnumerable<TankStatus> Get() {
			return TanksStore.TankStatusList;
		}
		
		[HttpPost]
		public TankStatus Post(TankStatusPost post) {
			TankStatus tankStatus = new TankStatus() {
				Id = TanksStore.TankStatusList.Count + 1,
				Name = post.Name,
				CurrentAmount = 0,
				MaxAmount = post.MaxAmount,
				UpdatedAt = DateTime.Now,
			};
			TanksStore.TankStatusList.Add(tankStatus);
			return tankStatus;
		}
		
		[HttpPut("id")]
		public ActionResult<TankStatus> Put(int id, TankStatusPut put) {
			var tankStatus = TanksStore.TankStatusList.SingleOrDefault(a => a.Id == id);
			if (tankStatus == null) return NotFound();

			_mapper.Map(put, tankStatus);
			
			return tankStatus;
		}
		
		[HttpDelete("id")]
		public IActionResult Delete(int id) {
			var tankStatus = TanksStore.TankStatusList.SingleOrDefault(a => a.Id == id);
			if (tankStatus == null) return NotFound();
			TanksStore.TankStatusList.Remove(tankStatus);
			return Ok();
		}
	}

	public class TankStatus {
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal CurrentAmount { get; set; }
		public decimal MaxAmount { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}