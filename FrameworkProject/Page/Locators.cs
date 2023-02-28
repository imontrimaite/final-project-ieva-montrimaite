
namespace FrameworkProject.Page
{
    internal class Locators
    {
        internal class CookieConsent
        {
            internal static string cookieConsent = "//*[@class='CookieConsent-actions-F41']";
        }
        internal class ClientRegistration
        {
            internal static string inputEmail = "//*[@id='email']";
            internal static string inputPassword = "//*[@id='password']";
            internal static string checkboxes = "//*[@class='Checkbox-checkBox-1fD 767']";
            internal static string buttonRegister = "//*[@data-test-id='register-btn']";
            internal static string messageConfirmation = "//*[@class='SuccessDisplay-body-5bU']";
            internal static string messagePwrdError = "//*[@data-test-id='password-error']";
        }

        internal class ProductComparison
        {
            internal static string firstCheckbox = "(//*[@class='Compare-compareContainer-uDf'])[1]";
            internal static string secondCheckbox = "(//*[@class='Compare-compareContainer-uDf'])[2]";
            internal static string buttonCompare = "//*[@class='CompareModal-button-2EU']";
            internal static string toggle = "(//*[@class='Toggle-switch-2Yk'])[2]";
            internal static string firstColor = "//*[@id='C-1-R-1']";
            internal static string secondColor = "//*[@id='C-2-R-1']";
            internal static string firstItemCode = "//*[@id='C-1-R-8']";
            internal static string secondItemCode = "//*[@id='C-2-R-8']";
            internal static string firstManucafturerCode = "//*[@id='C-1-R-11']";
            internal static string secondManufacturerCode = "//*[@id='C-2-R-11']";
        }

        internal class AddToCart
        {
            internal static string buttonAddToCart = "(//*[@data-test-id='add-to-cart-btn'])[1]";
            internal static string buttonContinueShopping = "//*[@data-test-id='add-to-cart-modal-continue-btn']";
            internal static string buttonSelectProduct = "(//*[@class='ProductGridItem-link-3xD'])[4]";
            internal static string hoverAddToCart = "(//*[@data-test-id='minicart'])[1]";
            internal static string buttonBuy = "(//*[@data-test-id='checkout-link'])[1]";
            internal static string buttonIncreaseQuantity = "(//*[@data-test-id='quantity-increase-btn'])[1]";
            internal static string nameProduct = "//*[@class='Products-productName-2uF']";
            internal static string productQuantity = "(//*[@data-test-id='quantity-input'])[1]";
        }

        internal class ProdcutFilter
        {
            internal static string checkboxUpTo300eur = "//*[text()='Iki 300 €']";
            internal static string checkboxPhilips = "//*[text()='PHILIPS']";
            internal static string outputManufacturer = "//*[@class='ProductGridItem-productName-3ZD']";
            internal static string outputPriceRange = "//*[@class='ProductGridItem-productPrice-1eJ']";
        }
    }
}
