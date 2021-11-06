using Microsoft.AspNetCore.Mvc;

namespace RaindropApi.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class UsersController : ControllerBase{
		[HttpGet("id/stats")]
		public UserStat GetById(int id = 1) {
			return new UserStat() {
				TotalCollectedAmount = 23_034
			};
		}
	}
}