using NUnit.Allure.Attributes;
using NUnit.Framework;
using TestAutomation.Pages.Yandex;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    [AllureSubSuite("Pool of tests 2")]
    class YandexPoolOfTests2 : TestBase
    {
        [Test]
        public void AddItemsToComparisonList()
        {           
            new Market().Test_AddProductsToComparisonList();
        }
        [Test]
        public void DeleteItemsFromComparisonList()
        {
            new ComparisonList().Test_RemoveAllProductsFromComparisonList();
        }
        [Test]
        public void SortItemsByPrice()
        {
            new Market().Test_SortingByPrice();
        }
        [Test]
        public void SortItemsByTag()
        {
            new Market().Test_SortingByTag();
        }
        [Test]
        public void MusicSearch()
        {
            new Music().Test_Search();
        }
        [Test]
        public void MusicPlay()
        {
            new Music().Test_PlayingMusic();
        }
    }
}
