using NUnit.Framework;
using TestAutomation.PageMaps;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    class YandexLoginTest : TestBase
    {
        private YandexMailPage page;
        [OneTimeSetUp]
        protected void oneTimeSetUp()
        {
            page = new YandexMailPage();
        }
        [SetUp]
        public void setUp()
        {
            
        }
        [Test]
        public void Logout()
        {
            page.logout();
        }
    }
}
