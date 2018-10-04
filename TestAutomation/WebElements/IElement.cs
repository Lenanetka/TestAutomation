namespace TestAutomation.WebElements
{
    public interface IElement
    {       
        bool isVisible();
        bool isClickable();
        bool exists();
        void click();
    }
}
