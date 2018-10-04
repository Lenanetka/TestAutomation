using NUnit.Framework;
using TestAutomation.WebElements;
using TestAutomation.PageMaps;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    class LoginTest
    {
        private LoginPageMap map;
        [SetUp]
        public void setUp()
        {
            map.browser.navigate(map.url);
        }
        [Test]
        public void SignIn_ValidData_SignedIn()
        {
            map.LoginButton.click();
            map.LoginField.input("AutotestUser");
            map.PasswordField.input("AutotestUser123");
            map.SubmitButton.click();
            map.UserAvatarButton.click();
            map.LogoutButton.click();
            Assert.AreEqual("https://yandex.by/", map.browser.getCurrentUrl());
        }
    }
}
