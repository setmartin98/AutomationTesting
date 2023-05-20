using OpenQA.Selenium;
using Task3._1.Browser;
using Task3._1.Utilities;

namespace Task3._1.BaseElement
{
    public abstract class BaseElement
    {
   
        By uniqueLocator;
        string elementName;
        private IWebDriver driver = BrowserUse.getDriver();
        WaitUtils waits = new WaitUtils(); 
        public BaseElement(By locator, string name)
        {
            uniqueLocator = locator;
            elementName = name;
        }
        public IWebElement getElement()
        {
            waits.WaitFor(uniqueLocator);
            return driver.FindElement(uniqueLocator);
        }
        public void click()
        {
            waits.WaitFor(uniqueLocator).Click();
        }

        public string getText() 
        {
            waits.WaitFor(uniqueLocator);
            return driver.FindElement(uniqueLocator).Text; 
        }
        public bool isDisplayed()
        {
            waits.WaitFor(uniqueLocator);
            return driver.FindElement(uniqueLocator).Displayed;
        }
        public string getAttrribute (string attribute)
        {
            waits.WaitFor(uniqueLocator);
            return driver.FindElement(uniqueLocator).GetAttribute(attribute);
        }
    }
}
