using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;

namespace TestAutomation.DriverLogic.Selenium
{
    static class WebDriverOptions
    {
        public static ChromeOptions chromeOptions(WebDriverConfigs config)
        {
            ChromeOptions options = new ChromeOptions();
            if (config.START_MAXIMIZED == true) options.AddArgument("--start-maximized");
            if (config.IGNORE_CERTIFICATE_ERRORS == true) options.AddArgument("--ignore-certificate-errors");
            return options;
        }
        public static FirefoxOptions firefoxOptions(WebDriverConfigs config)
        {
            FirefoxOptions options = new FirefoxOptions();
            if (config.START_MAXIMIZED == true) options.AddArgument("--start-maximized");
            if (config.IGNORE_CERTIFICATE_ERRORS == true) options.AddArgument("--ignore-certificate-errors");
            return options;
        }
        public static OperaOptions operaOptions(WebDriverConfigs config)
        {
            OperaOptions options = new OperaOptions();
            if (config.START_MAXIMIZED == true) options.AddArgument("--start-maximized");
            if (config.IGNORE_CERTIFICATE_ERRORS == true) options.AddArgument("--ignore-certificate-errors");
            return options;
        }
        public static InternetExplorerOptions internetExplorerOptions(WebDriverConfigs config)
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            return options;
        }
        public static EdgeOptions edgeOptions(WebDriverConfigs config)
        {
            EdgeOptions options = new EdgeOptions();
            return options;
        }

    }
}