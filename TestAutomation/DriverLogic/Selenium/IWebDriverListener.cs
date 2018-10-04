using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium
{
    public interface IWebDriverListener
    {
        void throwExeption(object sender, WebDriverExceptionEventArgs e);
        void elementClicking(object sender, WebElementEventArgs e);
        void elementClicked(object sender, WebElementEventArgs e);
        void elementValueChanging(object sender, WebElementEventArgs e);
        void elementValueChanged(object sender, WebElementEventArgs e);
        void elementFinding(object sender, FindElementEventArgs e);
        void elementFound(object sender, FindElementEventArgs e);
        void navigating(object sender, WebDriverNavigationEventArgs e);
        void navigated(object sender, WebDriverNavigationEventArgs e);
        void navigatingBack(object sender, WebDriverNavigationEventArgs e);
        void navigatedBack(object sender, WebDriverNavigationEventArgs e);
        void navigatingForward(object sender, WebDriverNavigationEventArgs e);
        void navigatedForward(object sender, WebDriverNavigationEventArgs e);
        void scriptExecuting(object sender, WebDriverScriptEventArgs e);
        void scriptExecuted(object sender, WebDriverScriptEventArgs e);
    }
}
