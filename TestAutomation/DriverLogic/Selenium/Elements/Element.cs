using OpenQA.Selenium;
using System.Collections.Generic;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Element : Base
    {
        public Element() : base()
        {

        }
        #region byLocator
        protected IWebElement waitUntilIsVisible(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }
        protected IWebElement waitUntilIsClickable(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }      
        protected IWebElement waitUntilExists(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }
        protected bool waitUntilTextPresent(By locator, string text)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementLocated(locator, text));
        }      
        public IWebElement getElementFromList(By locator, int index)
        {
            waitUntilIsVisible(locator);
            var elements = driver.FindElements(locator);
            return elements[index];
        }
        #endregion
        #region byElement
        protected IWebElement waitUntilIsClickable(IWebElement element)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }
        protected bool waitUntilTextPresent(IWebElement element, string text)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(element, text));
        }
        #endregion
    }
}