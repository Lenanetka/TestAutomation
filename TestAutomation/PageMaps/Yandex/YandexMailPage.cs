using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.PageMaps.Yandex
{
    public class YandexMailPage : PageMap
    {
        public static string url = "https://mail.yandex.by/";
        private string userButtonXPath = "/html/body/div[2]/div[4]/div/div[2]/div[4]/div[7]";
        private string userDropdownXPath = "//div[@class='_nb-popup-content']";
        private string userDropDownListCSSSelector = ".b-user-dropdown-content.b-user-dropdown-content-with-exit";
        private string userNameClass = "mail-User-Name";
        public YandexMailPage() : base()
        {

        }
        public void logout()
        {
            new Button().click(By.XPath(userButtonXPath));
            Assert.IsTrue(new ElementProperties().isDisplayed(By.XPath(userDropdownXPath)));
            new Button().click(new Element().getElementFromList(By.CssSelector(userDropDownListCSSSelector), 7));
            Assert.IsTrue(browser.getCurrentUrl().Contains(YandexMainPage.url));
        }
        public void userNameIs(string name)
        {
            Assert.AreEqual(name, new ElementProperties().getText(By.ClassName(userNameClass)));
        }
    }
}
