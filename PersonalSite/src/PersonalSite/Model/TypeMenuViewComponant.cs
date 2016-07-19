using Microsoft.AspNetCore.Mvc;
using PersonalSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Model
{
    [ViewComponent(Name = "TypeMenu")]
    public class TypeMenuViewComponant : ViewComponent
    {
        private object overview;

        public TypeMenuViewComponant() {
            overview = Services.Content.FetchOverview();
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            return View(overview);
        }

    }

}
