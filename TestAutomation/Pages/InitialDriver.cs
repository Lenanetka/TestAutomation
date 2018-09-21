using OpenQA.Selenium;
using TestAutomation.Driver;
using System;

namespace TestAutomation.Pages
{
    static class InitialDriver
    {
        private static WebDriver driver;
        private static Object thisLock = new Object();
        public static WebDriver getInstance()
        {
            if (driver == null)
            {
                lock (thisLock)
                {
                    //Прочитала, что нужно двойную проверку на всякий случай делать, вдруг 2 потока одновременно до этого убедились, что driver=null и встали в очередь
                    if (driver == null)
                    {
                        driver = new WebDriver();
                        driver.Logger = new WebDriverLoggerTxt(System.Environment.CurrentDirectory + @"/log.txt");
                        driver.Delays = new WebDriverDelays();
                    }
                }
            }
            return driver;
        }
    }
}
