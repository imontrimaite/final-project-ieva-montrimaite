using FrameworkProject.Page;
using NUnit.Framework;
using System.Collections.Generic;
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

            ClientRegistrationPage.InputEmail("valid@email.com");
            ClientRegistrationPage.InputPassword("Test12?Pwrd!");
            ClientRegistrationPage.ClickBothCheckboxes();
            ClientRegistrationPage.ClickRegisterButton();

            string actualMessage = ClientRegistrationPage.GetRegistrationConfirmationMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void RegistrationWithInvalidPassword()
        {
            string expectedMessage = "Slaptažodį turi sudaryti";

            ClientRegistrationPage.InputEmail("testemail2@email.com");

            List<string> passwords = new List<string>() {"Test", "testpassword?1", "Testpassword?", "Testpassword1", "TESTPWRD?1"};

            foreach (string password in passwords)
            {
                ClientRegistrationPage.InputPassword(password);
                ClientRegistrationPage.ClickRegisterButton();

                string actualMessage = ClientRegistrationPage.GetErrorMessage();

                Assert.IsTrue(actualMessage.Contains(expectedMessage));

                ClientRegistrationPage.ClearPasswordField();
            }
        }
    }
}
