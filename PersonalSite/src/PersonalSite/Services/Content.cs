using Octokit;
using PersonalSite.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
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
            overview.Categories.Add(new Category { Name = "Browsers" });
            overview.Categories.Add(new Category { Name = "Personal" });


            //galleries,shorts,interviews,guestposts
            overview.Types = new List<ViewModels.Type>();
            overview.Types.Add(new ViewModels.Type { Name = "Opinion", Symbol = "news" });
            overview.Types.Add(new ViewModels.Type { Name = "Video", Symbol = "galleries" });
            overview.Types.Add(new ViewModels.Type { Name = "Overview", Symbol = "guestposts" });
            overview.Types.Add(new ViewModels.Type { Name = "Shorts", Symbol = "shorts" });
            overview.Types.Add(new ViewModels.Type { Name = "Tutorials", Symbol = "interviews" });
            overview.Types.Add(new ViewModels.Type { Name = "Speaking", Symbol = "guestposts" });


            overview.Headline = new Story();

            overview.Headline.Author = "thebeebs";
            overview.Headline.Category = new List<Category>();
            overview.Headline.Category.Add(new Category { Name = "Web" });
            overview.Headline.Type = new List<ViewModels.Type>();
            overview.Headline.Type.Add(new ViewModels.Type { Name = "Opinion", Symbol = "news" });
            overview.Headline.ImageUrl = $"{BaseURL()}/wp-content/uploads/2014/11/phone.jpg";
            overview.Headline.Link = $"{BaseURL()}/why-imessgae-will-never-beat-whatsapp";
            overview.Headline.Published = DateTime.Now.AddHours(-4);
            overview.Headline.Summary = "Most of us have experienced some form of 'platform shut out' - when you want to share something with a friend but can't because they use a different device from you and the app isn't available on that device. This problem is particularly acute when it comes to messenger apps, but is common in many apps with sharing or collaboration functionality. WhatsApp and iMessage illustrate the two approaches that native applications developers take. iMessage works... ";
            overview.Headline.Title = "Why iMessage will never beat WhatsApp";
            overview.Content = new List<Story>();
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);
            overview.Content.Add(overview.Headline);


            overview.SecondaryHeadline = new List<Story>();
            overview.SecondaryHeadline.Add(overview.Headline);
            overview.SecondaryHeadline.Add(overview.Headline);
            overview.SecondaryHeadline.Add(overview.Headline);

            overview.MonthNote = overview.Headline;

            overview.PopularPost = new List<Story>();
            overview.PopularPost.Add(overview.Headline);
            overview.PopularPost.Add(overview.Headline);
            overview.PopularPost.Add(overview.Headline);
            overview.PopularPost.Add(overview.Headline);
            overview.PopularPost.Add(overview.Headline);

            return overview;
        }

        public static Story ExtractHeader(string str)
        {

            //var str = @"---
            //            title: '5 things To Get Compatible With Microsoft Edge'
            //            authors:
            //            -thebeebs
            //            - martinkearn
            //            intro: 'Here are 5 ways in which you can make sure your site rock on Edge.'
            //            types:
            //            -opinion
            //            categories:
            //            -web
            //            - browsers
            //            ---

            //            this stuff is not the header";

            if (!str.StartsWith("---")) throw new FormatException(); 

            if (!(str.LastIndexOf("---") > 0)) throw new FormatException(); 

            StringReader sr = new StringReader(str);
            sr.ReadLine();
            
            var title = sr.ReadLine();
            var position = title.IndexOf(":");

            title = title.Substring(position + 1, (title.Length - position) -1);
            title = title.Trim();
            char[] chArr = { '\''};
            char[] hyp = { '-' };
            title = title.Trim(chArr);

            // Start Extracting Authors
            var auth = sr.ReadLine();
            if (!auth.Contains("authors:")) throw new FormatException();
            var authorFirst = sr.ReadLine().Trim();
            authorFirst = authorFirst.Trim(hyp).Trim();
            
            var nextLine = sr.ReadLine().Trim();
            
            // It's another author
            if (nextLine.StartsWith("-"))
            {
                nextLine = nextLine.Trim(hyp).Trim();
                authorFirst = $"{authorFirst}, {nextLine}";
                nextLine = sr.ReadLine();
            }

            //position = nextLine.IndexOf(":");
            //var intro = nextLine.Substring(position + 1, (title.Length - position) - 1).Trim().Trim(chArr);


            return new Story() { Title = title, Author = authorFirst };
        }

        public static string BaseURL() {
            return "thebeebs.co.uk";
        }

        internal static Story FetchPage(string page)
        {
            var story = new Story();

            story.Author = "thebeebs";
            story.Title = page;

            return story;

        }

        public async static Task<string> FetchStory(string url)
        {
            // Get A URL and Convert to string
          
            var client = new HttpClient();
            var item = await client.GetAsync(url);
            var str = await item.Content.ReadAsStringAsync();
            return str;
        }

        public static string ConvertMarkdown(string markdown)
        {
            
            return CommonMark.CommonMarkConverter.Convert(markdown);            
        }

        //public static string GetHeader(string str) {
            
            

        //}
    }
}
