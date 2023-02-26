using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;



namespace FrameworkProject
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void SendKeys(string locator, string textValue)
        {
            GetElement(locator).SendKeys(textValue);
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

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void RemoveText(string locator)
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

        internal static void WaitForElementAttributeToChangeValue(string locator, string attributeName, string attributeNewValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(attributeNewValue));
        }
    }
}
