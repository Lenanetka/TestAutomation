using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.PageMaps
{
    public abstract class PageMap
    {
        protected Browser browser;
        public PageMap()
        {
            browser = new Browser();   
        }  
        public void closeBrowser()
        {
            browser.close();
        }
    }
}
