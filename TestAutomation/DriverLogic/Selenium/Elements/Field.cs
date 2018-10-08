using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Field : Element
    {
        public Field() : base()
        {
        }
        public void input(By locator, string input)
        {
            IWebElement element = waitUntilIsClickable(locator);
            element.Clear();
            element.SendKeys(input);
        }
        public void clear(By locator)
        {
            waitUntilIsClickable(locator).Clear();
        }
        public string getText(By locator)
        {
            return waitUntilIsClickable(locator).Text;
        }
    }
}
