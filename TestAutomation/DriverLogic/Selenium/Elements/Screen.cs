using OpenQA.Selenium;
using System;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Screen : Base
    {      
        private Screenshot screentshot;
        public Screen() : base()
        {
            
        }
        public void saveScreenshot()
        {
            getScreenshot(String.Format("screen{0:MM/dd/yyyy hh:mm:ss tt}.png", DateTime.Now.ToString()));
        }
    }
}
