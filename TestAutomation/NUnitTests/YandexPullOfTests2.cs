using NUnit.Allure.Attributes;
using NUnit.Framework;
using TestAutomation.PageMaps.Yandex;

namespace TestAutomation.NUnitTests
{
    [TestFixture]
    [AllureSubSuite("Pool of tests 2")]
    class YandexPullOfTests2 : TestBase
    {
        [Test]
        public void AddItemToComparisonList()
        {           
            new Market().addToComparison();
        }
        [Test]
        public void DeleteItemFromComparisonList()
        {
            new Market().addToComparison();
            new ComparisonList().removeAllElements();
        }
        [Test]
        public void SortItemsByPrice()
        {
            new Market().sortByPrice();
        }
        [Test]
        public void SortItemsByTag()
        {
            new Market().sortByTag();
        }
        [Test]
        public void MusicSearch()
        {

        }
        [Test]
        public void MusicPlay()
        {

        }
    }
}
