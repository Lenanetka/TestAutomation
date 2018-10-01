using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.WebElements
{
    public abstract class PageMap
    {
        protected Browser browser;
        public PageMap()
        {
            browser = new Browser(); 
        }        
    }
}
