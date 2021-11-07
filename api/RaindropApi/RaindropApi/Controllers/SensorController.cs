using System;
using Microsoft.AspNetCore.Mvc;
using RaindropApi.Model.Tanks;

namespace RaindropApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class SensorController : ControllerBase {
        [HttpPost]
        public IActionResult Post(decimal currentAmount, string apiKey) {
            TanksStore.TankStatusList[0].CurrentAmount = currentAmount;
            TanksStore.TankStatusList[0].UpdatedAt = DateTime.Now;
            return Ok();
        }
    }
}