using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;
using System;


namespace TestAutomation.DriverLogic.Selenium
{
    public class SeleniumWebDriverManager: SeleniumWebDriverWaiter, IWebDriverManager
    {
        [ThreadStatic]
        protected static EventFiringWebDriver driver;
        public void registerListener(SeleniumWebDriverListener listener)
        {
            driver.ElementClicking += listener.elementClicking;
            driver.ElementClicked += listener.elementClicked;
            driver.ElementValueChanging += listener.elementValueChanging;
            driver.ElementValueChanged += listener.elementValueChanged;
            driver.FindingElement += listener.elementFinding;
            driver.FindElementCompleted += listener.elementFound;
            driver.Navigating += listener.navigating;
            driver.Navigated += listener.navigated;
            driver.NavigatingBack += listener.navigatingBack;
            driver.NavigatedBack += listener.navigatedBack;
            driver.NavigatingForward += listener.navigatingForward;
            driver.NavigatedForward += listener.navigatedForward;
            driver.ScriptExecuting += listener.scriptExecuting;
            driver.ScriptExecuted += listener.scriptExecuted;
            driver.ExceptionThrown += listener.throwExeption;
        }
        public SeleniumWebDriverManager(WebDriverConfigs configs) : base(configs)
        {
            wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(0));           
        }
        public void setup()
        {
            string path = config.PATH;
            if (config.VERSION != null && config.VERSION != "") path += config.VERSION + @"\";
            switch (config.DRIVER)
            {
                case "CHROME":
                    driver = new EventFiringWebDriver(new ChromeDriver(path, SeleniumWebDriverOptions.chromeOptions(config)));
                    break;
                case "FIREFOX":
                    driver = new EventFiringWebDriver(new FirefoxDriver(path, SeleniumWebDriverOptions.firefoxOptions(config)));
                    break;
                case "OPERA":
                    driver = new EventFiringWebDriver(new OperaDriver(path, SeleniumWebDriverOptions.operaOptions(config)));
                    break;
                case "IE":
                    {
                        driver = new EventFiringWebDriver(new InternetExplorerDriver(path, SeleniumWebDriverOptions.internetExplorerOptions(config)));
                        if (config.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
                        break;
                    }
                case "Edge":
                    driver = new EventFiringWebDriver(new EdgeDriver(path, SeleniumWebDriverOptions.edgeOptions(config)));
                    if (config.START_MAXIMIZED == true) driver.Manage().Window.Maximize();
                    break;
            }
        }
        public void dispose()
        {
            driver.Quit();
            driver = null;
        }

        public string getCurrentUrl()
        {
            return driver.Url;
        }
        public void navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
            waitUntilScriptsFinished();
        }
        public void refresh()
        {
            driver.Navigate().Refresh();
            waitUntilScriptsFinished();
        }
        public void navigateBack()
        {
            driver.Navigate().Back();
            waitUntilScriptsFinished();
        }
        public void navigateForward()
        {
            driver.Navigate().Forward();
            waitUntilScriptsFinished();
        }
        private void waitUntilScriptsFinished()
        {
            wait.Until(wd => ((IJavaScriptExecutor)wd).ExecuteScript("return (document.readyState == 'complete' && jQuery.active == 0)"));
        }      



        public bool pageIsOpened(string url)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(url));
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