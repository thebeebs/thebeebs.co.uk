using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalSite.ViewModels;

namespace SampleNetCoreUnitTests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void TestMethodPassing()
        {
            var s = new Story();
            
            Assert.IsTrue(s.Author == null);
            
        }

        [TestMethod]
        public void TestMethodFailing()
        {
            var s = new Story();
            Assert.IsTrue(s.Author == null);
        }
    }
}