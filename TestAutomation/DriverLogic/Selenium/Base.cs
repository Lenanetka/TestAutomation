using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using TestAutomation.DriverLogic.Selenium.Listeners;

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
        public Base()
        {
            var initializer = new InitialDriver();
            driver = initializer.getInstance();
            waiter = new Waiter(driver, InitialDriver.configs.timeouts);
            initializer.registerListener(waiter);
        }        
    }
}