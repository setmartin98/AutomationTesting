using OpenQA.Selenium;
using Task3._1.Main;

namespace Task3._1.Test.PO
{
    public class MainPage
    {
        private new Page mainPage = new Page(By.XPath("//img[@alt='Selenium Online Training']"), "Selenium Welcome Image");
        private new Button AFWbutton = new Button(By.XPath("//div//*[contains(text(),'Alerts, Frame & Windows')]/.."), "Button: Alerts, Frame & Windows");
        private new Button elementsButton = new Button(By.XPath("//div//*[contains(text(),'Elements')]/.."), "Button: Alerts, Frame & Windows");

        public bool isMainPageOpen()
        {
            return mainPage.isPageOpened();
        }

        public void ClickAlertsFWButton()
        {
            AFWbutton.click();
        }

        public void ClickElementsButton()
        {
            elementsButton.click();
        }
    }
}
