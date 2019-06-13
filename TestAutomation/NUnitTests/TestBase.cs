using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Threading;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    abstract class TestBase
    {
        [OneTimeSetUp]
        public void oneTimeSetup()
        {

        }
        [OneTimeTearDown]
        protected void oneTimeTearDown()
        {

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
