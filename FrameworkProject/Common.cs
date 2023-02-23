using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;



namespace FrameworkProject
{
    internal class Common
    {
        internal static void ChangeWindowPosition()
        {
            Driver.GetDriver().Manage().Window.Position = new System.Drawing.Point(2000, 1);
        }

        internal static void MaximizeWindow()
        {
            Driver.GetDriver().Manage().Window.Maximize();
        }


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
    }
}
