using OpenQA.Selenium;
using TestAutomation.Driver;
using System;

namespace TestAutomation.Pages
{
    public abstract class Page
    {
        protected string container;
        protected WebDriver driver = InitialDriver.getInstance();
        protected string pageThis;
        public string url
        {
            get
            {
                return Portal.getBaseURL(container) + pageThis;
            }
        }
        public void closeBrowser()
        {
            driver.Dispose();
        }
        public abstract void toStartPosition();
        public Page(string container)
        {
            this.container = container;
        }
    }
}
