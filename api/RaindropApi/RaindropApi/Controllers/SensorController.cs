using Microsoft.AspNetCore.Mvc;

namespace RaindropApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class SensorController : ControllerBase {
        [HttpPost]
        public IActionResult Post(decimal volume, string apiKey) {
            return Ok();
        }
    }
}