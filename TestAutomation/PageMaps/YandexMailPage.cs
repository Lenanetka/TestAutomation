using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.PageMaps
{
    public class YandexMailPage : PageMap
    {
        public static string url = "mail.yandex.by";
        private string userButtonXPath = "/html/body/div[2]/div[4]/div/div[2]/div[4]/div[7]";
        private string logoutButtonXPath = "//*[@id='nb-7']/div/div/div[7]";
        public void logout()
        {
            new YandexLoginPage().login("AutotestUser", "AutotestUser123");
            UserButton.click();
            LogoutButton.click();
        }
        public YandexMailPage() : base()
        {

        }
        private Element UserButton
        {
            get
            {
                return browser.getElement().byXPath(userButtonXPath);
            }
        }
        private Element LogoutButton
        {
            get
            {
                return browser.getElement().byXPath(logoutButtonXPath);
            }
        }
    }
}
