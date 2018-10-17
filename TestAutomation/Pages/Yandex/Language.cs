using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.Pages.Yandex
{
    class Language: PageMap
    {
        public static string url = "https://yandex.by/tune/lang/";

        private By SelectLanguageDropDownList = By.CssSelector("div.option__content > div.select.option__select > button.select__button.button_arrow_down");
        private By EnglishLanguageButton = By.XPath("//div[@class='popup__content']//span[@class='select__text' and contains(text(), 'English')]");
        private By SubmitLanguageButton = By.XPath("//div[@class='form__controls']//button[@type='submit']");
        
        #region actions
        public void setLanguage_English()
        {
            button.click(SelectLanguageDropDownList);
            button.click(EnglishLanguageButton);
            button.click(SubmitLanguageButton);
        }
        #endregion
    }
}
