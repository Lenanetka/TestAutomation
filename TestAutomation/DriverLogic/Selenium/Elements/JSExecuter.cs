using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class JSExecuter : Element
    {
        public JSExecuter() : base()
        {
        }
        public void scrollToNecessaryElement(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0," + element.Location.Y + ")");
        }

        public void scrollToNecessaryElement(By locator)
        {
            IWebElement element = waitUntilIsClickable(locator);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0," + element.Location.Y + ")");
        }
    }
}
