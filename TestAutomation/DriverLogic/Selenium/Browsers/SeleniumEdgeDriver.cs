using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium.Browsers
{
    public class SeleniumEdgeDriver : SeleniumWebDriver
    {
        public SeleniumEdgeDriver(WebDriverConfigs configs) : base(configs)
        {
            driver = new EventFiringWebDriver(new EdgeDriver(configs.getDriverPath(), SeleniumWebDriverOptions.edgeOptions(configs)));
            if (configs.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
        }
    }
}