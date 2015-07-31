using thebeebs.co.uk.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace thebeebs.co.uk.Controllers
{
    public class HomeController : Controller
    {
		[Activate]
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
