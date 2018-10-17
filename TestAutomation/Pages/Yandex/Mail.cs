using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.Pages.Yandex
{
    public class Mail : PageMap
    {
        public static string url = "https://mail.yandex.by/";
        private string expectedUserName = "AutotestUser";
        private string userButtonXPath = "/html/body/div[2]/div[4]/div/div[2]/div[4]/div[7]";
        private string userDropDownListCSSSelector = ".b-user-dropdown-content.b-user-dropdown-content-with-exit>div:nth-child(7)";
        private string userNameClass = "mail-User-Name";
        public Mail() : base()
        {

        }
        public void logout()
        {
            new Button().click(By.XPath(userButtonXPath));
            new Button().click(By.CssSelector(userDropDownListCSSSelector));

            StringAssert.StartsWith(Main.url, browser.getCurrentUrl());
        }
        public void checkUserName()
        {
            Assert.AreEqual(expectedUserName, new ElementProperties().getText(By.ClassName(userNameClass)));
        }
    }
}
