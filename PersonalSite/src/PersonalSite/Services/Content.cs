using PersonalSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Services
{
    public class Content
    {
        public static ContentOverview FetchOverview() {
            var overview = new ContentOverview();
            overview.Categories = new List<Category>();
            overview.Categories.Add(new Category { Name = "Web" });
            overview.Categories.Add(new Category { Name = "Bots" });
            overview.Categories.Add(new Category { Name = "Xamarin" });


            //galleries,shorts,interviews,guestposts
            overview.Types = new List<ViewModels.Type>();
            overview.Types.Add(new ViewModels.Type { Name = "News", Symbol = "news" });
            overview.Types.Add(new ViewModels.Type { Name = "Galleries", Symbol = "galleries" });
            overview.Types.Add(new ViewModels.Type { Name = "Shorts", Symbol = "shorts" });
            overview.Types.Add(new ViewModels.Type { Name = "Interviews", Symbol = "interviews" });
            overview.Types.Add(new ViewModels.Type { Name = "Guestposts", Symbol = "guestposts" });

            return overview;
        }
    }
}
