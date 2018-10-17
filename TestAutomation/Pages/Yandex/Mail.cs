using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.Pages.Yandex
{
    public class Mail : PageMap
    {
        public static string url = "https://mail.yandex.by/";
        #region locators
        private By UserButton = By.CssSelector("div.ns-view-head-user.mail-User");
        private By LogoutButton = By.CssSelector(".b-user-dropdown-content.b-user-dropdown-content-with-exit>div:nth-child(7)");
        private By UserNameLabel = By.ClassName("mail-User-Name");
        #endregion
        public Mail() : base()
        {

        }
        #region actions
        public void logout()
        {
            button.click(UserButton);
            button.click(LogoutButton);

            StringAssert.StartsWith(Main.url, browser.getCurrentUrl());
        }
        public void checkUserName(string expectedUserName)
        {
            Assert.AreEqual(expectedUserName, new ElementProperties().getText(UserNameLabel));
        }
        #endregion
        #region tests
        public void Test_Logout()
        {
            browser.navigate(Main.url);
            new Main().goToLoginToMailPage();
            new Login().loginSuccess();
            logout();
        }
        #endregion
    }
}
