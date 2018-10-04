using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.PageMaps
{
    public abstract class PageMap
    {
        public Browser browser;
        public PageMap()
        {
            browser = new TestAutomation.DriverLogic.InitialBrowser().getInstance();             
        }        
    }
}
