using OpenQA.Selenium.Support.Events;
using System;

namespace TestAutomation.DriverLogic.Selenium.Initialize
{
    class InitialDriver: WebDriverManager
    {
        private static EventFiringWebDriver driver;
        private static Object thisLock = new Object();       
        public EventFiringWebDriver getInstance()
        {           
            if (driver == null)
            {                
                lock (thisLock)
                {                    
                    if (driver == null)
                    {
                        configs = new Configs(Environment.CurrentDirectory + @"\configs.ini");
                        switch (configs.DRIVER)
                        {
                            case "CHROME":
                                driver = chromeDriver();
                                break;
                            case "FIREFOX":
                                driver = firefoxDriver();
                                break;
                            case "OPERA":
                                driver = operaDriver();
                                break;
                            case "IE":
                                driver = internetExplorerDriver();
                                break;
                            case "Edge":
                                driver = edgeDriver();
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
