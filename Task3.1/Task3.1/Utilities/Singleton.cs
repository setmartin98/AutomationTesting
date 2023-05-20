using OpenQA.Selenium;
using Task3._1.Browser;

namespace Task3._1.Utilities
{
    public static class Singleton
    {
        private static IWebDriver driver;
        public static IWebDriver Driver()
        {
            if (driver == null)
            {
                string setbrowserfile = "C:\\Users\\setos\\source\\repos\\s.martinezrepo\\Task3.1\\Task3.1\\Files\\config.json";
                driver = BrowserFactory.Browser(ConfigManager.setBrowser());
            }
            return driver;
        }
       
    }
}
