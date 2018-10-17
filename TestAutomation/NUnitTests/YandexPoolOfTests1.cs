using NUnit.Allure.Attributes;
using NUnit.Framework;
using TestAutomation.Pages.Yandex;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    [AllureSubSuite("Pool of tests 1")]
    class YandexPoolOfTests1 : TestBase
    {
        [Test]
        public void Login_ValidData()
        {
            new Main().goToLoginPage();
            new Login().loginSuccess();
            new Mail().checkUserName();
        }
        [Test]
        public void Login_InvalidPassword()
        {
            new Main().goToLoginPage();
            new Login().loginInvalidPassword();
        }
        [Test]
        public void Login_InvalidLogin()
        {
            new Main().goToLoginPage();
            new Login().loginInvalidLogin();
        }
        [Test]
        public void Navigation()
        {
            new Main().Test_Navigation();
        }
        [Test]
        public void ChangeLanguage_English()
        {
            new Main().Test_ChangeLanguage_English();
        }
        [Test]
        public void Logout()
        {
            new Main().goToLoginPage();
            new Login().loginSuccess();
            new Mail().logout();
        }
    }
}
