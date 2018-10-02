using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;

namespace TestAutomation.DriverLogic.Selenium
{
    public abstract class WebDriverWaiter: WebDriverListener
    {              
        protected WebDriverTimeouts timeouts;
        public WebDriverWait wait;
        public WebDriverWaiter(WebDriverConfigs configs)
        {
            this.timeouts = configs.timeouts;
        }
        private System.TimeSpan current;       
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
