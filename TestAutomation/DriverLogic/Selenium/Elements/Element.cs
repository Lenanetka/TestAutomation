using OpenQA.Selenium;
using System;
using TestAutomation.WebElements;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Element : WebDriverBase, IElement
    {
        protected By locator;
        public Element(By locator) : base()
        {
            this.locator = locator;
        }
        protected delegate System.Func<IWebDriver, IWebElement> ExpectedConditionsFunc(By locator);
        protected IWebElement getElement(ExpectedConditionsFunc func)
        {
            IWebElement element;
            do
            {
                element = wait.Until(func(locator));
            }
            while (element == null);
            return element;
        }
        public bool isVisible()
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible);
            return true;
        }

        public bool isClickable()
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable);
            return true;
        }

        public bool exists()
        {
            throw new NotImplementedException();
        }
        public void click()
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable);
            element.Click();
        }
    }
}