
using System;
using System.Collections.Generic;

namespace FrameworkProject.Page
{
    public class ProductFilterPage
    {
        public static void Open()
        {
            Common.ChangeWindowPosition();
            Common.MaximizeWindow();
            Driver.OpenURL("https://www.topocentras.lt/telefonai-navigacijos-auto-iranga/ismanieji-telefonai.html");
            Common.ClickElement(Locators.CookieConsent.cookieConsent);
        }

        public static void ClickInStoresCheckbox()
        {
            Common.ClickElement(Locators.ProdcutFilter.checkboxInStores);
        }

        public static void ClickFoldingPhonesCheckbox()
        {
            Common.ClickElement(Locators.ProdcutFilter.checkboxFoldingPhones);
        }

        public static void Click128gbCheckBox()
        {
            Common.ClickElement(Locators.ProdcutFilter.checkbox128gbInternalMemory);
        }

        public static List<string> GetProductsAvailabilityText()
        {
            return Common.GetElementsText(Locators.ProdcutFilter.outputProductAvailability);
        }

        public static List<string> GetProductsTypeText()
        {
            return Common.GetElementsText(Locators.ProdcutFilter.outputProductType);
        }

        public static List<string> GetProductsInternalMemoryText()
        {
            return Common.GetElementsText(Locators.ProdcutFilter.outputInternalMemory);
        }
    }
}
