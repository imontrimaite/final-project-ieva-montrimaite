
using System;

namespace FrameworkProject.Page
{
    public class ClientRegistrationPage
    {
        public static void Open()
        {
            Driver.OpenURL("https://www.topocentras.lt/kliento-registracija");
        }

        public static void InputEmail(string email)
        {
            Common.SendKeys(Locators.SuccessfulRegistration.inputEmail, email);
        }

        public static void InputPassword(string password)
        {
            Common.SendKeys(Locators.SuccessfulRegistration.inputPassword, password);
        }

        public static void ClickBothCheckboxes()
        {
            Common.ClickElements(Locators.SuccessfulRegistration.checkboxes);
        }

        public static void ClickRegisterButton()
        {
            Common.ClickElement(Locators.SuccessfulRegistration.buttonRegister);
        }

        public static string GetRegistrationConfirmationMessage()
        {
            Common.WaitForElementToBeVisible(Locators.SuccessfulRegistration.messageConfirmation);
            return Common.GetElementText(Locators.SuccessfulRegistration.messageConfirmation);
        }

        public static string GetErrorMessage()
        {
            return Common.GetElementText(Locators.SuccessfulRegistration.messagePwrdError);
        }

        public static void RemoveIncorrectPassword()
        {
            Common.RemoveText(Locators.SuccessfulRegistration.inputPassword);
        }

        public static bool IsErrorMessagePresent()
        {
            return Common.WaitForElementToNotBeVisible(Locators.SuccessfulRegistration.messagePwrdError);
        }
    }
}
