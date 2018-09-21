using OpenQA.Selenium.Support.Events;

namespace TestAutomation.DriverLogic
{
    public class WebDriverTimeoutsStandart: WebDriverTimeouts
    {
        public WebDriverTimeoutsStandart()
        {
            TIME_OUT_FINDING = System.TimeSpan.FromSeconds(3);
            TIME_OUT_CLICKING = System.TimeSpan.FromSeconds(3);
            TIME_OUT_VALUE_CHANGING = System.TimeSpan.FromSeconds(3);
            TIME_OUT_PAGE_LOADING = System.TimeSpan.FromSeconds(5);
            TIME_OUT_SCRIPT_EXECUTING = System.TimeSpan.FromSeconds(5);
        }      
    }
}
