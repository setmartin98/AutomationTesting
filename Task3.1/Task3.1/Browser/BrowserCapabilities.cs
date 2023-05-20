using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Task3._1.Browser

{
    public class BrowserCapabilities
    {
        static FirefoxCaps firecaps = new FirefoxCaps();
        static ChromeCaps chromecaps = new ChromeCaps();

        public IWebDriver getChromeCaps()
        {
            return new ChromeDriver(chromecaps.getCaps());
        }
        public IWebDriver getFirefoxCaps()
        {
            return new FirefoxDriver(firecaps.getCaps());
        }
    }
}
