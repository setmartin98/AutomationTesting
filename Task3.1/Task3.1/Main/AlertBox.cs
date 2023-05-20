using OpenQA.Selenium;
using Task3._1.Utilities;

namespace Task3._1.Main
{
    public class AlertBox
    {
        IAlert alert;
        public  AlertBox()
        {
           
        }
        public string getAlertBoxText()
        {
            alert = BrowserUtilies.switchToAlert();
            return alert.Text;
        }

        public void clickOk()
        {
            alert = BrowserUtilies.switchToAlert();
            alert.Accept(); 
        }

        public void typeInAlertBox(string text)
        {
            alert = BrowserUtilies.switchToAlert();
            alert.SendKeys(text);
        }

        public bool isAlertDisplayed()
        { 
            try
            {
                alert = BrowserUtilies.switchToAlert();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        
    }
}
