using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using TestAutomation.WebElements;


namespace TestAutomation.DriverLogic.Selenium
{
    public abstract class SeleniumWebDriver: SeleniumWebDriverWaiter
    {
        [ThreadStatic]
        protected static EventFiringWebDriver driver;
        public void registerListener(SeleniumWebDriverListener listener)
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
        public SeleniumWebDriver(WebDriverConfigs configs) : base(configs)
        {
            wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(0));           
        }        
        public void dispose()
        {
            driver.Quit();
            driver = null;
        }
    }
}