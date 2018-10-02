namespace TestAutomation.WebElements
{
    public interface IBrowser
    {
        IElement getElement();
        string getCurrentUrl();
        void navigate(string url);
        void refresh();
        void navigateBack();
        void navigateForward();
    }
}
