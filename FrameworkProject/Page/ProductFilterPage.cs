using System.Collections.Generic;

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

        public static List<string> GetPriceText()
        {
            return Common.GetElementsText(Locators.ProdcutFilter.outputPriceRange);
        }

        public static List<string> GetManufacturerName()
        {
            return Common.GetElementsText(Locators.ProdcutFilter.outputManufacturer);
        }
    }
}
