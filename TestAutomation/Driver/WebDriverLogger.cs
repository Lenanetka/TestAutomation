using System;
using OpenQA.Selenium.Support.Events;

namespace TestAutomation.Driver
{
    public abstract class WebDriverLogger
    {
        public string getCurrentTime()
        {
            return DateTime.Now.ToString("[dd/MM/yyyy hh:mm:ss]: ");
        }
        public abstract void writeLine(string line);
        public void throwExeption(object sender, WebDriverExceptionEventArgs e)
        {
            writeLine("Exception: " + e.ThrownException.Message);
        }
        public void elementClicked(object sender, WebElementEventArgs e)
        {
            writeLine("Element is clicked: " + e.Element.ToString());
        }
        public void findElementCompleted(object sender, FindElementEventArgs e)
        {
            writeLine("Element is found: " + e.FindMethod.ToString());
        }
        public void elementValueChanged(object sender, WebElementEventArgs e)
        {
            writeLine("Element value is changed to: " + e.Element.GetAttribute("value"));
        }
        public void navigated(object sender, WebDriverNavigationEventArgs e)
        {
            writeLine("Navigated to URL: " + e.Url.ToString());
        }
    }
}
