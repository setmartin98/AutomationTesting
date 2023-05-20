using OpenQA.Selenium;
using Task3._1.Main;

namespace Task3._1.Test.PO
{
    public class NestedFPage 
    {
        private Page nestedPage = new Page(By.XPath("//div[contains(text(),'Sample Nested Iframe page')]"),"Nested Frames Page");
        private Label childLabel = new Label(By.XPath("//p[contains(text(),'Child Iframe')]"), "Child Label");
        private Label childFrame = new Label(By.XPath("//iframe[@srcdoc='<p>Child Iframe</p>']"), "Child Frame");
        private Label parentLabel = new Label(By.XPath("//body[contains(text(),'Parent frame')]"), "Parent Label");
        private string frameParentId = "frame1";
        private Button frameButton = new Button(By.XPath("//li[@id='item-2']//span[contains(text(),'Frames')]"), "Frames button");

        public bool isNestedPageOpen()
        {
            return nestedPage.isPageOpened();
        }

        public string GetParentID()
        {
            return frameParentId;
        }

        public string GetParentLabelText()
        {
            return parentLabel.getText();
        }

        public IWebElement GetChildFrame()
        {
            return childFrame.getElement();
        }

        public string GetChildLabelText()
        {
            return childLabel.getText();
        }

        public void ClickFrameButton()
        {
            frameButton.click();
        }
    }
}
