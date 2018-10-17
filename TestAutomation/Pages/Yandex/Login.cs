using TestAutomation.DriverLogic.Selenium.Elements;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestAutomation.Pages.Yandex
{
    public class Login : PageMap
    {
        public static string url = "https://passport.yandex.by/";
        public static string urlTemplate = "https://passport.yandex.";
        private string loginS = "AutotestUser";
        private string passwordS = "AutotestUser123";
        private string loginF = "NoAutotestUser";
        private string passwordF = "NoAutotestUser123";
        private string loginFieldName = "login";
        private string passwordFieldName = "passwd";
        private string submitLoginButtonFullCssSelector = "button.passport-Button";
        private string submitLoginButtonShortCssSelector = "button.passp-form-button";
        
        private string errorLabelXPath = "//*[@id='root']/div/div[2]/div[1]/div[1]";
        public Login(): base()
        {
            
        }
        public void loginFullForm(string name, string password)
        {
            new Field().input(By.Name(loginFieldName), name);
            new Field().input(By.Name(passwordFieldName), password);
            new Button().click(By.CssSelector(submitLoginButtonFullCssSelector));
        }
        public void loginShortForm(string name, string password)
        {
            new Field().input(By.Name(loginFieldName), name);
            new Button().click(By.CssSelector(submitLoginButtonShortCssSelector));
            new Field().input(By.Name(passwordFieldName), password);
            new Button().click(By.CssSelector(submitLoginButtonShortCssSelector));
        }
        public void login(string name, string password)
        {
            if (!new ElementProperties().isPresent(By.Name(passwordFieldName)))
                loginShortForm(name, password);
            else loginFullForm(name, password);
        }
        public void loginSuccess()
        {
            login(loginS, passwordS);
        }
        public void loginInvalidLogin()
        {
            login(loginF, passwordS);
            StringAssert.Contains("Такого аккаунта нет", new ElementProperties().getText(By.XPath(errorLabelXPath)));
        }
        public void loginInvalidPassword()
        {
            login(loginS, passwordF);
            StringAssert.Contains("Неверный пароль", new ElementProperties().getText(By.XPath(errorLabelXPath)));
        }
    }
}
