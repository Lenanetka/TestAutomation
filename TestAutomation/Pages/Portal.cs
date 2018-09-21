using TestAutomation.Driver;

namespace TestAutomation.Pages
{
    public static class Portal
    {
        private static string baseURL = ".skytest.purity.no/";
        public static string getBaseURL(string container)
        {
            return "http://" + container + baseURL;
        }
    }
}
