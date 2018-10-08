using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;

namespace TestAutomation.DriverLogic.Selenium.Listeners
{
    public class Waiter: Listener
    {              
        private Timeouts timeouts;
        public WebDriverWait wait;
        private System.TimeSpan current; 
        public Waiter(EventFiringWebDriver driver, Timeouts timeouts)
        {
            wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(0));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            this.timeouts = timeouts;
        }
        private void setNewTimeout(System.TimeSpan timeout)
        {
            if (current != timeout)
            {
                current = timeout;
                wait.Timeout = timeout;
            }
        }
        public override void elementClicking(object sender, WebElementEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_CLICKING);
        }
        public override void elementFinding(object sender, FindElementEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_FINDING);
        }
        public override void elementValueChanging(object sender, WebElementEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_VALUE_CHANGING);
        }
        public override void navigating(object sender, WebDriverNavigationEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_PAGE_LOADING);
        }
        public override void scriptExecuting(object sender, WebDriverScriptEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_SCRIPT_EXECUTING);
        }
    }
}
