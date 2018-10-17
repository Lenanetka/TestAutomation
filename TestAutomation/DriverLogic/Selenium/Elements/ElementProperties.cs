using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class ElementProperties : Element
    {
        public ElementProperties() : base()
        {
        }
        public string getAttribute(By locator, string attributeName)
        {
            return waitUntilIsClickable(locator).GetAttribute(attributeName);
        }

        public bool isPresent(By locator)
        {
            try
            {
                waitUntilExists(locator);
                return true;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
            catch (WebDriverTimeoutException ex)
            {
                return false;
            }
        }
        public bool isDisplayed(By locator)
        {

            return waitUntilIsVisible(locator).Displayed;
        }
        public bool isEnabled(By locator)
        {
            return waitUntilIsClickable(locator).Enabled;
        }
        public bool isSelected(By locator)
        {
            return waitUntilExists(locator).Selected;
        }
        public string getText(By locator)
        {
            return waitUntilIsVisible(locator).Text;
        }
        public int getListCount(By locator)
        {
            waitUntilIsVisible(locator);
            return driver.FindElements(locator).Count;
        }
    }
}
