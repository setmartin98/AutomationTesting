using OpenQA.Selenium;
using Task3._1.Main;

namespace Task3._1.Test.PO
{
    public class LinksPage
    {
        private Button elementsButton = new Button(By.XPath("//div[contains(text(),'Elements')]"), "Elements Button");
        private Page linksPage = new Page(By.XPath("//div[@class='main-header' and contains(text(),'Links')]"),
           "Browser Form Header");
        private Button linksMenuButton = new Button(By.XPath("//li//span[contains(text(),'Links')]/.."), "Links menu button");
        private Button homeButton = new Button(By.XPath("//a[@id='simpleLink' and contains(text(),'Home')]"), "Home Button");

        public void ClickElementsButton()
        {
            elementsButton.click();
        }
        public void ClickLinksMenuButton() 
        {
            linksMenuButton.click();
        }

        public bool isLinksPageOpen()
        {
            return linksPage.isPageOpened();
        }

        public void ClickHomeButton()
        {
            homeButton.click();
        }
    }
}
