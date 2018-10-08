using OpenQA.Selenium;

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
    }
}