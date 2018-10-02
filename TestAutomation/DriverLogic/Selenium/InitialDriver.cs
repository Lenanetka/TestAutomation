using OpenQA.Selenium.Support.Events;
using System;

namespace TestAutomation.DriverLogic.Selenium
{
    class InitialDriver
    {
        [ThreadStatic]
        private static EventFiringWebDriver driver;
        private static Object thisLock = new Object();
        public static EventFiringWebDriver getInstance()
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
                                driver = WebDriverManager.chrome(configs);
                                break;
                            case "FIREFOX":
                                driver = WebDriverManager.firefox(configs);
                                break;
                            case "OPERA":
                                driver = WebDriverManager.opera(configs);
                                break;
                            case "IE":
                                driver = WebDriverManager.internetExplorer(configs);
                                break;
                            case "Edge":
                                driver = WebDriverManager.edge(configs);
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
