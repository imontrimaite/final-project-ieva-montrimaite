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
            int expectedPriceRange = 300;
            string expectedManufacturer = "PHILIPS";            

            ProductFilterPage.ClickUpTo300eurCheckbox();
            ProductFilterPage.ClickPhilipsManufacturerCheckbox();

            List<int> actualPrices = ProductFilterPage.GetProductPrices();

            foreach (int price in actualPrices)
            {
                Assert.LessOrEqual(price, expectedPriceRange);
            }

            List<string> actualManufacturers = ProductFilterPage.GetManufacturerName();
            Assert.IsTrue(ProductFilterPage.ProductsHaveExpectedManufacturerName(actualManufacturers, expectedManufacturer));
        }
    }
}
