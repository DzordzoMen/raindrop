using Microsoft.AspNetCore.Mvc;
using RaindropApi.Model.Users;

namespace RaindropApi.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class UsersController : ControllerBase{
		private readonly UserInfo _userInfo = new UserInfo() {
			UserId = 1,
			TotalCollectedAmount = 23_034
		};
		
		[HttpGet("{id}")]
		public UserInfo GetById([FromRoute] int id = 1) {
			return _userInfo;
		}

		[HttpPut("{id}")]
		public UserInfo Update(UserInfoPut put,[FromRoute] int id = 1) {
			_userInfo.RoofArea = put.RoofArea;
			return _userInfo;
		}
	}

	public class UserInfoPut {
		public decimal RoofArea { get; set; }
	}
}