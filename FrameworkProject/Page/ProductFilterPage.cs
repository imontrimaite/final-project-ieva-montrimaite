
using System;
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

        public static void ClickAvailableInStoresCheckbox()
        {
            Common.ClickElement(Locators.ProdcutFilter.checkboxInStores);
        }

        public static void ClickPhilipsProducerCheckbox()
        {
            Common.ClickElement(Locators.ProdcutFilter.checkboxPhilips);
        }

        public static List<string> GetProductsAvailabilityText()
        {
            return Common.GetElementsText(Locators.ProdcutFilter.outputProductAvailability);
        }

        public static List<string> GetProducerText()
        {
            return Common.GetElementsText(Locators.ProdcutFilter.outputProducer);
        }
    }
}
