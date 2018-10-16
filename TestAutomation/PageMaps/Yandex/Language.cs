using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.PageMaps.Yandex
{
    class Language: PageMap
    {
        public static string url = "https://yandex.by/tune/lang/";
        private string selectLanguageButtonCSSSelector = "div.option__content > div.select.option__select > button.select__button.button_arrow_down";
        private string englishLanguageButtonXPath = "//div[@class='popup__content']//span[@class='select__text' and contains(text(), 'English')]";
        private string submitLanguageButtonXPath = "//div[@class='form__controls']//button[@type='submit']";
        public void setLanguage_English()
        {
            new Button().click(By.CssSelector(selectLanguageButtonCSSSelector));
            new Button().click(By.XPath(englishLanguageButtonXPath));
            new Button().click(By.XPath(submitLanguageButtonXPath));
        }
    }
}
