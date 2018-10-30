using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.Pages.Yandex
{
    class Music : PageMap
    {
        public static string url = "https://music.yandex.by/";
        #region locators
        private By SearchField = By.CssSelector("div.head__search > div.d-suggest > div.d-input> input");
        private string musicCssSelector = "//div[@class='d-suggest__entities']/div[1]//div[contains(text(),'{0}')]";
        private By SearchSelectMenuByMusician(string musician)
        {
            return By.CssSelector(string.Format(musicCssSelector, musician));
        }
        private By MusicianTitleField = By.CssSelector("div.page-artist div.d-generic-page-head__main-top > h1");
        private string albumCssSelector = "//div[@class='page-artist__albums']/div[{0}]//span[@class='d-artists']/a";
        private By AlbumMusician(int n)
        {
            return By.CssSelector(string.Format(albumCssSelector, n));
        }
        private By UserPicture = By.CssSelector("a.head__userpic");
        private By ExitButton = By.CssSelector("div.popup ul.multi-auth__menu > li:nth-child(10)");
        #endregion
        #region data
        private string searchText1 = "Metal";
        private string searchText2 = "beyo";
        private string musician1 = "Metallica";
        private string musician2 = "Beyoncé";
        #endregion
        #region actions
        public void searchMusic(string text)
        {
            field.input(SearchField, text);
            mouse.useKeyboard(Keys.Enter);
        }
        public void logout()
        {
            new Button().click(UserPicture);
            new Button().click(ExitButton);
        }
        #endregion
        #region tests
        public void Test_Search()
        {
            browser.navigate(Main.url);
            new Main().goToLoginToMailPage();
            new Login().loginSuccess();
            browser.navigate(Main.url);
            new Main().goToMusicTab();
            searchMusic(searchText1);
            new Button().click(SearchSelectMenuByMusician(musician1));
            Assert.AreEqual(musician1, new ElementProperties().getText(MusicianTitleField));
            Assert.AreEqual(musician1, new ElementProperties().getText(AlbumMusician(1)));
            logout();
        }
        public void Test_PlayingMusic()
        {
            browser.navigate(Main.url);
            new Main().goToLoginToMailPage();
            new Login().loginSuccess();
            browser.navigate(Main.url);
            new Main().goToMusicTab();
            searchMusic(searchText2);
            new Button().click(SearchSelectMenuByMusician(musician2));
            logout();
        }
        #endregion
    }
}
