using TestAutomation.DriverLogic;
using System;

namespace TestAutomation.WebElements
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
                    if (driver == null)
                    {
                        driver = new WebDriver();
                        driver.Logger = new WebDriverLoggerTxt(System.Environment.CurrentDirectory + @"/log.txt");
                        driver.Delays = new WebDriverTimeoutsStandart();
                    }
                }
            }
            return driver;
        }
    }
}
