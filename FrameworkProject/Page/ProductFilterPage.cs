using System.Collections.Generic;
using System.Linq;

namespace FrameworkProject.Page
{
    public class ProductFilterPage
    {
        public static void Open()
        {
            Driver.OpenURL("https://www.topocentras.lt/televizoriai-ir-garso-technika/televizoriai.html");
            Common.ClickElement(Locators.CookieConsent.cookieConsent);
        }

        public static void ClickUpTo300eurCheckbox()
        {
            Common.ClickElement(Locators.ProdcutFilter.checkboxUpTo300eur);
        }

        public static void ClickPhilipsManufacturerCheckbox()
        {
            Common.ClickElement(Locators.ProdcutFilter.checkboxPhilips);
        }

        public static List<int> GetProductPrices()
        {
            List<string> productPricesString = Common.GetElementsText(Locators.ProdcutFilter.outputPriceRange);
            List<int> productPricesInt = new List<int>();

            foreach (string productPrice in productPricesString)
            {
                string priceString = productPrice.Split(' ').First().Split(',').First();
                productPricesInt.Add(int.Parse(priceString));
            }

            return productPricesInt;
        }

        public static List<string> GetManufacturerName()
        {
            return Common.GetElementsText(Locators.ProdcutFilter.outputManufacturer);
        }

        public static bool ProductsHaveExpectedManufacturerName(List<string> actualManufacturers, string expectedManufacturer)
        {
            return actualManufacturers.TrueForAll(x => x.Contains(expectedManufacturer));
        }
    }
}
