﻿using FrameworkProject.Page;
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

            ClientRegistrationPage.InputRandomValidEmail();
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

            ClientRegistrationPage.InputRandomValidEmail();

            List<string> passwords = new List<string>() {"Test", "testpassword?1", "Testpassword?", "Testpassword1", "TESTPWRD?1"};

            // Vienas iš būdų kaip "paslėpti" visą foreach į POM vidų
            // Bet šiaip šiuo konkrečiu atveju pats foreach nėra labai sudėtingas, taigi nebūtų didelė problema jį palikti čia
            Assert.IsTrue(ClientRegistrationPage.PasswordsAreInvalid(passwords, expectedMessage));
        }
    }
}
