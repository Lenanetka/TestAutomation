using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.WebElements;

namespace TestAutomation.NUnitTests.PageMaps
{
    class LoginPageMap : PageMap
    {
        public Element NameField
        {
            get
            {
                return browser.getElement().byId("1");
            }
        }
    }
}
