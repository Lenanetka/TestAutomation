using TestAutomation.DriverLogic;

namespace TestAutomation.WebElements
{
    public abstract class Page: Element
    {
        protected string container;
        protected string pageThis;
        public string url
        {
            get
            {
                return Portal.getBaseURL(container) + pageThis;
            }
        }
        public void closeBrowser()
        {
            driver.Dispose();
        }
        public abstract void toStartPosition();
        public Page(string container)
        {
            this.container = container;
        }
    }
}
