using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalSite.ViewModels;

namespace PersonalTests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void PageCountGreaterThanZero()
        {
            var overview = PersonalSite.Services.Content.FetchOverview();
            Assert.IsTrue(overview.PageCount > 0);
            
        }

        [TestMethod]
        public void FetchStory()
        {
            var url = "https://raw.githubusercontent.com/thebeebs/Content/master/5%20things%20to%20get%20compatible%20with%20edge.md";

            var overview = PersonalSite.Services.Content.FetchStory(url);

            overview.Wait();
            Assert.IsTrue(overview.Result.StartsWith("---")) ;


        }

        [TestMethod]
        public void ConvertKnownMarkdownToHTML()
        {
            var content = PersonalSite.Services.Content.ConvertMarkdown("**Hello world!**");
            
            Assert.IsTrue(content.StartsWith("<p><strong>Hello"));


        }

        [TestMethod]
        public void ConvertKnownMarkdownToHTMLIntegration()
        {
            var url = "https://raw.githubusercontent.com/thebeebs/Content/master/5%20things%20to%20get%20compatible%20with%20edge.md";

            var overview = PersonalSite.Services.Content.FetchStory(url);

            overview.Wait();

            var result = PersonalSite.Services.Content.ConvertMarkdown(overview.Result);

            Assert.AreEqual("Hiya is", result);
            
        }

        [TestMethod]
        public void GetHeader()
        {
            var str = @"---
                        title: '5 things To Get Compatible With Microsoft Edge'
                        authors:
                        -thebeebs
                        - martinkearn
                        intro: 'Here are 5 ways in which you can make sure your site rock on Edge.'
                        types:
                        -opinion
                        categories:
                        -web
                        - browsers
                        ---
                        
                        this stuff is not the header";
        }

    }
}