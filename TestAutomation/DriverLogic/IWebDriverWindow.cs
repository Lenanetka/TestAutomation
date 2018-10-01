namespace TestAutomation.DriverLogic
{
    public interface IWebDriverWindow
    {
        string getCurrentUrl();
        void navigate(string url);
        void refresh();
        void navigateBack();
        void navigateForward();
    }
}
