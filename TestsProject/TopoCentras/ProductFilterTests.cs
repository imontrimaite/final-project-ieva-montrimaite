
using FrameworkProject.Page;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
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

            List<string> actualPrices = ProductFilterPage.GetPriceText();

            foreach (string price in actualPrices)
            {
                string priceTextSplit = price.Split(' ').First().Split(',').First();
                int priceAsInt = int.Parse(priceTextSplit);
                Assert.LessOrEqual(priceAsInt, expectedPriceRange);
            }

            List<string> actualManufacturer = ProductFilterPage.GetManufacturerName();
            Assert.IsTrue(actualManufacturer.TrueForAll(x => x.Contains(expectedManufacturer)));
        }
    }
}
