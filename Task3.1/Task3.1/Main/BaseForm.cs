using OpenQA.Selenium;
using Task3._1.Utilities;

namespace Task3._1.Main
{
    public abstract class BaseForm
    {
        public By uniqueLocator;
        public string elementName;
        private IWebDriver driver = BrowserUtilies.getDriver();
        public WaitUtils waits = new WaitUtils();
        
        public BaseForm(By locator, string name)
        {
            uniqueLocator = locator;
            elementName = name;
        }
        
        public bool isPageOpened()
        {
            Logg.infoMessage(string.Format("Getting {0} Page Visibility", elementName));
            return waits.WaitForVisible(uniqueLocator).Displayed;
        }
    }
}
