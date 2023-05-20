using Task3._1.Utilities;

namespace Task3._1.Main
{
    public abstract class BaseTest
    {
        public void beforeStartTest()
        {
            Logg.loadLoggerConfig();
            Logg.infoMessage("Starting Test");
            BrowserUtilies.goToUrl();
        }

        public void afterFinishingTest() 
        {
            Logg.loadLoggerConfig();
            Logg.infoMessage("Test Finished");
            BrowserUtilies.quit();
        }
    
    }
}
