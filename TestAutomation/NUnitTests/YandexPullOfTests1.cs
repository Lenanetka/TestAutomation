using NUnit.Framework;
using TestAutomation.PageMaps.Yandex;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    class YandexPullOfTests1 : TestBase
    {
        [Test]
        public void Login_ValidData()
        {
            new YandexLoginPage().login("AutotestUser", "AutotestUser123");
            new YandexMailPage().userNameIs("AutotestUser");
        }
        [Test]
        public void Login_InvalidPassword()
        {

        }
        [Test]
        public void Login_InvalidLogin()
        {

        }
        [Test]
        public void Navigation()
        {
            
        }
        [Test]
        public void ChangeLanguage_English()
        {

        }
        [Test]
        public void Logout()
        {
            new YandexLoginPage().login("AutotestUser", "AutotestUser123");
            new YandexMailPage().logout();
        }
    }
}
