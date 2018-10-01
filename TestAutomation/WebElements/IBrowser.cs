namespace TestAutomation.WebElements
{
    public interface IBrowser
    {
        IElement getElementById(string id);
        IElement getElementByClass(string className);
        IElement getElementByXPath(string xPath);
        string getCurrentUrl();
        void navigate(string url);
        void refresh();
        void navigateBack();
        void navigateForward();
    }
}
