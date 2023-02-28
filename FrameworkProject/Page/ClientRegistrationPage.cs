using System.Collections.Generic;

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
            Common.SendKeys(Locators.ClientRegistration.inputEmail, email);
        }

        public static void InputPassword(string password)
        {
            Common.SendKeys(Locators.ClientRegistration.inputPassword, password);
        }

        public static void ClickBothCheckboxes()
        {
            Common.ClickElements(Locators.ClientRegistration.checkboxes);
        }

        public static void ClickRegisterButton()
        {
            Common.ClickElement(Locators.ClientRegistration.buttonRegister);
        }

        public static string GetRegistrationConfirmationMessage()
        {
            Common.WaitForElementToBeVisible(Locators.ClientRegistration.messageConfirmation);
            return Common.GetElementText(Locators.ClientRegistration.messageConfirmation);
        }

        public static string GetErrorMessage()
        {
            return Common.GetElementText(Locators.ClientRegistration.messagePwrdError);
        }

        public static void ClearPasswordField()
        {
            Common.ClearText(Locators.ClientRegistration.inputPassword);
        }

        public static bool PasswordsAreInvalid(List<string> passwords, string expectedMessage)
        {
            foreach (string password in passwords)
            {
                InputPassword(password);
                ClickRegisterButton();

                // Jeigu nuskaitome error žinutę ir joje nėra ko tikimės, iškart grąžiname false
                if (!GetErrorMessage().Contains(expectedMessage))
                {
                    return false;
                }

                ClearPasswordField();
            }

            // Jei patikrinus visus slaptažodžius atsidūrėme čia, vadinasi visi jie yra nevalidūs ir grąžiname true
            return true;
        }
    }
}
