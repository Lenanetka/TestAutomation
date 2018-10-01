using TestAutomation.DriverLogic.Selenium;
using TestAutomation.DriverLogic.Selenium.Browsers;
using TestAutomation.WebElements;
using TestAutomation.Report;
using System;

namespace TestAutomation.DriverLogic
{
    class InitialDriver
    {
        [ThreadStatic]
        private static SeleniumWebDriver driver;
        private WebDriverConfigs config;
        private static Object thisLock = new Object();
        public static IBrowser getInstance()
        {
            if (driver == null)
            {
                lock (thisLock)
                {
                    if (driver == null)
                    {
                        WebDriverConfigs configs = new WebDriverConfigs("config.ini");
                        //driver.Logger = new ReportPdf(System.Environment.CurrentDirectory + @"/log.pdf");
                        switch (configs.DRIVER)
                        {
                            case "CHROME":
                                driver = new SeleniumChromeDriver(configs);
                                break;
                            case "FIREFOX":
                                driver = new SeleniumFirefoxDriver(configs);
                                break;
                            case "OPERA":
                                driver = new SeleniumOperaDriver(configs);
                                break;
                            case "IE":
                                driver = new SeleniumInternetExplorerDriver(configs);
                                break;
                            case "Edge":
                                driver = new SeleniumEdgeDriver(configs);
                                break;
                        }
                        return driver;
                    }
                }
            }
            return driver;
        }
    }
}
