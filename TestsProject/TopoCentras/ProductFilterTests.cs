
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
            string expectedProducer = "PHILIPS";            

            ProductFilterPage.ClickUpTo300eurCheckbox();
            ProductFilterPage.ClickPhilipsProducerCheckbox();

            List<string> actualPrices = ProductFilterPage.GetPriceText();

            foreach (string price in actualPrices)
            {
                string priceSplit = price.Split(' ').First().Split(',').First();
                int priceAsInt = int.Parse(priceSplit);
                Assert.LessOrEqual(priceAsInt, expectedPriceRange);
            }

            List<string> actualProducer = ProductFilterPage.GetProducerText();
            Assert.IsTrue(actualProducer.TrueForAll(x => x.Contains(expectedProducer)));
        }
    }
}
