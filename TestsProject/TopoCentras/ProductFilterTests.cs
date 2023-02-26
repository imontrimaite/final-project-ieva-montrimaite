
using FrameworkProject.Page;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            string expectedAvailablity = "Į krepšelį";
            string expectedProducer = "PHILIPS";

            ProductFilterPage.ClickAvailableInStoresCheckbox();
            ProductFilterPage.ClickPhilipsProducerCheckbox();

            List<string> actualAvailability = ProductFilterPage.GetProductsAvailabilityText();
            Assert.IsTrue(actualAvailability.TrueForAll(x => x.Equals(expectedAvailablity)));

            List<string> actualProducer = ProductFilterPage.GetProducerText();
            Assert.IsTrue(actualProducer.TrueForAll(x => x.Contains(expectedProducer)));
        }
    }
}
