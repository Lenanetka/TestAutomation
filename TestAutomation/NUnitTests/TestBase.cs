using NUnit.Framework;
using TestAutomation.PageMaps;
using NUnit.Framework.Interfaces;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    abstract class TestBase
    {
        [TearDown]
        protected void tearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure || TestContext.CurrentContext.Result.Outcome == ResultState.Error)
            {
                
            }
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Warning)
            {

            }
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Success)
            {

            }
        }
    }
}
