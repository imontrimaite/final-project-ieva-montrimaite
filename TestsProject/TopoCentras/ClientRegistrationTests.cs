
using FrameworkProject;
using FrameworkProject.Page;
using NUnit.Framework;

namespace TestsProject.TopoCentras
{
    internal class ClientRegistrationTests
    {
        [SetUp]

        public void Setup()
        {
            Driver.SetupDriver();
            ClientRegistrationPage.Open();
        }

        [Test]
        public void SuccessfulClientRegistration()
        {
            string expectedMessage = "Nurodytu el.paštu išsiuntėmė laišką registracijos patvirtinimui.";

            ClientRegistrationPage.InputEmail("testemail2@email.com");
            ClientRegistrationPage.InputPassword("Test12?Pwrd!");
            ClientRegistrationPage.ClickBothCheckboxes();
            ClientRegistrationPage.ClickRegisterButton();

            string actualMessage = ClientRegistrationPage.GetRegistrationConfirmationMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
