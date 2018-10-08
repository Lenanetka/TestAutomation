using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.PageMaps
{
    public class YandexMainPage : PageMap
    {
        public static string url = "https://yandex.by/";
        private string loginToMailButtonXPath = "/html/body/div[1]/div[3]/div[1]/div/div[1]/div/a";       
        public YandexMainPage() : base()
        {

        }
        public void goToLoginPage()
        {
            browser.navigate(url);
            new Button().click(By.XPath(loginToMailButtonXPath));
            Assert.IsTrue(browser.getCurrentUrl().Contains(YandexLoginPage.url));
        }       
    }
}
