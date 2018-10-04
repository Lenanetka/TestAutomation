using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Element : WebDriverBase
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
            return element.Displayed;
        }

        public bool isClickable()
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable);
            return element.Enabled;
        }

        public bool exists()
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists);
            if(element != null) return true;
            return false;
        }
        public void click()
        {
            IWebElement element = getElement(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable);
            element.Click();
        }
    }
}