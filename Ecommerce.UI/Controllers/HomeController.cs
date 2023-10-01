using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.UI.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
