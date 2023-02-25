
using System;
using System.Collections.Generic;

namespace FrameworkProject.Page
{
    public class AddToCartPage
    {
        public static void Open()
        {
            Common.ChangeWindowPosition();
            Common.MaximizeWindow();
            Driver.OpenURL("https://www.topocentras.lt/telefonai-navigacijos-auto-iranga/ismanieji-telefonai.html");
            Common.ClickElement(Locators.AddToCart.cookieConsent);
        }

        public static void ClickAddToCartButtonInTheCategoryPage()
        {
            Common.ClickElement(Locators.AddToCart.buttonAddToCartCategoryPage);
        }
        public static void ClickContinueShoppingButtonInTheCategoryPage()
        {
            Common.WaitForElementToBeVisible(Locators.AddToCart.buttonContinueShoppingCategoryPage);
            Common.ClickElement(Locators.AddToCart.buttonContinueShoppingCategoryPage);
        }

        public static void SelectProduct()
        {
            Common.ClickElement(Locators.AddToCart.buttonSelectProduct);
        }

        public static void ClickAddToCartButtonInTheProductPage()
        {
            Common.WaitForElementToBeVisible(Locators.AddToCart.buttonAddToCartProductPage);
            Common.ClickElement(Locators.AddToCart.buttonAddToCartProductPage);
        }


        public static void ClickContinueShoppingButtonInTheProductPage()
        {
            Common.WaitForElementToBeVisible(Locators.AddToCart.buttonContinueShoppingProductPage);
            Common.ClickElement(Locators.AddToCart.buttonContinueShoppingProductPage);
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

        public static List<string> GetProductsText()
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
