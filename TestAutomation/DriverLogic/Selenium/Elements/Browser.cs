using OpenQA.Selenium;
using System.Collections.Generic;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Browser : Base
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
        }
        public void refresh()
        {
            driver.Navigate().Refresh();
        }
        public void navigateBack()
        {
            driver.Navigate().Back();
        }
        public void navigateForward()
        {
            driver.Navigate().Forward();
        }
        public void waitUntilScriptsFinished()
        {
            wait.Until(wd => ((IJavaScriptExecutor)wd).ExecuteScript("return (document.readyState == 'complete' && jQuery.active == 0)"));
        }
        public void close()
        {
            new InitialDriver().destroy();
        }
        public void switchToTab(int index)
        {
            string tab = driver.WindowHandles[index];
            driver.SwitchTo().Window(tab);
        }
        public void switchToFirstTab()
        {
            switchToTab(0);
        }
        public void switchToLastTab()
        {
            switchToTab(driver.WindowHandles.Count - 1);
        }
    }
}