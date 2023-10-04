using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace UmbracoProject1.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		[HttpPost]
		public async Task<string> Login([FromForm]string userName, [FromForm]string password)
		{
			var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
			var service = new ICUTechClient();
			var response = await service.LoginAsync(userName, password, remoteIpAddress?.ToString());
			
			return response.@return;
		}

		[HttpPost]
		public async Task<string> Register([FromForm]string email, [FromForm]string password)
		{
			var service = new ICUTechClient();
			var rand = new Random();
			var randInteger = rand.Next(0, 100000000);
			var response = await service.RegisterNewCustomerAsync(email, password, "", "", randInteger.ToString(), 0, 0, "");

			return response.@return;
		}
	}
}
