using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.Pages.Yandex
{
    class Market : PageMap
    {
        public static string url = "https://market.yandex.by/";
        public static string urlTemplate = "https://market.yandex.";
        #region locators
        private By LoginButton = By.CssSelector("div.n-passport-suggest-popup-opener a");
        private By SearchField = By.Id("header-search");      
        private By ComparisonListButton = By.CssSelector("a.link.header2-menu__item_type_compare");
        private string productCssSelector = "div.n-snippet-list.n-snippet-list_type_grid > div:nth-child({0})";
        private By Product(int n) {
            return By.CssSelector(string.Format(productCssSelector, n));
        }
        private By ProductLink(int n)
        {
            return By.CssSelector(string.Format(productCssSelector, n) + " " + "div.n-snippet-cell2__header > div > a");
        }
        private By ProductCompareButton(int n)
        {
            return By.CssSelector(string.Format(productCssSelector, n) + " " + "div.n-user-lists_type_compare_in-list_no");
        }
        private By ProductSelectedCompareButton(int n)
        {
            return By.CssSelector(string.Format(productCssSelector, n) + " " + "div.n-user-lists_type_compare_in-list_yes");
        }
        #endregion
        #region data
        private string searchText = "Note 8";
        #endregion
        #region actions
        public void goToLoginToMarketPage()
        {
            button.click(LoginButton);
            browser.switchToLastTab();
            StringAssert.StartsWith(Login.urlTemplate, browser.getCurrentUrl());
        }       
        public void goToComparisonList()
        {
            button.click(ComparisonListButton);
            StringAssert.StartsWith(ComparisonList.url, browser.getCurrentUrl());
        }
        public void searchProducts(string text)
        {
            field.input(SearchField, text);
            mouse.useKeyboard(Keys.Enter);
        }
        public void addProductToComparison(int n)
        {
            mouse.moveMouseTo(Product(n));
            if(!new ElementProperties().isPresent(ProductSelectedCompareButton(n)))
                button.click(ProductCompareButton(n));
        }
        public string getProductLink(int n)
        {
            string link = new ElementProperties().getAttribute(ProductLink(n), "href");
            int i = link.IndexOf('?');
            return (i > 0) ? link.Substring(0, i - 1) : link;
        }       
        public void sortByPrice()
        {

        }
        public void sortByTag()
        {

        }
        #endregion
        #region tests
        public void Test_AddProductsToComparisonList()
        {
            new Main().goToMarketTab();
            goToLoginToMarketPage();
            new Login().loginSuccess();
            browser.switchToFirstTab();
            searchProducts(searchText);
            addProductToComparison(1);
            addProductToComparison(2);
            List<string> links = new List<string>();
            links.Add(getProductLink(1));
            links.Add(getProductLink(2));
            goToComparisonList();
            new ComparisonList().checkProducts(links);
        }
        #endregion
    }
}
