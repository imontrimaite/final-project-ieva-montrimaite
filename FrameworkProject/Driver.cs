
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrameworkProject
{
    public class Driver
    {
        private static IWebDriver driver;
        public static void SetupDriver()
        {
            driver = new ChromeDriver();
        }
        public static IWebDriver GetDriver()
        {
            return driver;
        }
        public static void OpenURL(string url)
        {
            driver.Url = url;
        }
        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
