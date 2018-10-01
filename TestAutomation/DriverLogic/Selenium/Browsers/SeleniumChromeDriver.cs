using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium.Browsers
{
    public class SeleniumChromeDriver: SeleniumWebDriver
    {
        public SeleniumChromeDriver(WebDriverConfigs configs) : base(configs)
        {
            driver = new EventFiringWebDriver(new ChromeDriver(configs.getDriverPath(), SeleniumWebDriverOptions.chromeOptions(configs)));
        }   
    }
}