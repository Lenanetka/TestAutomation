using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using TestAutomation.WebElements;


namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Browser : WebDriverBase, IBrowser
    {
        public Browser() : base()
        {

        }
        public IElement getElement()
        {
            return new Element();
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