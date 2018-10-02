using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using TestAutomation.DriverLogic.Selenium.Initialize;

namespace TestAutomation.DriverLogic.Selenium
{
    public abstract class WebDriverBase: WebDriverWaiter
    {
        protected EventFiringWebDriver driver;
        public void registerListener(WebDriverListener listener)
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
        public WebDriverBase()
        {
            WebDriverConfigs configs = new WebDriverConfigs("configs.ini");
            this.timeouts = configs.timeouts;
            driver = new InitialDriver().getInstance(configs);
            wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(0));             
        }        
        public void dispose()
        {
            driver.Quit();
            driver = null;
        }
    }
}