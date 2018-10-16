using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using TestAutomation.DriverLogic.Selenium.Elements;

namespace TestAutomation.PageMaps.Yandex
{
    class ComparisonList
    {
        public static string url = "https://market.yandex.ua/compare";
        private string comparedElementsCssSelector = "div.n-compare-content__line";
        private string elementCssSelector = "div.n-compare-content__line > div:nth-child({0})";
        private string elementLinkCssSelector = "> a";
        private string elementDeleteButtonCssselector = "span.n-compare-head__close";
        public string getElementLink(int n)
        {
            string link = new ElementProperties().getAttribute(By.CssSelector(string.Format(elementCssSelector, n) + " " + elementLinkCssSelector), "href");
            int i = link.IndexOf('?');
            if (i > 0) return link.Substring(0, i - 1);
            return link;
        }
        public void checkElements(List<string> linksOfFound)
        {
            List<string> linksOfAdded = new List<string>();
            for (int i = 1; i <= new ElementProperties().getListOfChildrenCount(By.CssSelector(comparedElementsCssSelector)); i++)
                linksOfAdded.Add(getElementLink(i));
            Assert.Contains(linksOfFound, linksOfAdded);           
        }
        public void removeAllElements()
        {
            for (int i = 0; i < new ElementProperties().getListOfChildrenCount(By.CssSelector(comparedElementsCssSelector)); i++)
                new Button().click(By.CssSelector(string.Format(elementCssSelector, i) + " " + elementDeleteButtonCssselector));
            Assert.False(new ElementProperties().isPresent(By.CssSelector(comparedElementsCssSelector)));
        }
    }
}
