using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.ViewModels
{
    public class ContentOverview
    {       
        public List<Category> Categories { get; set; }
        public List<Type> Types { get; set; }

        public Story Headline { get; set; }
        public Story MonthNote { get; set; }

        public List <Story> Content { get; set; }
        public List<Story> CurrentContent
        {
            get { return Content.Take<Story>(9).ToList(); }
        }

        public List<Story> SecondaryHeadline { get; set; }

        public List<Story> PopularPost { get; set; }

        public int PageNumber
        {
            get { return 1; }
        }
        public int PageCount
        {
            get { return (Content.Count / 9); }
        }


    }

    public class Category {  
        public string Name { get; set; }
        public string Link { get; set; }
    }
    public class Type
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
