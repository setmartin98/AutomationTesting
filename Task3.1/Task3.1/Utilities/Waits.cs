using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Task3._1.Utilities.FilesUtils;

namespace Task3._1.Utilities
{
    public class WaitUtils
    {
        private static string file = "C:\\Users\\setos\\source\\repos\\s.martinezrepo\\Task3.1\\Task3.1\\Files\\config.json";
        private static double waitTime = Convert.ToDouble(SettingsReader.getValue(file, "waitstime"));
        private static WebDriverWait wait = new(Singleton.Driver(), TimeSpan.FromSeconds(waitTime));

        public IWebElement WaitFor(By locator)
        {
            IWebElement element = wait.Until(e => e.FindElement(locator));
            return element;
        }

        public void WaitForClick(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public IWebElement WaitForVisible(By locator)
        {
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return element;
        }

        public bool WaitForInvisible(By locator)
        {
            return wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }
    }
}
