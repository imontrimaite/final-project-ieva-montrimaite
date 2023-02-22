
using System;

namespace FrameworkProject.Page
{
    public class ClientRegistrationPage
    {
        public static void Open()
        {
            Common.ChangeWindowPosition();
            Common.MaximizeWindow();
            Driver.OpenURL("https://www.topocentras.lt/kliento-registracija");
        }

        public static void InputEmail(string email)
        {
            string locator = "//*[@id='email']";
            Common.SendKeys(locator, email);
        }

        public static void InputPassword(string password)
        {
            string locator = "//*[@id='password']";
            Common.SendKeys(locator, password);
        }

        public static void ClickBothCheckboxes()
        {
            string locator = "//*[@class='Checkbox-checkBox-1fD 767']";
            Common.ClickElements(locator);
        }

        public static void ClickRegisterButton()
        {
            string locator = "//*[@data-test-id='register-btn']";
            Common.ClickElement(locator);
        }

        public static string GetRegistrationConfirmationMessage()
        {
            string locator = "//*[@class='SuccessDisplay-body-5bU']";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }
    }
}
