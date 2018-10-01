namespace TestAutomation.DriverLogic
{
    public interface IWebDriverElement
    {      
        bool isVisible(string xPath);
        bool isClickable(string xPath);
        bool exists(string xPath);
        void click(string xPath);
    }
}
