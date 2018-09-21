using NUnit.Framework;
using TestAutomation.Pages;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    abstract class PortalTest<PageType> where PageType : Page
    {
        protected static string container = "dev2";
        protected PageType page;
        [OneTimeTearDown]
        public void oneTimeTearDown()
        {
            page.closeBrowser();
        }
        [SetUp]
        public void tearDown()
        {
            page.toStartPosition();
        }
    }
}
