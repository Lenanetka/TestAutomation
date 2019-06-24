using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using TestAutomation.DriverLogic.Selenium.Listeners;

namespace TestAutomation.DriverLogic.Selenium
{
    public abstract class Base
    {
        protected EventFiringWebDriver driver;      
        protected Waiter waiter;
        protected WebDriverWait wait
        {
            get
            {
                return InitialDriver.wait;
            }
        }
        public Base()
        {
            var initializer = new InitialDriver();
            driver = initializer.getInstance();
        }
        public void waitUntilScriptsFinished()
        {
            wait.Until(wd => ((IJavaScriptExecutor)wd).ExecuteScript("return (document.readyState == 'complete')"));
            if ((bool)((IJavaScriptExecutor)driver).ExecuteScript("return window.jQuery != undefined"))
                wait.Until(wd => ((IJavaScriptExecutor)wd).ExecuteScript("return (jQuery.active == 0)"));
        }       
        public void getScreenshot(string path)
        {
            Screenshot screentshot = driver.GetScreenshot();
            screentshot.SaveAsFile(path);
            //initializer.OnSavingScreenshot(path);
        }
    }
}