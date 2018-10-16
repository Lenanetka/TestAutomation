using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Allure.Commons;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    [AllureNUnit]
    [AllureParentSuite("All tests")]
    abstract class TestBase
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }
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
