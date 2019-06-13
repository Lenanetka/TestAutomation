using NUnit.Framework;
using TestAutomation.Pages.Google;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    class GooglePoolOfTests1 : TestBase
    {
        [Test]
        public void Search()
        {           
            new Main().Test_Search();
        }
    }
}
