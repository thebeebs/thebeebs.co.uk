using Microsoft.AspNet.Mvc;
using thebeebs.co.uk.Model;

namespace thebeebs.co.uk.Controllers
{
    public class HomeController : Controller
    {
		public IPageService PageService { get; set; }

		// GET: /<controller>/
		public IActionResult Index()
        {
            return View();
        }

		public IActionResult Page(string postname)
		{
			var page = PageService.GetBySlug(postname);
			page.Title = postname;
			return View(page);
		}
	}
}
