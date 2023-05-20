using OpenQA.Selenium;
using Task3._1.Main;
using Task3._1.Utilities;

namespace Task3._1.Test.PO
{
    class FramesPage
    {
        private Page framesPage = new Page(By.XPath("//div[contains(text(),'Sample Iframe page')]"), "Frames Page");
        private string frame1Id = "frame1";
        private Label frame1 = new Label(By.Id("sampleHeading"), "Element inside frame 1");
        private string frame2Id = "frame2";
        private Label frame2 = new Label(By.Id("sampleHeading"), "Element inside frame 2");
        
        public bool isFramesPageOpen()
        {
            return framesPage.isPageOpened();
        }

        public string getFrame1Text()
        {
            BrowserUtilies.swithToFrame(frame1Id);
            string text = frame1.getText();
            BrowserUtilies.switchToCurrentPage();
            return text;
        }

        public string getFrame2Text()
        {
            BrowserUtilies.swithToFrame(frame2Id);
            string text = frame2.getText();
            BrowserUtilies.switchToCurrentPage();
            return text;
        }
    }
}
