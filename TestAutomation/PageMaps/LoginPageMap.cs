TestAutomation.DriverLogic;

namespace TestAutomation.PageMaps
{
    class LoginPageMap : PageMap
    {
        public IElement NameField
        {
            get
            {
                return browser.getElement().byId("1");
            }
        }
    }
}
