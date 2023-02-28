namespace FrameworkProject.Page
{
    public class ProductComparisonPage
    {
        public static void Open()
        {
            Driver.OpenURL("https://www.topocentras.lt/mac/macbook-pro-m2.html");
            Common.ClickElement(Locators.CookieConsent.cookieConsent);
        }

        public static void SelectFirstComaprisonCheckbox()
        {
            Common.ScrollAndClickElement(Locators.ProductComparison.firstCheckbox);
        }

        public static void SelectSecondComaprisonCheckbox()
        {
            Common.ScrollAndClickElement(Locators.ProductComparison.secondCheckbox);
        }

        public static void ClickCompareButton()
        {
            Common.WaitForElementToBeClickable(Locators.ProductComparison.buttonCompare);
            Common.ClickElement(Locators.ProductComparison.buttonCompare);            
        }

        public static void ToggleShowOnlyDifferences()
        {
            Common.WaitForElementToBeVisible(Locators.ProductComparison.toggle);
            Common.ClickElement(Locators.ProductComparison.toggle);
        }

        public static string GetFirstColor()
        {
            return Common.GetElementText(Locators.ProductComparison.firstColor);
        }

        public static string GetSecondColor()
        {
            return Common.GetElementText(Locators.ProductComparison.secondColor);
        }

        public static string GetFirstItemCode()
        {
            return Common.GetElementText(Locators.ProductComparison.firstItemCode);
        }

        public static string GetSecondItemCode()
        {
            return Common.GetElementText(Locators.ProductComparison.secondItemCode);
        }

        public static string GetFirstManufacturerCode()
        {
            return Common.GetElementText(Locators.ProductComparison.firstManucafturerCode);
        }

        public static string GetSecondManufacturerCode()
        {
            return Common.GetElementText(Locators.ProductComparison.secondManufacturerCode);
        }
    }
}
