using OpenQA.Selenium.Support.Events;
using System;

namespace TestAutomation.DriverLogic.Selenium.Listeners
{
    public class Logger: Listener
    {
        public void log(bool positive, string action, string message)
        {
            Console.WriteLine(String.Format("[{0:d/M/yyyy HH:mm:ss}][{1}]{2}: {3}", DateTime.Now, positive ? "Success" : "Fail",action, message));           
        }
        public void log(bool positive, string action)
        {
            Console.WriteLine(String.Format("[{0:d/M/yyyy HH:mm:ss}][{1}]{2}", DateTime.Now, positive ? "Success" : "Fail", action));
        }
        public override void throwExeption(object sender, WebDriverExceptionEventArgs e)
        {
            log(false, "Exception", e.ThrownException.Message);
        }
        public override void elementClicked(object sender, WebElementEventArgs e)
        {
            log(true, "Element is clicked", e.Element.ToString());
        }
        public override void elementFound(object sender, FindElementEventArgs e)
        {
            log(true, "Element is found", e.FindMethod.ToString());
        }
        public override void elementValueChanged(object sender, WebElementEventArgs e)
        {
            if(e.Element.GetAttribute("value")=="") log(true, "Element value is cleared");
            else log(true, "Element value is changed", e.Element.GetAttribute("value"));
        }
        public override void navigated(object sender, WebDriverNavigationEventArgs e)
        {
            log(true, "Navigated to URL", e.Url.ToString());
        }
    }
}
