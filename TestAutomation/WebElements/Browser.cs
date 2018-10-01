using TestAutomation.DriverLogic;
namespace TestAutomation.WebElements
{
    public class Browser
    {
        private IWebDriverWindow window;
        public Browser()
        {
            //use initial driver
        }
        public Element getElement()
        {
            return new Element();
        }
    }
}
