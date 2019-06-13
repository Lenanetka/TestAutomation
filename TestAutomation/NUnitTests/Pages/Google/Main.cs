using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.Pages.Google
{
    public class Main : PageMap
    {
        public static string url = "https://www.google.com/";
        #region locators
        private By SearchField = By.CssSelector("#tsf > div:nth-child(2) input");
        private By SearchButton = By.CssSelector("#tsf > div:nth-child(2) center > input.gNO89b");

        #endregion
        public Main() : base()
        {
            
        }
        #region actions
        public void search(string text)
        {
            field.input(SearchField, text);
            button.click(SearchButton);
            StringAssert.StartsWith(Search.url, browser.getCurrentUrl());
        }
        #endregion
        #region tests
        public void Test_Search()
        {
            browser.navigate(url);
            search("cat");
        }
        #endregion
    }
}
