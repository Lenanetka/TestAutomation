using TestAutomation.DriverLogic.Selenium.Elements;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestAutomation.Pages.Yandex
{
    public class Login : PageMap
    {
        public static string url = "https://passport.yandex.by/";
        public static string urlTemplate = "https://passport.yandex.";
        #region locators
        private By LoginField = By.Name("login");
        private By PasswordField = By.Name("passwd");
        private By SubmitLoginButtonOnFullForm = By.CssSelector("button.passport-Button");
        private By SubmitLoginButtonOnShortForm = By.CssSelector("button.passp-form-button");        
        private By ErrorLabel = By.XPath("//*[@id='root']/div/div[2]/div[1]/div[1]");
        #endregion
        #region data
        private string loginValid = "AutotestUser";
        private string passwordValid = "AutotestUser123";
        private string loginInvalid = "NoAutotestUser";
        private string passwordInvalid = "NoAutotestUser123";
        private string invalidLoginErrorMessage = "Такого аккаунта нет";
        private string invalidPasswordErrorMessage = "Неверный пароль";
        #endregion
        public Login(): base()
        {
            
        }
        #region actions
        public void loginFullForm(string name, string password)
        {
            field.input(LoginField, name);
            field.input(PasswordField, password);
            button.click(SubmitLoginButtonOnFullForm);
        }
        public void loginShortForm(string name, string password)
        {
            field.input(LoginField, name);
            button.click(SubmitLoginButtonOnShortForm);
            field.input(PasswordField, password);
            button.click(SubmitLoginButtonOnShortForm);
        }
        public void login(string name, string password)
        {
            if (!new ElementProperties().isPresent(PasswordField))
                loginShortForm(name, password);
            else loginFullForm(name, password);
        }
        public void loginSuccess()
        {
            login(loginValid, passwordValid);
        }
        public void loginError(string name, string password, string expectedErrorMessage)
        {
            login(name, password);
            Assert.AreEqual(expectedErrorMessage, elementProperties.getText(ErrorLabel));
        }
        #endregion
        #region tests
        public void Test_Login_Success()
        {
            browser.navigate(Main.url);
            new Main().goToLoginToMailPage();
            loginSuccess();
            new Mail().checkUserName(loginValid);
            //end
            new Mail().logout();
        }
        public void Test_Login_InvalidLogin()
        {
            browser.navigate(Main.url);
            new Main().goToLoginToMailPage();
            loginError(loginInvalid, passwordValid, invalidLoginErrorMessage);
        }
        public void Test_Login_InvalidPassword()
        {
            browser.navigate(Main.url);
            new Main().goToLoginToMailPage();
            loginError(loginValid, passwordInvalid, invalidPasswordErrorMessage);
        }
        #endregion
    }
}
