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
        private By ProductsList = By.CssSelector("div.n-snippet-list.n-snippet-list_type_grid");
        private string productCssSelector = "div.n-snippet-list.n-snippet-list_type_grid > div:nth-child({0})";
        private By Product(int n) {
            return By.CssSelector(string.Format(productCssSelector, n));
        }
        private By ProductLink(int n)
        {
            return By.CssSelector(string.Format(productCssSelector, n) + " " + "div.n-snippet-cell2__header > div > a");
        }
        private By ProductPrice(int n)
        {
            return By.CssSelector(string.Format(productCssSelector, n) + " " + "div.price");
        }
        private By ProductCompareButton(int n)
        {
            return By.CssSelector(string.Format(productCssSelector, n) + " " + "div.n-user-lists_type_compare_in-list_no");
        }
        private By ProductSelectedCompareButton(int n)
        {
            return By.CssSelector(string.Format(productCssSelector, n) + " " + "div.n-user-lists_type_compare_in-list_yes");
        }
        private By ElectronicsTabLink = By.XPath("//ul[@class='topmenu__list']/li[@data-department='Электроника']");
        private By AppliancesTabLink = By.XPath("//ul[@class='topmenu__list']/li[@data-department='Бытовая техника']");
        private By ActionCamerasMenuLink = By.XPath("//a[contains(text(),'Экшн-камеры')]");
        private By RefrigeratorsMenuLink = By.XPath("//a[contains(text(),'Холодильники')]");
        private By SortByPriceButton = By.XPath("//a[contains(text(),'по цене')]");
        private By AllFiltersButton = By.XPath("//span[contains(text(),'Все фильтры')]");
        private By WidthUpToField = By.Name("Ширина до");
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
            if(!elementProperties.isPresent(ProductSelectedCompareButton(n)))
                button.click(ProductCompareButton(n));
        }
        public string getProductLink(int n)
        {
            string link = elementProperties.getAttribute(ProductLink(n), "href");
            int i = link.IndexOf('?');
            return (i > 0) ? link.Substring(0, i - 1) : link;
        }
        public int getProductPrice(int n)
        {
            string price = elementProperties.getText(ProductPrice(n));
            price = System.Text.RegularExpressions.Regex.Replace(price, "[^0-9]", "");
            return int.Parse(price);
        }
        #endregion
        #region tests
        public void Test_AddProductsToComparisonList()
        {
            browser.navigate(Main.url);
            new Main().goToMarketTab();
            //goToLoginToMarketPage();
            //new Login().loginSuccess();
            //browser.switchToFirstTab();
            searchProducts(searchText);
            addProductToComparison(1);
            addProductToComparison(2);
            List<string> links = new List<string>();
            links.Add(getProductLink(1));
            links.Add(getProductLink(2));
            goToComparisonList();
            new ComparisonList().checkProducts(links);
        }
        public void Test_SortingByPrice()
        {
            browser.navigate(Main.url);
            new Main().goToMarketTab();
            button.click(ElectronicsTabLink);
            button.click(ActionCamerasMenuLink);
            button.click(SortByPriceButton);
            int n = elementProperties.getListCount(ProductsList);
            Assert.Greater(n, 1);
            System.Random rnd = new System.Random((int)System.DateTime.Now.Ticks);
            Assert.LessOrEqual(getProductPrice(1), getProductPrice(rnd.Next(2, n)));
            Assert.LessOrEqual(getProductPrice(rnd.Next(2, n)), getProductPrice(n));
        }
        public void Test_SortingByTag()
        {
            browser.navigate(Main.url);
            new Main().goToMarketTab();
            button.click(AppliancesTabLink);
            button.click(RefrigeratorsMenuLink);
            if (elementProperties.isPresent(AllFiltersButton)) button.click(AllFiltersButton);
            field.input(WidthUpToField, "50");
            int n = elementProperties.getListCount(ProductsList);
            Assert.Greater(n, 1);
            //Страница изменилась до неузнаваемости...
        }
        #endregion
    }
}
