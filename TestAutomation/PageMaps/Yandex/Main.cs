using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.PageMaps.Yandex
{
    public class Main : PageMap
    {
        public static string url = "https://yandex.by/";
        private string loginToMailButtonXPath = "/html/body/div[1]/div[3]/div[1]/div/div[1]/div/a";
        private string selectLanguageCSSSelector = "body > div.container.rows > div.row.rows__row.rows__row_first > div > div.container.headline > div > div.col.headline__item.headline__bar > div > div > div.col.headline__bar-item.b-langs > div > a";
        private string engLanguageXPath = "//span[@class='b-langs__text' and contains(text(), 'Eng')]";
        private string addLanguageCSSSelector = "li.b-menu__item.b-menu__layout-vert-cell_position_last.b-menu__item_pos_last > div > a";
        private string videoLinkXPath = "//a[@data-statlog='tabs.video' and @data-id='video']";
        private string imagesLinkXPath = "//a[@data-statlog='tabs.images' and @data-id='images']";
        private string mapsLinkXPath = "//a[@data-statlog='tabs.maps' and @data-id='maps']";
        private string marketLinkXPath = "//a[@data-statlog='tabs.market' and @data-id='market']";
        private string musicLinkXPath = "//a[@data-statlog='tabs.music' and @data-id='music']";
        private string newsLinkXPath = "//a[@data-statlog='tabs.news' and @data-id='news']";
        private string translateLinkXPath = "//a[@data-statlog='tabs.translate' and @data-id='translate']";

        public Main() : base()
        {

        }
        public void openLoginPage()
        {
            browser.navigate(url);
            new Button().click(By.XPath(loginToMailButtonXPath));
            StringAssert.StartsWith(Login.urlTemplate, browser.getCurrentUrl());
        }       
        public void navigationSuccess()
        {       
            goToLink(By.XPath(videoLinkXPath), Video.url);
            goToLink(By.XPath(imagesLinkXPath), Images.url);
            goToLink(By.XPath(newsLinkXPath), News.urlTemplate);
            goToLink(By.XPath(mapsLinkXPath), Maps.url);
            goToLink(By.XPath(marketLinkXPath), Market.urlTemplate);
            goToLink(By.XPath(translateLinkXPath), Translate.url);
            goToLink(By.XPath(musicLinkXPath), Music.url);
        }
        public void goToLink(By toLink, string expectedUrl)
        {
            browser.navigate(url);
            new Button().click(toLink);
            StringAssert.StartsWith(expectedUrl, browser.getCurrentUrl());
        }
        public void openMarket()
        {
            goToLink(By.XPath(marketLinkXPath), Market.urlTemplate);
        }
        public void changeLanguage_English()
        {
            browser.navigate(url);
            new Button().click(By.CssSelector(selectLanguageCSSSelector));
            if (new ElementProperties().isPresent(By.XPath(engLanguageXPath)))
                new Button().click(By.XPath(engLanguageXPath));
            else
            {
                new Button().click(By.CssSelector(addLanguageCSSSelector));
                new Language().setLanguage_English();
            }
            StringAssert.IsMatch("Eng", new ElementProperties().getText(By.CssSelector(selectLanguageCSSSelector)));
        }
    }
}
