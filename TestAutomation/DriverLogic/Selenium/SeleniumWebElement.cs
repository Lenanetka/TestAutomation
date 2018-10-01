using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using TestAutomation.WebElements;


namespace TestAutomation.DriverLogic.Selenium
{
    public class SeleniumWebElement : IElement
    {        
        public SeleniumWebElement()
        {
            
        }
        delegate System.Func<IWebDriver, IWebElement> ExpectedConditionsFunc(By locator);
        private IWebElement getElement(ExpectedConditionsFunc func, By locator)
        {
            IWebElement element;
            do
            {
                element = wait.Until(func(locator));
            }
            while (element == null);
            return element;
        }
        public bool elementIsVisible(By locator)
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible, locator);
            return true;
        }
        public bool elementIsClickable(By locator)
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable, locator);
            return true;
        }
        public void inputIntoElement(By locator, string input)
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, locator);
            element.SendKeys(input);
        }
        public void clearElement(By locator)
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists, locator);
            element.Clear();
        }
        public void clickOnElement(By locator)
        {
            IWebElement element = getElement(ExpectedConditions.ElementToBeClickable, locator);
            element.Click();
        }
        public string elementText(By locator)
        {
            IWebElement element = getElement(ExpectedConditions.ElementIsVisible, locator);
            return element.Text;
        }
    }
}