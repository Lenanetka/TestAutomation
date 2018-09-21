using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic
{
    public abstract class WebDriverTimeouts
    {
        private System.TimeSpan current;
        protected System.TimeSpan TIME_OUT_FINDING;
        protected System.TimeSpan TIME_OUT_CLICKING;
        protected System.TimeSpan TIME_OUT_VALUE_CHANGING;
        protected System.TimeSpan TIME_OUT_PAGE_LOADING;
        protected System.TimeSpan TIME_OUT_SCRIPT_EXECUTING;

        public delegate void OnTimeoutChanged(System.TimeSpan timeout);
        public event OnTimeoutChanged TimeoutChangedEvent;

        private void setNewTimeout(System.TimeSpan timeout)
        {
            if (current != timeout)
            {
                current = timeout;
                TimeoutChangedEvent(current);
            }
        }
        public void elementClicking(object sender, WebElementEventArgs e)
        {
            setNewTimeout(TIME_OUT_CLICKING);
        }
        public void elementFinding(object sender, FindElementEventArgs e)
        {
            setNewTimeout(TIME_OUT_FINDING);
        }
        public void elementValueChanging(object sender, WebElementEventArgs e)
        {
            setNewTimeout(TIME_OUT_VALUE_CHANGING);
        }
        public void navigating(object sender, WebDriverNavigationEventArgs e)
        {
            setNewTimeout(TIME_OUT_PAGE_LOADING);
        }
        public void scriptExecuting(object sender, WebDriverScriptEventArgs e)
        {
            setNewTimeout(TIME_OUT_SCRIPT_EXECUTING);
        }
    }
}
