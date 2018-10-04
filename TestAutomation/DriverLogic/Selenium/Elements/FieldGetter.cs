using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    class FieldGetter
    {
        public Field byClassName(string className)
        {
            return new Field(By.ClassName(className));
        }

        public Field byName(string name)
        {
            return new Field(By.Name(name));
        }

        public Field byXPath(string xPath)
        {
            return new Field(By.XPath(xPath));
        }

        public Field byId(string id)
        {
            return new Field(By.Id(id));
        }

        public Field byCssSelector(string cssSelector)
        {
            return new Field(By.CssSelector(cssSelector));
        }
    }
}
