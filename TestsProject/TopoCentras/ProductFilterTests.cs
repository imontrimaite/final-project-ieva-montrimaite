
using FrameworkProject.Page;
using NUnit.Framework;
using System.Collections.Generic;
using TestsProject.BaseTests;

namespace TestsProject.TopoCentras
{
    internal class ProductFilterTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            ProductFilterPage.Open();
        }

        [Test]
        public void ProductFilter()
        {
            string expectedAvailablity = "Į krepšelį";
            string expectedPhoneType = "Galaxy Flip4";
            string expectedInternalMemory = "128 GB";

            ProductFilterPage.ClickInStoresCheckbox();
            ProductFilterPage.ClickFoldingPhonesCheckbox();
            ProductFilterPage.Click128gbCheckBox();

            List<string> actualAvailability = ProductFilterPage.GetProductsAvailabilityText();
            Assert.IsTrue(actualAvailability.TrueForAll(x => x.Contains(expectedAvailablity)));

            List<string> actualPhoneType = ProductFilterPage.GetProductsTypeText();
            Assert.IsTrue(actualPhoneType.TrueForAll(x => x.Contains(expectedPhoneType)));

            List<string> actualInternalMemory = ProductFilterPage.GetProductsInternalMemoryText();
            Assert.IsTrue(actualInternalMemory.TrueForAll(x => x.Contains(expectedInternalMemory)));
        }
    }
}
