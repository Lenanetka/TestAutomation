using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium.Browsers
{
    public class SeleniumInternetExplorerDriver : SeleniumWebDriver
    {
        public SeleniumInternetExplorerDriver(WebDriverConfigs configs) : base(configs)
        {
            driver = new EventFiringWebDriver(new InternetExplorerDriver(configs.getDriverPath(), SeleniumWebDriverOptions.internetExplorerOptions(configs)));
            if (configs.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
        }
    }
}