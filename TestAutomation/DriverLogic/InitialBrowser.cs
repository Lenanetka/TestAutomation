using TestAutomation.DriverLogic.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.DriverLogic
{
    public class InitialBrowser
    {
        private static WebDriverLogger logger;
        public Browser getInstance()
        {
            Browser browser = new Browser();
            if (logger == null) logger = new WebDriverLogger();
            //browser.registerListener(logger);
            return browser;
        }
    }
}
