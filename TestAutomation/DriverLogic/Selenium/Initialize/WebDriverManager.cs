using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium.Initialize
{
    abstract class WebDriverManager: WebDriverOptions
    {
        protected EventFiringWebDriver chromeDriver()
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new ChromeDriver(configs.getDriverPath(), chromeOptions(configs)));
            return driver;
        }
        protected EventFiringWebDriver firefoxDriver()
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new FirefoxDriver(configs.getDriverPath(), firefoxOptions(configs)));
            return driver;
        }
        protected EventFiringWebDriver operaDriver()
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new OperaDriver(configs.getDriverPath(), operaOptions(configs)));
            return driver;
        }
        protected EventFiringWebDriver edgeDriver()
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new EdgeDriver(configs.getDriverPath(), edgeOptions(configs)));
            if (configs.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
            return driver;
        }
        protected EventFiringWebDriver internetExplorerDriver()
        {
            EventFiringWebDriver driver = new EventFiringWebDriver(new InternetExplorerDriver(configs.getDriverPath(), internetExplorerOptions(configs)));
            if (configs.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
