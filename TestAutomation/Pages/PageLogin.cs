using OpenQA.Selenium;
using TestAutomation.Driver;
using System;

namespace TestAutomation.Pages
{
    public class PageLogin : Page
    {
        public PageLogin(string container) : base(container)
        {
            pageThis = "site/login";
        }
        protected static string pageMain = "framework";
        private string pageLogout = "site/logout";
        private static string emailFieldId = "loginform-email";
        private static string passwordFieldId = "loginform-password";
        private static string confirmButtonId = "sign_button";
        private static string errorMessageXPath = "(//form[@id='w0']//div[@class='login-error'])[1]";
        public override void toStartPosition()
        {
            driver.goToUrl(Portal.getBaseURL(container) + pageLogout);
            driver.clearElement(By.Id(emailFieldId));
            driver.clearElement(By.Id(passwordFieldId));
        }
        private void tryToSignIn(string login, string password)
        {
            driver.inputIntoElement(By.Id(emailFieldId), login);
            driver.inputIntoElement(By.Id(passwordFieldId), password);
            driver.clickOnElement(By.Id(confirmButtonId));
        }
        public bool signIn_Successfull(string login, string password)
        {
            tryToSignIn(login, password);
            return driver.pageIsOpened(Portal.getBaseURL(container) + pageMain);
        }
        public string signIn_EmailValidationError(string login, string password)
        {
            tryToSignIn(login, password);
            return driver.elementText(By.XPath(errorMessageXPath));
        }
    }
}
