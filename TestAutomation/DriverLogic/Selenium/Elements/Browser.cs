using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;


namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Browser : WebDriverBase
    {
        public Browser() : base()
        {

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
    }
}