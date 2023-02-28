using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FrameworkProject
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        /// <summary>
        /// Kažkodėl esant mažesniam ekranui, ne visi svetainės elementai egzistuojam html dom'e
        /// Tam, kad jie atsirastų dom'e, užtenka šiek tiek pascrollinti
        /// Tačiau netinkamo xpath atveju mes scrollintume amžinai
        /// Dėl to papildomai įvestas kiekis kartų kiek maksimaliai galima bandyti scrollinti
        /// </summary>
        internal static void ScrollAndClickElement(string locator)
        {
            bool elementIsClickable = false;
            int maxTries = 5;
            int attempt = 0;
            // Kartojame tol, kol elementą galėsime sėkmingai paspausti be exception
            // Arba maksimaliai 5 kartus
            while (!elementIsClickable)
            {
                try
                {
                    // Bandome spausti elementą
                    GetElement(locator).Click();
                    // Jei pavyko paspausti, toliau nebandysime
                    elementIsClickable = true;
                }
                // Jei nepavyko paspausti
                catch (Exception ex)
                {
                    attempt++;
                    // Tikriname tik tuos exceptionus kurie mums aktualūs
                    // Jei yra kažkuris iš jų IR dar neviršijome leistinų bandymų skaičiaus
                    if ((ex is ElementClickInterceptedException || ex is NoSuchElementException) && attempt <= maxTries)
                    {
                        // Tuomet scrolliname šiek tiek žemyn
                        Driver.GetDriver().ExecuteJavaScript("window.scrollBy(0,50)");
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }
        }

        internal static void SendKeys(string locator, string textValue)
        {
            GetElement(locator).SendKeys(textValue);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ClearText(string locator)
        {
            IWebElement toClear = Driver.GetDriver().FindElement(By.XPath(locator));
            toClear.SendKeys(Keys.Control + "a");
            toClear.SendKeys(Keys.Delete);
        }

        internal static void MoveMouseToElement(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.MoveToElement(element);
            actions.Perform();
        }

        internal static List<string> GetElementsText(string locator)
        {
            List<IWebElement> elements = GetElements(locator);
            List<string> result = new List<string>();

            foreach (IWebElement element in elements)
            {
                result.Add(element.Text);
            }
            return result;
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void WaitForElementAttributeToChangeValue(string locator, string attributeName, string attributeNewValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(attributeNewValue));
        }

        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }
    }
}
