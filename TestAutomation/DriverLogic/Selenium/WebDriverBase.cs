using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using TestAutomation.DriverLogic.Selenium.Initialize;

namespace TestAutomation.DriverLogic.Selenium
{
    public abstract class WebDriverBase
    {
        protected EventFiringWebDriver driver;      
        protected WebDriverWaiter waiter;
        protected WebDriverWait wait
        {
            get
            {
                return waiter.wait;
            }
        }
        public void registerListener(IWebDriverListener listener)
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
        public WebDriverBase()
        {
            driver = new InitialDriver().getInstance();
            waiter = new WebDriverWaiter(driver, InitialDriver.configs.timeouts);
            registerListener(waiter);
        }        
    }
}