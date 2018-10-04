using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    class ElementGetter
    {
        public Element byClassName(string className)
        {
            return new Element(By.ClassName(className));
        }

        public Element byName(string name)
        {
            return new Element(By.Name(name));
        }

        public Element byXPath(string xPath)
        {
            return new Element(By.XPath(xPath));
        }

        public Element byId(string id)
        {
            return new Element(By.Id(id));
        }
    
        public Element byCssSelector(string cssSelector)
        {
            return new Element(By.CssSelector(cssSelector));
        }
    }
}
