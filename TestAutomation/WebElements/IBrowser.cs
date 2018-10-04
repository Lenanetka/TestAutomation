namespace TestAutomation.WebElements
{
    public interface IBrowser
    {
        IElementGetter getElement();
        IFieldGetter getField();
        string getCurrentUrl();
        void navigate(string url);
        void refresh();
        void navigateBack();
        void navigateForward();
    }
}
