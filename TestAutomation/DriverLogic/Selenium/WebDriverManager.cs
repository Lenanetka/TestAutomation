using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium
{
    static class WebDriverManager
    {
        public static EventFiringWebDriver chrome(WebDriverConfigs configs)
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new ChromeDriver(configs.getDriverPath(), WebDriverOptions.chromeOptions(configs)));
            return driver;
        }
        public static EventFiringWebDriver firefox(WebDriverConfigs configs)
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new FirefoxDriver(configs.getDriverPath(), WebDriverOptions.firefoxOptions(configs)));
            return driver;
        }
        public static EventFiringWebDriver opera(WebDriverConfigs configs)
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new OperaDriver(configs.getDriverPath(), WebDriverOptions.operaOptions(configs)));
            return driver;
        }
        public static EventFiringWebDriver edge(WebDriverConfigs configs)
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new EdgeDriver(configs.getDriverPath(), WebDriverOptions.edgeOptions(configs)));
            if (configs.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
            return driver;
        }
        public static EventFiringWebDriver internetExplorer(WebDriverConfigs configs)
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new InternetExplorerDriver(configs.getDriverPath(), WebDriverOptions.internetExplorerOptions(configs)));
            if (configs.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
