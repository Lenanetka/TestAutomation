using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.Pages
{
    public abstract class PageMap
    {
        protected Browser browser = new Browser();
        protected Button button = new Button();
        protected ElementProperties elementProperties = new ElementProperties();
        protected Field field = new Field();
        protected Mouse mouse = new Mouse();
        protected JSExecuter jSExecuter = new JSExecuter();
        public PageMap()
        {   
        }  
    }
}
