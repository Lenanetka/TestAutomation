using OpenQA.Selenium.Support.Events;

namespace TestAutomation.Driver
{
    public class WebDriverDelays
    {
        public WebDriverDelays()
        {

        }
        private System.TimeSpan current;
        protected System.TimeSpan TimeOutFinding = System.TimeSpan.FromSeconds(3);
        protected System.TimeSpan TimeOutClicking = System.TimeSpan.FromSeconds(3);
        protected System.TimeSpan TimeOutValueChanging = System.TimeSpan.FromSeconds(3);
        protected System.TimeSpan TimeOutPageLoading = System.TimeSpan.FromSeconds(5);
        protected System.TimeSpan TimeOutScriptExecuting = System.TimeSpan.FromSeconds(5);

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
            setNewTimeout(TimeOutClicking);
        }
        public void elementFinding(object sender, FindElementEventArgs e)
        {
            setNewTimeout(TimeOutFinding);
        }
        public void elementValueChanging(object sender, WebElementEventArgs e)
        {
            setNewTimeout(TimeOutValueChanging);
        }
        public void navigating(object sender, WebDriverNavigationEventArgs e)
        {
            setNewTimeout(TimeOutPageLoading);
        }
        public void scriptExecuting(object sender, WebDriverScriptEventArgs e)
        {
            setNewTimeout(TimeOutScriptExecuting);
        }
    }
}
