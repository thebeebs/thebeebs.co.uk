using Octokit;
using PersonalSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Services
{
    public class Content
    {

        public async static Task<ContentOverview> RebuildContent()
        {
            var overview = FetchOverview();
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            var content = await client.Repository.Content.GetAllContents("thebeebs", "content");
           
            foreach (var item in content) {
                overview.Content[0].Body = item.Content;
            }
            return overview;
        }
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
            overview.Headline.ImageUrl = "/wp-content/uploads/2014/11/phone.jpg";
            overview.Headline.Link = "http://localhost:39016/why-imessgae-will-never-beat-whatsapp";
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

        internal static object FetchPage(string page)
        {
            var story = new Story();

            story.Author = "thebeebs";
            story.Title = page;

            return story;

        }
    }
}
