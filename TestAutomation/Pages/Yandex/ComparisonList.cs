using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.Pages.Yandex
{
    class ComparisonList : PageMap
    {
        public static string url = "https://market.yandex.ua/compare";
        #region locators
        private By ComparisonProductsList = By.CssSelector("div.n-compare-content__line");
        private string productCssSelector = "div.n-compare-content__line > div:nth-child({0})";
        private By Product(int n)
        {
            return By.CssSelector(string.Format(productCssSelector, n));
        }
        private By ProductLink(int n) {
            return By.CssSelector(string.Format(productCssSelector, n) + " " + "> a");
        }
        private By ProductRemoveButton(int n)
        {
            return By.CssSelector(string.Format(productCssSelector, n) + " " + "span.n-compare-head__close");
        }
        #endregion
        #region actions
        public string getProductLink(int n)
        {
            string link = elementProperties.getAttribute(Product(n), "href");
            int i = link.IndexOf('?');
            return (i > 0) ? link.Substring(0, i - 1) : link;
        }
        public void checkProducts(List<string> expectedList)
        {
            List<string> currentList = new List<string>();
            for (int i = 1; i <= elementProperties.getListCount(ComparisonProductsList); i++)
                currentList.Add(getProductLink(i));
            Assert.Contains(expectedList, currentList);           
        }
        public void removeAllFromComparisonList()
        {
            for (int i = 0; i < elementProperties.getListCount(ComparisonProductsList); i++)
                button.click(ProductRemoveButton(i));
        }
        #endregion
        #region tests
        public void Test_RemoveAllProductsFromComparisonList()
        {
            new Market().Test_AddProductsToComparisonList();
            removeAllFromComparisonList();
            Assert.False(new ElementProperties().isPresent(ComparisonProductsList));
        }
        #endregion
    }
}
