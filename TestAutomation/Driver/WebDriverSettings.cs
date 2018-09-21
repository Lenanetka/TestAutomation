using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestAutomation.Driver
{
    public abstract class WebDriverSettings
    {
        protected String Path = @"c:\Drivers\web\chrome\";
        protected WebDriverWait wait;
        protected ChromeOptions Options
        {
            get
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                return options;
            }
        }
        protected void changeWebDriverWaitTimeout(System.TimeSpan timeout)
        {
            wait.Timeout = timeout;
        }
    }
}
