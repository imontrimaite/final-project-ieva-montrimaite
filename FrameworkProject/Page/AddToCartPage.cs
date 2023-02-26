
using System;
using System.Collections.Generic;

namespace FrameworkProject.Page
{
    public class AddToCartPage
    {
        public static void Open()
        {
            Driver.OpenURL("https://www.topocentras.lt/telefonai-navigacijos-auto-iranga/ismanieji-telefonai.html");
            Common.ClickElement(Locators.CookieConsent.cookieConsent);
        }

        public static void ClickAddToCartButton()
        {
            Common.ClickElement(Locators.AddToCart.buttonAddToCart);
        }
        public static void ClickContinueShoppingButton()
        {
            Common.WaitForElementToBeVisible(Locators.AddToCart.buttonContinueShopping);
            Common.ClickElement(Locators.AddToCart.buttonContinueShopping);
        }

        public static void SelectProduct()
        {
            Common.ClickElement(Locators.AddToCart.buttonSelectProduct);
        }

        public static void ClickAddToCartButtonInTheProductPage()
        {
            Common.WaitForElementToBeVisible(Locators.AddToCart.buttonAddToCart);
            Common.ClickElement(Locators.AddToCart.buttonAddToCart);
        }

        public static void HoverOnCartButton()
        {
            Common.MoveMouseToElement(Locators.AddToCart.hoverAddToCart);
        }
        public static void ClickBuyButton()
        {
            Common.ClickElement(Locators.AddToCart.buttonBuy);
        }

        public static void ClickQuantityButton()
        {
            Common.WaitForElementToBeVisible(Locators.AddToCart.buttonIncreaseQuantity);
            Common.ClickElement(Locators.AddToCart.buttonIncreaseQuantity);
        }

        public static List<string> GetFullProductNames()
        {
            return Common.GetElementsText(Locators.AddToCart.nameProduct);
        }

        public static string GetProductQuantity()
        {
            Common.WaitForElementAttributeToChangeValue(Locators.AddToCart.productQuantity, "value", "2");
            return Common.GetAttributeValue(Locators.AddToCart.productQuantity, "value");
        }
    }
}
