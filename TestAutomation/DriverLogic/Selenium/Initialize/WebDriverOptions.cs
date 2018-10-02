using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;

namespace TestAutomation.DriverLogic.Selenium.Initialize
{
    abstract class WebDriverOptions
    {
        protected WebDriverConfigs configs;
        protected ChromeOptions chromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            if (configs.START_MAXIMIZED == true) options.AddArgument("--start-maximized");
            if (configs.IGNORE_CERTIFICATE_ERRORS == true) options.AddArgument("--ignore-certificate-errors");
            return options;
        }
        protected FirefoxOptions firefoxOptions()
        {
            FirefoxOptions options = new FirefoxOptions();
            if (configs.START_MAXIMIZED == true) options.AddArgument("--start-maximized");
            if (configs.IGNORE_CERTIFICATE_ERRORS == true) options.AddArgument("--ignore-certificate-errors");
            return options;
        }
        protected OperaOptions operaOptions()
        {
            OperaOptions options = new OperaOptions();
            if (configs.START_MAXIMIZED == true) options.AddArgument("--start-maximized");
            if (configs.IGNORE_CERTIFICATE_ERRORS == true) options.AddArgument("--ignore-certificate-errors");
            return options;
        }
        protected InternetExplorerOptions internetExplorerOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            return options;
        }
        protected EdgeOptions edgeOptions(WebDriverConfigs configs)
        {
            EdgeOptions options = new EdgeOptions();
            return options;
        }

    }
}