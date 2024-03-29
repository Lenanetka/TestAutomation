﻿using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    public class Button : Element
    {
        public Button() : base()
        {
        }
        public void click(By locator)
        {
            waitUntilIsClickable(locator).Click();
            waitUntilScriptsFinished();
        }
        public void click(IWebElement element)
        {
            waitUntilIsClickable(element).Click();
            waitUntilScriptsFinished();
        }
    }
}
