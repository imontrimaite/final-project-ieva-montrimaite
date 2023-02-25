
using FrameworkProject;
using FrameworkProject.Page;
using NUnit.Framework;
using TestsProject.BaseTests;

namespace TestsProject.TopoCentras
{
    internal class ClientRegistrationTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            ClientRegistrationPage.Open();
        }

        [Test]
        public void SuccessfulClientRegistration()
        {
            string expectedMessage = "Nurodytu el.paštu išsiuntėmė laišką registracijos patvirtinimui.";

            ClientRegistrationPage.InputEmail("testemail4@email.com");
            ClientRegistrationPage.InputPassword("Test12?Pwrd!");
            ClientRegistrationPage.ClickBothCheckboxes();
            ClientRegistrationPage.ClickRegisterButton();

            string actualMessage = ClientRegistrationPage.GetRegistrationConfirmationMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void RegistrationWithIncorrectPassword()
        {
            string expectedMessage = "Slaptažodį turi sudaryti";

            ClientRegistrationPage.InputEmail("testemail2@email.com");
            ClientRegistrationPage.InputPassword("Test");
            ClientRegistrationPage.ClickRegisterButton();

            string actualMessage = ClientRegistrationPage.GetErrorMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));

            ClientRegistrationPage.RemoveIncorrectPassword();
            ClientRegistrationPage.InputPassword("testpassword?1");

            actualMessage = ClientRegistrationPage.GetErrorMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));

            ClientRegistrationPage.RemoveIncorrectPassword();
            ClientRegistrationPage.InputPassword("Testpassword?");

            actualMessage = ClientRegistrationPage.GetErrorMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));

            ClientRegistrationPage.RemoveIncorrectPassword();
            ClientRegistrationPage.InputPassword("Testpassword1");

            actualMessage = ClientRegistrationPage.GetErrorMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));

            ClientRegistrationPage.RemoveIncorrectPassword();
            ClientRegistrationPage.InputPassword("Testpassword1?");

            bool elementNotPresent = ClientRegistrationPage.IsErrorMessagePresent();

            Assert.IsTrue(elementNotPresent);
        }
    }
}
