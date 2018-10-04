using TestAutomation.WebElements;
using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    class ElementGetter : IElementGetter
    {
        public IElement byClassName(string className)
        {
            return new Element(By.ClassName(className));
        }

        public IElement byName(string name)
        {
            return new Element(By.Name(name));
        }

        public IElement byXPath(string xPath)
        {
            return new Element(By.XPath(xPath));
        }

        public IElement byId(string id)
        {
            return new Element(By.Id(id));
        }
    }
}
