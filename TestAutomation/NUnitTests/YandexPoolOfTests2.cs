using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using TestAutomation.Pages.Yandex;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    [AllureSuite("Yandex")]
    [AllureSubSuite("Pool 2")]
    class YandexPoolOfTests2 : TestBase
    {
        [Test]
        [AllureIssue("ISSUE-7")]
        [AllureTms("TMS-7")]
        [AllureSeverity(SeverityLevel.critical)]
        public void AddItemsToComparisonList()
        {           
            new Market().Test_AddProductsToComparisonList();
        }
        [Test]
        [AllureIssue("ISSUE-8")]
        [AllureTms("TMS-8")]
        [AllureSeverity(SeverityLevel.critical)]
        public void DeleteItemsFromComparisonList()
        {
            new ComparisonList().Test_RemoveAllProductsFromComparisonList();
        }
        [Test]
        [AllureIssue("ISSUE-9")]
        [AllureTms("TMS-9")]
        [AllureSeverity(SeverityLevel.normal)]
        public void SortItemsByPrice()
        {
            new Market().Test_SortingByPrice();
        }
        [Test]
        [AllureIssue("ISSUE-10")]
        [AllureTms("TMS-10")]
        [AllureSeverity(SeverityLevel.normal)]
        public void SortItemsByTag()
        {
            new Market().Test_SortingByTag();
        }
        [Test]
        [AllureIssue("ISSUE-11")]
        [AllureTms("TMS-11")]
        [AllureSeverity(SeverityLevel.critical)]
        public void MusicSearch()
        {
            new Music().Test_Search();
        }
        [Test]
        [AllureIssue("ISSUE-12")]
        [AllureTms("TMS-12")]
        [AllureSeverity(SeverityLevel.critical)]
        public void MusicPlay()
        {
            new Music().Test_PlayingMusic();
        }
    }
}
