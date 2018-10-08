using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using TestAutomation.DriverLogic.Selenium.Initialize;

namespace TestAutomation.DriverLogic.Selenium
{
    public abstract class Base
    {
        protected EventFiringWebDriver driver;      
        protected Waiter waiter;
        protected WebDriverWait wait
        {
            get
            {
                return waiter.wait;
            }
        }
        public void registerListener(IListener listener)
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
        public Base()
        {
            driver = new InitialDriver().getInstance();
            waiter = new Waiter(driver, InitialDriver.configs.timeouts);
            registerListener(waiter);
        }        
    }
}