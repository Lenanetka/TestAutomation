using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using TestAutomation.DriverLogic.Selenium.Listeners;

namespace TestAutomation.DriverLogic.Selenium
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
        public void destroy()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }       
        public void registerListener(Listener listener)
        {
            driver.ElementClicking += listener.elementClicking;
            driver.ElementClicked += listener.elementClicked;
            driver.ElementValueChanging += listener.elementValueChanging;
            driver.ElementValueChanged += listener.elementValueChanged;
            driver.FindingElement += listener.elementFinding;
            driver.FindElementCompleted += listener.elementFound;
            driver.Navigating += listener.navigating;
            driver.Navigated += listener.navigated;
            driver.NavigatingBack += listener.navigatingBack;
            driver.NavigatedBack += listener.navigatedBack;
            driver.NavigatingForward += listener.navigatingForward;
            driver.NavigatedForward += listener.navigatedForward;
            driver.ScriptExecuting += listener.scriptExecuting;
            driver.ScriptExecuted += listener.scriptExecuted;
            driver.ExceptionThrown += listener.throwExeption;
        }
    }
}
