using Microsoft.AspNetCore.Mvc;
using QuickFrame.Mvc;

namespace Asmt.Controllers {

	public class ApplicationsController : Controller {
		public IActionResult Index() {
			return View();
		}
	}
}