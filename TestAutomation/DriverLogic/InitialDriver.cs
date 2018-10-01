using TestAutomation.DriverLogic.Selenium;
using TestAutomation.DriverLogic;
using TestAutomation.Report;
using System;

namespace TestAutomation.WebElements
{
    class InitialDriver
    {
        [ThreadStatic]
        private static SeleniumWebDriverManager driver;
        private WebDriverConfigs config;
        private static Object thisLock = new Object();
        public static SeleniumWebDriverManager getInstance()
        {
            if (driver == null)
            {
                lock (thisLock)
                {
                    if (driver == null)
                    {
                        driver = new SeleniumWebDriverManager("config.ini");
                        driver.setup();
                        //driver.Logger = new ReportPdf(System.Environment.CurrentDirectory + @"/log.pdf");
                        public void setup()
                        {
                            string path = config.PATH;
                            if (config.VERSION != null && config.VERSION != "") path += config.VERSION + @"\";
                            switch (config.DRIVER)
                            {
                                case "CHROME":
                                    driver = new EventFiringWebDriver(new ChromeDriver(path, SeleniumWebDriverOptions.chromeOptions(config)));
                                    break;
                                case "FIREFOX":
                                    driver = new EventFiringWebDriver(new FirefoxDriver(path, SeleniumWebDriverOptions.firefoxOptions(config)));
                                    break;
                                case "OPERA":
                                    driver = new EventFiringWebDriver(new OperaDriver(path, SeleniumWebDriverOptions.operaOptions(config)));
                                    break;
                                case "IE":
                                    {
                                        driver = new EventFiringWebDriver(new InternetExplorerDriver(path, SeleniumWebDriverOptions.internetExplorerOptions(config)));
                                        if (config.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
                                        break;
                                    }
                                case "Edge":
                                    driver = new EventFiringWebDriver(new EdgeDriver(path, SeleniumWebDriverOptions.edgeOptions(config)));
                                    if (config.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
                                    break;
                            }
                        }
                    }
                }
            }
            return driver;
        }
    }
}
