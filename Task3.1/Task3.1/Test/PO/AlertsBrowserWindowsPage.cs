using OpenQA.Selenium;
using Task3._1.Main;

namespace Task3._1.Test.PO
{
    public class BrowserWindowsPage
    {
        private Page browserWPage = new Page(By.XPath("//div[@class='main-header' and contains(text(),'Browser Windows')]"), 
            "Browser Form Header");
        private Button newTabButton = new Button(By.Id("tabButton"), "New Tab Button");
        private Page samplePage = new Page(By.XPath("//h1[@id='sampleHeading' and contains(text(),'This is a sample page')]"),
            "Sample page");

        public bool isBrowserWindowPageOpen()
        {
            return browserWPage.isPageOpened();
        }

        public void ClickNewTabButton()
        {
            newTabButton.click();
        }

        public bool isNewTabOpen()
        {
            return samplePage.isPageOpened();
        }

    }
}
