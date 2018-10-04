namespace TestAutomation.WebElements
{
    public interface IElementGetter
    {
        IElement byId(string id);
        IElement byName(string name);
        IElement byClassName(string className);
        IElement byXPath(string xPath);
    }
}
