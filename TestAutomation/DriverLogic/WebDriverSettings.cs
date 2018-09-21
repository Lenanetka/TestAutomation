using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestAutomation.DriverLogic
{
    public abstract class WebDriverSettings
    {
        protected String path = @"c:\Drivers\web\chrome\";
        protected WebDriverWait wait;
        protected ChromeOptions options
        {
            get
            {
                ChromeOptions opt = new ChromeOptions();
                opt.AddArgument("--start-maximized");
                return opt;
            }
        }
        protected void changeWebDriverWaitTimeout(System.TimeSpan timeout)
        {
            wait.Timeout = timeout;
        }
    }
}
