using OpenQA.Selenium;
using Task3._1.Main;
using Task3._1.Utilities;

namespace Task3._1.Test.PO
{
    public class AlertsPage
    {
        private Page alertsPage = new Page(By.XPath("//div[@class='main-header' and contains(text(),'Alerts, Frame & Windows')]"), "Alerts Page Header");
        private Button alertsMenuButton = new Button(By.XPath("//span[contains(text(),'Alerts')]"), "Alerts menu button");
        private Label alertsForm = new Label(By.XPath("//div[@class='main-header' and contains(text(),'Alerts')]"), "Alerts Form");
        private Button alertButton = new Button(By.Id("alertButton"),"Alert Button");
        private AlertBox alertBox = new AlertBox();
        private Button confirmButton = new Button(By.Id("confirmButton"), "Confirm Button");
        private AlertBox confirmAlertBox = new AlertBox();
        private Label confirmResult = new Label(By.Id("confirmResult"), "Confirm Result Element");
        private Button promtButton = new Button(By.Id("promtButton"), "Promt Button");
        private AlertBox promtAlertBox = new AlertBox();
        private string randomText = RandomUtils.getRandomText();
        private Label promtResult = new Label(By.Id("promptResult"), "Prompt Result");
        private Button nestedFMenuButton = new Button(By.XPath("//span[contains(text(),'Nested Frames')]"), "Nested Frames menu button");
        private Button browserWMenuButton = new Button(By.XPath("//span[contains(text(),'Browser Windows')]"), "Browser Windows menu button");

        public bool isAlertsPageOpen()
        {
            return alertsPage.isPageOpened();
        }

        public void ClickAlertsMenuButton()
        {
            alertsMenuButton.click();
        }

        public bool isAlertsFormDisplayed()
        {
            return alertsForm.isDisplayed();
        }

        public void ClickAlertButton()
        {
            alertButton.click();
        }

        public string GetAlertBoxTest()
        {
            return alertBox.getAlertBoxText();
        }

        public void ClickAlertBoxOk()
        {
            alertBox.clickOk();
        }

        public bool isAlertBoxDisplayed()
        {
            return alertBox.isAlertDisplayed();
        }

        public void ClickConfirmButton() 
        {
            confirmButton.click();
        }

        public string GetConfirmAlertText()
        {
            return confirmAlertBox.getAlertBoxText();
        }

        public void ClickConfirmAlertOk()
        {
            confirmAlertBox.clickOk();
        }

        public bool isConfirmAlertDisplayed()
        {
            return confirmAlertBox.isAlertDisplayed();
        }

        public string GetConfirmResultText()
        {
            return confirmResult.getText();
        }

        public void ClickPromtButton()
        {
            promtButton.click();
        }

        public string GetPromtAlertBoxText()
        {
            return promtAlertBox.getAlertBoxText();
        }

        public void TypeInPromtAlertBox()
        {
            promtAlertBox.typeInAlertBox(randomText);
        }

        public void ClickPromtAlertOk()
        {
            promtAlertBox.clickOk();
        }

        public bool isPromtAlertDisplayed()
        {
            return promtAlertBox.isAlertDisplayed() ;
        }

        public string GetRandomText()
        {
            return randomText;
        }

        public string GetPromtResultText()
        {
            return promtResult.getText();
        }

        public void ClickNestedFramesButton()
        {
            nestedFMenuButton.click();
        }

        public void ClickBrowserWindowButton()
        {
            browserWMenuButton.click();
        }
    }
}
