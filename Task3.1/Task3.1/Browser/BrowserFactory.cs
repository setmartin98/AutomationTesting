using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace Task3._1.Browser
{
    public static class BrowserFactory
    {

        private static BrowserCapabilities chrome = new();
        private static BrowserCapabilities firefox = new();
        private static IWebDriver driver;
        public static IWebDriver BrowserChrome()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = chrome.getChromeCaps();
            return driver;
        }
        public static IWebDriver BrowserFirefox()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            driver = firefox.getFirefoxCaps();
            return driver;
        }
        public static IWebDriver Browser(string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    driver = BrowserFactory.BrowserChrome();
                    return driver;
                case "google chrome":
                    driver = BrowserFactory.BrowserChrome();
                    return driver;
                case "mozilla":
                    driver = BrowserFactory.BrowserFirefox();
                    return driver;
                case "firefox":
                    driver = BrowserFactory.BrowserFirefox();
                    return driver;
                case "mozilla firefox":
                    driver = BrowserFactory.BrowserFirefox();
                    return driver;
                default:
                    driver = BrowserFactory.BrowserChrome();
                    return driver;
            }
        }
    }
}
