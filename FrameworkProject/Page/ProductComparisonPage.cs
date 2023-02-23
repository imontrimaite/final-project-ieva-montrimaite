

using System;

namespace FrameworkProject.Page
{
    public class ProductComparisonPage
    {
        public static void Open()
        {
            Common.ChangeWindowPosition();
            Common.MaximizeWindow();
            Driver.OpenURL("https://www.topocentras.lt/mac/macbook-pro-m2.html");
            Common.ClickElement("//*[@class='CookieConsent-actions-F41']");
        }

        public static void SelectFirstComaprisonCheckbox()
        {
            string locator = "(//*[@class='Compare-compareContainer-uDf'])[1]";
            Common.ClickElement(locator);
        }

        public static void SelectSecondComaprisonCheckbox()
        {
            string locator = "(//*[@class='Compare-compareContainer-uDf'])[2]";
            Common.ClickElement(locator);
        }

        public static void ClickCompareButton()
        {
            string locator = "//*[@class='CompareModal-button-2EU']";
            Common.ClickElement(locator);            
        }

        public static void ToggleShowOnlyDifferences()
        {
            string locator = "(//*[@class='Toggle-switch-2Yk'])[2]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static string GetFirstColor()
        {
            string locator = "//*[@id='C-1-R-1']";
            return Common.GetElementText(locator);
        }

        public static string GetSecondColor()
        {
            string locator = "//*[@id='C-2-R-1']";
            return Common.GetElementText(locator);
        }

        public static string GetFirstItemCode()
        {
            string locator = "//*[@id='C-1-R-8']";
            return Common.GetElementText(locator);
        }

        public static string GetSecondItemCode()
        {
            string locator = "//*[@id='C-2-R-8']";
            return Common.GetElementText(locator);
        }

        public static string GetFirstManufacturerCode()
        {
            string locator = "//*[@id='C-1-R-11']";
            return Common.GetElementText(locator);
        }

        public static string GetSecondManufacturerCode()
        {
            string locator = "//*[@id='C-2-R-11']";
            return Common.GetElementText(locator);
        }
    }
}
