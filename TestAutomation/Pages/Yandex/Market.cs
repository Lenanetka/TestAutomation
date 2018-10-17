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
        private string loginToMailButtonCssSelector = "div.n-passport-suggest-popup-opener a";
        private string searchFieldId = "header-search";
        private string searchText = "Note 8";
        private string comparisonListButtonCssSelector = "a.link.header2-menu__item_type_compare";
        private string foundElementCssSelector = "div.n-snippet-list.n-snippet-list_type_grid > div:nth-child({0})";
        private string compareButtonCssSelector = "div.n-user-lists_type_compare_in-list_no";
        private string compareButtonSelectedCssSelector = "div.n-user-lists_type_compare_in-list_yes";
        private string elementLinkCssSelector = "div.n-snippet-cell2__header > div > a";
        public void openLoginPage()
        {
            new Button().click(By.CssSelector(loginToMailButtonCssSelector));
            browser.switchToLastTab();
            StringAssert.StartsWith(Login.urlTemplate, browser.getCurrentUrl());
        }
        public void search(string text)
        {
            new Field().input(By.Id(searchFieldId), text);
            new Mouse().useKeyboard(Keys.Enter);
        }
        public void openComparisonList()
        {
            new Button().click(By.CssSelector(comparisonListButtonCssSelector));
            StringAssert.StartsWith(ComparisonList.url, browser.getCurrentUrl());
        }
        public void addElementsToComparison(int n)
        {
            new Mouse().moveMouseTo(By.CssSelector(string.Format(foundElementCssSelector, n)));
            if(!new ElementProperties().isPresent(By.CssSelector(string.Format(foundElementCssSelector, n) + " " + compareButtonSelectedCssSelector)))
                new Button().click(By.CssSelector(string.Format(foundElementCssSelector, n) + " " + compareButtonCssSelector));
        }
        public string getFoundElementLink(int n)
        {
            string link = new ElementProperties().getAttribute(By.CssSelector(string.Format(foundElementCssSelector, n) + " " + elementLinkCssSelector), "href");
            int i = link.IndexOf('?');
            if (i > 0) return link.Substring(0, i - 1);
            return link;
        }
        public void addToComparison()
        {
            new Main().goToMarketTab();
            openLoginPage();
            new Login().loginSuccess();
            browser.switchToFirstTab();
            search(searchText);
            addElementsToComparison(1);
            addElementsToComparison(2);
            List<string> links = new List<string>();
            links.Add(getFoundElementLink(1));
            links.Add(getFoundElementLink(2));
            openComparisonList();
            new ComparisonList().checkElements(links);
        }
        public void sortByPrice()
        {

        }
        public void sortByTag()
        {

        }
    }
}
