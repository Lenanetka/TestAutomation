using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.Pages.Yandex
{
    public class Main : PageMap
    {
        public static string url = "https://yandex.by/";
        #region locators
        private By LoginToMailButton = By.CssSelector("a.desk-notif-card__login-enter-expanded");
        private By SelectLanguageButton = By.CssSelector("div.b-langs > div > a");
        private string LanguageXPath = "//span[@class='b-langs__text' and contains(text(), '{0}')]";
        private By LanguageButton(string lang)
        {
            return By.XPath(string.Format(LanguageXPath, lang));
        }
        private By AddLanguageButton = By.CssSelector("li.b-menu__item_pos_last > div > a");
        private By VideoTabLink = By.XPath("//a[@data-statlog='tabs.video' and @data-id='video']");
        private By ImagesTabLink = By.XPath("//a[@data-statlog='tabs.images' and @data-id='images']");
        private By MapsTabLink = By.XPath("//a[@data-statlog='tabs.maps' and @data-id='maps']");
        private By MarketTabLink = By.XPath("//a[@data-statlog='tabs.market' and @data-id='market']");
        private By MusicTabLink = By.XPath("//a[@data-statlog='tabs.music' and @data-id='music']");
        private By NewsTabLink = By.XPath("//a[@data-statlog='tabs.news' and @data-id='news']");
        private By TranslateTabLink = By.XPath("//a[@data-statlog='tabs.translate' and @data-id='translate']");
        #endregion
        public Main() : base()
        {
            
        }
        #region actions
        public void goToLoginToMailPage()
        {
            button.click(LoginToMailButton);
            StringAssert.StartsWith(Login.urlTemplate, browser.getCurrentUrl());
        }                            
        public void goToVideoTab()
        {
            button.click(VideoTabLink);
            StringAssert.StartsWith(Video.url, browser.getCurrentUrl());
        }
        public void goToImagesTab()
        {
            button.click(ImagesTabLink);
            StringAssert.StartsWith(Images.url, browser.getCurrentUrl());
        }
        public void goToNewsTab()
        {
            button.click(NewsTabLink);
            StringAssert.StartsWith(News.urlTemplate, browser.getCurrentUrl());
        }
        public void goToMarketTab()
        {
            button.click(MarketTabLink);
            StringAssert.StartsWith(Market.urlTemplate, browser.getCurrentUrl());
        }
        public void goToMapsTab()
        {
            button.click(MapsTabLink);
            StringAssert.StartsWith(Maps.url, browser.getCurrentUrl());
        }
        public void goToMusicTab()
        {
            button.click(MusicTabLink);
            StringAssert.StartsWith(Music.url, browser.getCurrentUrl());
        }
        public void goToTranslateTab()
        {
            button.click(TranslateTabLink);
            StringAssert.StartsWith(Translate.url, browser.getCurrentUrl());
        }
        public void changeLanguage(string lang)
        {
            
            button.click(SelectLanguageButton);
            if (elementProperties.isPresent(LanguageButton(lang)))
                button.click(LanguageButton(lang));
            else
            {
                button.click(AddLanguageButton);
                new Language().setLanguageToEnglish();
            }
            StringAssert.IsMatch(lang, elementProperties.getText(SelectLanguageButton));
        }
        #endregion
        #region tests
        public void Test_Navigation()
        {
            browser.navigate(url);
            goToVideoTab();
            browser.navigateBack();
            goToImagesTab();
            browser.navigateBack();
            goToNewsTab();
            browser.navigateBack();
            goToMarketTab();
            browser.navigateBack();
            goToMapsTab();
            browser.navigateBack();
            goToMusicTab();
            browser.navigateBack();
            goToTranslateTab();
        }
        public void Test_ChangeLanguageToEnglish()
        {
            browser.navigate(url);
            changeLanguage("Eng");
            //end
            changeLanguage("Rus");
        }
        
        #endregion
    }
}
