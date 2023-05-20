using OpenQA.Selenium;
using Task3._1.Utilities.FilesUtils;

namespace Task3._1.Utilities
{
    public static class BrowserUtilies
    {
        public static IWebDriver getDriver()
        {
            return Singleton.Driver();
        }
        public static void goToUrl()
        {
            ;
            Singleton.Driver().Navigate().GoToUrl(SettingsReader.getValue(jsonReader.configFile, "url"));
        }

        public static IAlert switchToAlert()
        {
            return Singleton.Driver().SwitchTo().Alert();
        }

        public static void switchToCurrentPage()
        {
            Singleton.Driver().SwitchTo().DefaultContent();
        }

        public static void ScrollDown()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Singleton.Driver();
            jsExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        public static void ScrollUp()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Singleton.Driver();
            jsExecutor.ExecuteScript("window.scrollTo(0, 0);");
        }

        public static void swithToFrame(string frameID)
        {
            Singleton.Driver().SwitchTo().Frame(frameID);
        }

        public static void swithToFrameByWebElement(IWebElement frame)
        {
            Singleton.Driver().SwitchTo().Frame(frame);
        }

        public static void switchToTab(int tabNumber)
        {
            Singleton.Driver().SwitchTo().Window(Singleton.Driver().WindowHandles[tabNumber]);
        }

        public static void closeCurrentTab()
        {
            Singleton.Driver().Close();
        }

        public static void ScrollMid()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Singleton.Driver();
            jsExecutor.ExecuteScript("window.scrollTo(0, window.innerHeight/2);");
        }
        public static void quit()
        {
            Singleton.Driver().Quit();
        }
    }
}
