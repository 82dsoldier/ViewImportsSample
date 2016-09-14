using Microsoft.AspNetCore.Mvc;

namespace QuickFrame.Mvc {

	public class ControllerCore : Controller {

		[HttpGet]
		public IActionResult Index() => IndexCore();

		protected virtual IActionResult IndexCore() {
			return View("Index");
		}
	}
}