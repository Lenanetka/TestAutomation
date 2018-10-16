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
                return InitialDriver.wait;
            }
        }
        public Base()
        {
            var initializer = new InitialDriver();
            driver = initializer.getInstance();
        }        
    }
}