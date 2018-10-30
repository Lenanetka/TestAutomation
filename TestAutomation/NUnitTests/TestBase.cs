using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Allure.Commons;
using System.Management.Automation;
using System;
using System.Threading;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    [AllureNUnit]
    [AllureParentSuite("All tests")]
    abstract class TestBase
    {
        [OneTimeSetUp]
        public void oneTimeSetup()
        {
            //AllureLifecycle.Instance.CleanupResultDirectory();
        }
        [OneTimeTearDown]
        protected void oneTimeTearDown()
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                PowerShellInstance.AddCommand("allure generate \"C:\\Users\\Andersen\\Documents\\Visual Studio 2017\\Projects\\TestAutomation\\allure-results\"");
                PowerShellInstance.Invoke();
            }
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
