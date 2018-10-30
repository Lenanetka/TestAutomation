using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using TestAutomation.Pages.Yandex;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Yandex")]
    [AllureSubSuite("Pool 1")]
    class YandexPoolOfTests1 : TestBase
    {
        [Test]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-1")]
        [AllureSeverity(SeverityLevel.blocker)]       
        public void Login_ValidData()
        {
            new Login().Test_Login_Success();
        }
        [Test]
        [AllureIssue("ISSUE-2")]
        [AllureTms("TMS-2")]
        [AllureSeverity(SeverityLevel.minor)]
        public void Login_InvalidPassword()
        {
            new Login().Test_Login_InvalidPassword();
        }
        [Test]
        [AllureIssue("ISSUE-3")]
        [AllureTms("TMS-3")]
        [AllureSeverity(SeverityLevel.minor)]
        public void Login_InvalidLogin()
        {
            new Login().Test_Login_InvalidLogin();
        }
        [Test]
        [AllureIssue("ISSUE-4")]
        [AllureTms("TMS-4")]
        [AllureSeverity(SeverityLevel.critical)]
        public void Navigation()
        {
            new Main().Test_Navigation();
        }       
        [Test]
        [AllureIssue("ISSUE-5")]
        [AllureTms("TMS-5")]
        [AllureSeverity(SeverityLevel.minor)]
        public void ChangeLanguage_English()
        {
            new Main().Test_ChangeLanguageToEnglish();
        }
        [Test]
        [AllureIssue("ISSUE-6")]
        [AllureTms("TMS-6")]
        [AllureSeverity(SeverityLevel.critical)]
        public void Logout()
        {
            new Mail().Test_Logout();
        }
    }
}
