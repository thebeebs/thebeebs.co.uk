using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace PersonalSite.Controllers
{
    public class HomeController : Controller
    {
        private IMemoryCache memoryCache;

        public HomeController(IMemoryCache memoryCache) {
            this.memoryCache = memoryCache;
        }

        public async Task<IActionResult> Index()
        {
            var overview = Services.Content.FetchOverview();
            return View(overview);
        }

        public IActionResult Page(string page)
        {
            var p = memoryCache.Get(page);
            if (p == null)
            {
                p = Services.Content.FetchPage(page);
                memoryCache.Set(page, p);
            }
            return View(p);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
