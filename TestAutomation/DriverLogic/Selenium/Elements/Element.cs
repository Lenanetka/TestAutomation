using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Element : WebDriverBase
    {
        public Element() : base()
        {

        }
        public IWebElement waitUntilIsVisible(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement waitUntilIsClickable(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        public IWebElement waitUntilExists(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }
    }
}