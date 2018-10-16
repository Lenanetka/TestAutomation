using NUnit.Allure.Attributes;
using NUnit.Framework;
using TestAutomation.PageMaps.Yandex;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    [AllureSubSuite("Pool of tests 1")]
    class YandexPullOfTests1 : TestBase
    {
        [Test]
        public void Login_ValidData()
        {
            new Main().openLoginPage();
            new Login().loginSuccess();
            new Mail().checkUserName();
        }
        [Test]
        public void Login_InvalidPassword()
        {
            new Main().openLoginPage();
            new Login().loginInvalidPassword();
        }
        [Test]
        public void Login_InvalidLogin()
        {
            new Main().openLoginPage();
            new Login().loginInvalidLogin();
        }
        [Test]
        public void Navigation()
        {
            new Main().navigationSuccess();
        }
        [Test]
        public void ChangeLanguage_English()
        {
            new Main().changeLanguage_English();
        }
        [Test]
        public void Logout()
        {
            new Main().openLoginPage();
            new Login().loginSuccess();
            new Mail().logout();
        }
    }
}
