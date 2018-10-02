namespace TestAutomation.WebElements
{
    public interface IElement
    {
        void byId(string id);
        void byClassName(string className);
        void byXPath(string xPath);
        bool isVisible();
        bool isClickable();
        bool exists();
        void click();
    }
}
