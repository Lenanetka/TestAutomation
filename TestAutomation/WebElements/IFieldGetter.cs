namespace TestAutomation.WebElements
{
    public interface IFieldGetter
    {
        IField byId(string id);
        IField byName(string name);
        IField byClassName(string className);
        IField byXPath(string xPath);
    }
}
