namespace TestAutomation.WebElements
{
    public interface IField: IElement
    {
        void input(string input);
        void clear();
        string text();
    }
}
