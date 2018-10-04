using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.PageMaps
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
            LoginField.input("AutotestUser");
            PasswordField.input("AutotestUser123");
            SubmitLoginButton.click();
        }      
        private Field LoginField
        {
            get
            {
                return browser.getField().byName(loginFieldName);
            }
        }
        private Field PasswordField
        {
            get
            {
                return browser.getField().byName(passwordFieldName);
            }
        }
        private Element SubmitLoginButton
        {
            get
            {
                return browser.getElement().byXPath(submitLoginButtonXPath);
            }
        }
        
    }
}
