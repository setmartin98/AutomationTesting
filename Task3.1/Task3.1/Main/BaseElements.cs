using OpenQA.Selenium;
using Task3._1.Browser;
using Task3._1.Utilities;

namespace Task3._1.Main
{
    public abstract class BaseElements
    {

        protected By uniqueLocator;
        protected string elementName;
        protected IWebDriver driver = BrowserUtilies.getDriver();
        protected WaitUtils waits = new WaitUtils();
        public BaseElements(By locator, string name)
        {
            uniqueLocator = locator;
            elementName = name;
        }
        public IWebElement getElement()
        {
            Logg.infoMessage(string.Format("Getting {0} Element", elementName));
            waits.WaitFor(uniqueLocator);
            return driver.FindElement(uniqueLocator);
        }

        public void click()
        {
            Logg.infoMessage(string.Format("Clicking {0} element", elementName));
            waits.WaitForClick(uniqueLocator);
            driver.FindElement(uniqueLocator).Click();
        }

        public string getText()
        {
            waits.WaitFor(uniqueLocator);
            return driver.FindElement(uniqueLocator).Text;
        }

        public bool isDisplayed()
        {
            Logg.infoMessage(string.Format("Getting {0} Element Visibility", elementName));
            try
            {
                waits.WaitFor(uniqueLocator);
                return driver.FindElement(uniqueLocator).Displayed;
            }
            catch { return false; }
        }

        public string getAttrribute(string attribute)
        {
            waits.WaitFor(uniqueLocator);
            return driver.FindElement(uniqueLocator).GetAttribute(attribute);
        }

        public IReadOnlyCollection<IWebElement> getElements()
        {
            waits.WaitFor(uniqueLocator);
            return driver.FindElements(uniqueLocator);
        }

        public bool isNotDisplayed()
        {
            Logg.infoMessage(string.Format("Getting {0} Element Visibility", elementName));

                return waits.WaitForInvisible(uniqueLocator);
        }
    }
}
