using TestAutomation.WebElements;

namespace TestAutomation.PageMaps
{
    class LoginPageMap : PageMap
    {
        public string url = "https://yandex.by/";
        public IElement LoginButton
        {
            get
            {
                return browser.getElement().byXPath("/html/body/div[1]/div[3]/div[1]/div/div[1]/div/a");
            }
        }
        public IField LoginField
        {
            get
            {
                return browser.getField().byName("login");
            }
        }
        public IField PasswordField
        {
            get
            {
                return browser.getField().byName("passwd");
            }
        }
        public IElement SubmitButton
        {
            get
            {
                return browser.getElement().byXPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div/div/div/form/div[4]/button[1]/span");
            }
        }
        public IElement UserAvatarButton
        {
            get
            {
                return browser.getElement().byId("recipient-1");
            }
        }
        public IElement LogoutButton
        {
            get
            {
                return browser.getElement().byXPath("/html/body/div[8]/div/div/div/div[7]/a");
            }
        }
    }
}
