using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;


//нужно чтобы ожидания более явно задавались, чтобы их не приходилось искать
//драйвер должен быть приватным (чтобы его никто не мог использовать), драйвер в обертке не катит
namespace TestAutomation.DriverLogic
{
    public class WebDriver : WebDriverSettings
    {
        private EventFiringWebDriver driver;
        private WebDriverLogger logger;
        private WebDriverTimeouts delays;
        public WebDriverLogger Logger
        {
            set
            {
                logger = value;
                driver.ExceptionThrown += new EventHandler<WebDriverExceptionEventArgs>(logger.throwExeption);
                driver.ElementClicked += new EventHandler<WebElementEventArgs>(logger.elementClicked);
                driver.FindElementCompleted += new EventHandler<FindElementEventArgs>(logger.findElementCompleted);
                driver.Navigated += new EventHandler<WebDriverNavigationEventArgs>(logger.navigated);
                driver.ElementValueChanged += new EventHandler<WebElementValueEventArgs>(logger.elementValueChanged);
            }
        }
        public WebDriverTimeouts Delays
        {
            set
            {
                delays = value;
                driver.ElementClicking += new EventHandler<WebElementEventArgs>(delays.elementClicking);
                driver.FindingElement += new EventHandler<FindElementEventArgs>(delays.elementFinding);
                driver.Navigating += new EventHandler<WebDriverNavigationEventArgs>(delays.navigating);
                driver.ElementValueChanging += new EventHandler<WebElementValueEventArgs>(delays.elementValueChanging);
                driver.ScriptExecuting += new EventHandler<WebDriverScriptEventArgs>(delays.scriptExecuting);
                delays.TimeoutChangedEvent += changeWebDriverWaitTimeout;
            }
        }
        public WebDriver()
        {
            driver = new EventFiringWebDriver(new ChromeDriver(path, options));
            wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(0));
        }
        public void Dispose()
        {
            driver.Quit();
            driver = null;
        }
        private void waitUntilScriptsFinished()
        {
            wait.Until(wd => ((IJavaScriptExecutor)wd).ExecuteScript("return (document.readyState == 'complete' && jQuery.active == 0)"));
        }
        public void goToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            waitUntilScriptsFinished();
        }
        public bool pageIsOpened(string url)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(url));
        }
        public void refreshPage()
        {
            driver.Navigate().Refresh();
            waitUntilScriptsFinished();
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