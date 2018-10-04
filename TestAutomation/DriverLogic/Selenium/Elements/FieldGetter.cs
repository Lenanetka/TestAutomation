using TestAutomation.WebElements;
using OpenQA.Selenium;

namespace TestAutomation.DriverLogic.Selenium.Elements
{
    class FieldGetter : IFieldGetter
    {
        public IField byClassName(string className)
        {
            return new Field(By.ClassName(className));
        }

        public IField byName(string name)
        {
            return new Field(By.Name(name));
        }

        public IField byXPath(string xPath)
        {
            return new Field(By.XPath(xPath));
        }

        public IField byId(string id)
        {
            return new Field(By.Id(id));
        }
    }
}
