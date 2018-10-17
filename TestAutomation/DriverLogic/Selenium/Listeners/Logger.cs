﻿using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic.Selenium.Listeners
{
    public class Logger: Listener
    {
        public delegate void OnLog(bool positive, string action, string message);
        public event OnLog LogEvent;
        public void log(bool positive, string action, string message)
        {
            //LogEvent(positive, action, message);
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
            log(true, "Element value is changed", e.Element.GetAttribute("value"));
        }
        public override void navigated(object sender, WebDriverNavigationEventArgs e)
        {
            log(true, "Navigated to URL", e.Url.ToString());
        }
    }
}