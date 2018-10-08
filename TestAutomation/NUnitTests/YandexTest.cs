using NUnit.Framework;
using TestAutomation.PageMaps.Yandex;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    class YandexTest : TestBase
    {
        [Test]
        public void Login()
        {
            new YandexLoginPage().login("AutotestUser", "AutotestUser123");
            new YandexMailPage().userNameIs("AutotestUser");
        }
        [Test]
        public void Logout()
        {
            new YandexLoginPage().login("AutotestUser", "AutotestUser123");
            new YandexMailPage().logout();
        }
    }
}
