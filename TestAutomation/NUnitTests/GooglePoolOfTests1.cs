using NUnit.Framework;
using TestAutomation.Pages.Google;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    class GooglePoolOfTests1 : TestBase
    {
        [Test]
        [Author("Olena","o.palii.andersen@gmail.com")]
        [Description("Simple google search")]
        public void Search()
        {           
            new Main().Test_Search();
            
        }
    }
}
