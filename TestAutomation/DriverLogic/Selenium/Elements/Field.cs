using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Field : Element
    {
        public Field(By locator) : base(locator)
        {
        }
        public void input(string input)
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists);
            element.SendKeys(input);
        }
        public void clear()
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists);
            element.Clear();
        }
        public string text()
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible);
            return element.Text;
        }
    }
}
