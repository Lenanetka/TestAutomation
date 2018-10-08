using TestAutomation.DriverLogic.Selenium.Elements;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestAutomation.PageMaps.Yandex
{
    public class YandexLoginPage : PageMap
    {
        public static string url = "https://passport.yandex.by/";      
        private string loginFieldName = "login";
        private string passwordFieldName = "passwd";
        private string submitLoginButtonXPath = "/html/body/div[1]/div/div[2]/div[1]/div/div/div/div/div/form/div[4]/button[1]/span";
        public YandexLoginPage(): base()
        {

        }
        public void login(string login, string password)
        {
            new YandexMainPage().goToLoginPage();
            new Field().input(By.Name(loginFieldName), login);
            new Field().input(By.Name(passwordFieldName), password);
            new Button().click(By.XPath(submitLoginButtonXPath));
            Assert.IsTrue(browser.getCurrentUrl().Contains(YandexMailPage.url));
        }                
    }
}
