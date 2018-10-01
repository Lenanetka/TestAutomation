using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium.Browsers
{
    public class SeleniumOperaDriver : SeleniumWebDriver
    {
        public SeleniumOperaDriver(WebDriverConfigs configs) : base(configs)
        {
            driver = new EventFiringWebDriver(new OperaDriver(configs.getDriverPath(), SeleniumWebDriverOptions.operaOptions(configs)));
        }
    }
}