namespace TestAutomation.WebElements
{
    public interface IElement
    {       
        bool isVisible(string xPath);
        bool isClickable(string xPath);
        bool exists(string xPath);
        void click(string xPath);
    }
}
