using NUnit.Framework;
using TestAutomation.WebElements;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    class LoginTest : PortalTest<PageLogin>
    {
        [OneTimeSetUp]
        public void oneTimeSetUp()
        {
            page = new PageLogin(container);
        }
        [Test]
        public void SignIn_ValidData_SignedIn()
        {
            bool result = page.signIn_Successfull("admin", "@Nd3rsen!");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void SignIn_EmptyEmail_ErrorMessage()
        {
            string result = page.signIn_EmailValidationError(" ", "@Nd3rsen!");
            Assert.AreEqual("Email cannot be blank.", result);
        }
    }
}
