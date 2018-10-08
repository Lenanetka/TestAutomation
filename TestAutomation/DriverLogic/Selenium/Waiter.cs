using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;

namespace TestAutomation.DriverLogic.Selenium
{
    public class Waiter: IListener
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
        public void elementClicking(object sender, WebElementEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_CLICKING);
        }
        public void elementFinding(object sender, FindElementEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_FINDING);
        }
        public void elementValueChanging(object sender, WebElementEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_VALUE_CHANGING);
        }
        public void navigating(object sender, WebDriverNavigationEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_PAGE_LOADING);
        }
        public void scriptExecuting(object sender, WebDriverScriptEventArgs e)
        {
            setNewTimeout(timeouts.TIME_OUT_SCRIPT_EXECUTING);
        }
        #region empty
        public void throwExeption(object sender, WebDriverExceptionEventArgs e)
        {
            
        }
        public void elementClicked(object sender, WebElementEventArgs e)
        {
            
        }
        public void elementValueChanged(object sender, WebElementEventArgs e)
        {
            
        }
        public void elementFound(object sender, FindElementEventArgs e)
        {
            
        }
        public void navigated(object sender, WebDriverNavigationEventArgs e)
        {
            
        }
        public void navigatingBack(object sender, WebDriverNavigationEventArgs e)
        {
            
        }
        public void navigatedBack(object sender, WebDriverNavigationEventArgs e)
        {
            
        }
        public void navigatingForward(object sender, WebDriverNavigationEventArgs e)
        {
            
        }
        public void navigatedForward(object sender, WebDriverNavigationEventArgs e)
        {
            
        }
        public void scriptExecuted(object sender, WebDriverScriptEventArgs e)
        {
            
        }
        #endregion
    }
}
