using OpenQA.Selenium.Support.Events;
using TestAutomation.Report;

namespace TestAutomation.DriverLogic.Selenium
{
    public class Logger: Report.Logger, IListener
    {
        public void throwExeption(object sender, WebDriverExceptionEventArgs e)
        {
            log(false, "Exception", e.ThrownException.Message);
        }
        public void elementClicked(object sender, WebElementEventArgs e)
        {
            log(true, "Element is clicked", e.Element.ToString());
        }
        public void elementFound(object sender, FindElementEventArgs e)
        {
            log(true, "Element is found", e.FindMethod.ToString());
        }
        public void elementValueChanged(object sender, WebElementEventArgs e)
        {
            log(true, "Element value is changed", e.Element.GetAttribute("value"));
        }
        public void navigated(object sender, WebDriverNavigationEventArgs e)
        {
            log(true, "Navigated to URL", e.Url.ToString());
        }
        #region empty
        public void elementClicking(object sender, WebElementEventArgs e)
        {

        }

        public void elementValueChanging(object sender, WebElementEventArgs e)
        {

        }
        public void elementFinding(object sender, FindElementEventArgs e)
        {

        }
        public void navigating(object sender, WebDriverNavigationEventArgs e)
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
        public void scriptExecuting(object sender, WebDriverScriptEventArgs e)
        {

        }
        public void scriptExecuted(object sender, WebDriverScriptEventArgs e)
        {

        }
        #endregion
    }
}
