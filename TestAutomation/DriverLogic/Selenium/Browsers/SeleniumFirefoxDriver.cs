using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium.Browsers
{
    public class SeleniumFirefoxDriver : SeleniumWebDriver
    {
        public SeleniumFirefoxDriver(WebDriverConfigs configs) : base(configs)
        {
            driver = new EventFiringWebDriver(new FirefoxDriver(configs.getDriverPath(), SeleniumWebDriverOptions.firefoxOptions(configs)));
        }
    }
}