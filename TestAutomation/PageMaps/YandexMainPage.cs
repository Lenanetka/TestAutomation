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
            LoginToMailButton.click();
        }
        private Element LoginToMailButton
        {
            get
            {
                return browser.getElement().byXPath(loginToMailButtonXPath);
            }
        }
    }
}
