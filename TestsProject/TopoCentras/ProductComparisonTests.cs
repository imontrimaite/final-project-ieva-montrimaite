

using FrameworkProject;
using FrameworkProject.Page;
using NUnit.Framework;
using TestsProject.BaseTests;

namespace TestsProject.TopoCentras
{
    internal class ProductComparisonTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            ProductComparisonPage.Open();
        }

        [Test]
        public void ProductComparison()
        {
            ProductComparisonPage.SelectFirstComaprisonCheckbox();
            ProductComparisonPage.SelectSecondComaprisonCheckbox();
            ProductComparisonPage.ClickCompareButton();
            ProductComparisonPage.ToggleShowOnlyDifferences();

            string colorFirst = ProductComparisonPage.GetFirstColor();
            string colorSecond = ProductComparisonPage.GetSecondColor();
            Assert.AreNotEqual(colorSecond, colorFirst);

            string itemCodeFirst = ProductComparisonPage.GetFirstItemCode();
            string itemCodeSecond = ProductComparisonPage.GetSecondItemCode();
            Assert.AreNotEqual(itemCodeFirst, itemCodeSecond);

            string manufucturerCodeFirst = ProductComparisonPage.GetFirstManufacturerCode();
            string manufucturerCodeSecond = ProductComparisonPage.GetSecondManufacturerCode();
            Assert.AreNotEqual(manufucturerCodeFirst, manufucturerCodeSecond);            
        }


        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
