using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium
{
    public class SeleniumWebDriverListener
    {
        public virtual void throwExeption(object sender, WebDriverExceptionEventArgs e) { }
        public virtual void elementClicking(object sender, WebElementEventArgs e) { }
        public virtual void elementClicked(object sender, WebElementEventArgs e) { }
        public virtual void elementValueChanging(object sender, WebElementEventArgs e) { }
        public virtual void elementValueChanged(object sender, WebElementEventArgs e) { }
        public virtual void elementFinding(object sender, FindElementEventArgs e) { }
        public virtual void elementFound(object sender, FindElementEventArgs e) { }
        public virtual void navigating(object sender, WebDriverNavigationEventArgs e) { }
        public virtual void navigated(object sender, WebDriverNavigationEventArgs e) { }
        public virtual void navigatingBack(object sender, WebDriverNavigationEventArgs e) { }
        public virtual void navigatedBack(object sender, WebDriverNavigationEventArgs e) { }
        public virtual void navigatingForward(object sender, WebDriverNavigationEventArgs e) { }
        public virtual void navigatedForward(object sender, WebDriverNavigationEventArgs e) { }
        public virtual void scriptExecuting(object sender, WebDriverScriptEventArgs e) { }
        public virtual void scriptExecuted(object sender, WebDriverScriptEventArgs e) { }
    }
}
