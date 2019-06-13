using NUnit.Framework;
using TestAutomation.Pages.Yandex;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    class YandexPoolOfTests1 : TestBase
    {
        [Test]      
        public void Login_ValidData()
        {
            new Login().Test_Login_Success();
        }
        [Test]
        public void Login_InvalidPassword()
        {
            new Login().Test_Login_InvalidPassword();
        }
        [Test]
        public void Login_InvalidLogin()
        {
            new Login().Test_Login_InvalidLogin();
        }
        [Test]
        public void Navigation()
        {
            new Main().Test_Navigation();
        }       
        [Test]
        public void ChangeLanguage_English()
        {
            new Main().Test_ChangeLanguageToEnglish();
        }
        [Test]
        public void Logout()
        {
            new Mail().Test_Logout();
        }
    }
}
