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

        public List <Story> Content { get; set; }

        public List<Story> SecondaryHeadline { get; set; }

        
    }

    public class Category {  
        public string Name { get; set; }
    }
    public class Type
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
