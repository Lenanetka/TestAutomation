using TestAutomation.WebElements;

namespace TestAutomation.PageMaps
{
    public abstract class PageMap
    {
        public IBrowser browser;
        public PageMap()
        {
            browser = new TestAutomation.DriverLogic.Selenium.Elements.Browser(); 
        }        
    }
}
