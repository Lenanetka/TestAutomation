using TestAutomation.WebElements;

namespace TestAutomation.PageMaps
{
    class LoginPageMap : PageMap
    {
        public IElement NameField
        {
            get
            {
                return browser.getElementById("1");
            }
        }
    }
}
