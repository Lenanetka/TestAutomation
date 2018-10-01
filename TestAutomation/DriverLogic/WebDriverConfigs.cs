using IniParser;
using IniParser.Model;

namespace TestAutomation.DriverLogic
{
    public class WebDriverConfigs
    {
        public string DRIVER;
        public string VERSION;
        public string PATH;
        public bool START_MAXIMIZED;
        public bool IGNORE_CERTIFICATE_ERRORS;
        public WebDriverTimeouts timeouts;
        
        public WebDriverConfigs(string path)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(path);

            DRIVER = getBrowser(data, "DRIVER");
            VERSION = getBrowser(data, "VERSION");
            PATH = getBrowser(data, "PATH");

            START_MAXIMIZED = getBrowserOptions(data, "START_MAXIMIZED");
            IGNORE_CERTIFICATE_ERRORS = getBrowserOptions(data, "IGNORE_CERTIFICATE_ERRORS");

            timeouts.TIME_OUT_FINDING = getTimeout(data,"TIME_OUT_FINDING");
            timeouts.TIME_OUT_CLICKING = getTimeout(data, "TIME_OUT_CLICKING");
            timeouts.TIME_OUT_VALUE_CHANGING = getTimeout(data, "TIME_OUT_VALUE_CHANGING");
            timeouts.TIME_OUT_PAGE_LOADING = getTimeout(data, "TIME_OUT_PAGE_LOADING");
            timeouts.TIME_OUT_SCRIPT_EXECUTING = getTimeout(data, "TIME_OUT_SCRIPT_EXECUTING");          
        }
        private System.TimeSpan getTimeout(IniData data, string key)
        {
            return System.TimeSpan.FromSeconds(int.Parse(data["Timeouts"][key]));
        }
        private string getBrowser(IniData data, string key)
        {
            return data["Browser"][key];
        }
        private bool getBrowserOptions(IniData data, string key)
        {
            return bool.Parse(data["BrowserOptions"][key]);
        }
    }
}
