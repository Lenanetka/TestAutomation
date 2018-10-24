﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
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
            wait.Until(wd => ((IJavaScriptExecutor)wd).ExecuteScript("return (document.readyState == 'complete' && jQuery.active == 0)"));
        }
    }
}