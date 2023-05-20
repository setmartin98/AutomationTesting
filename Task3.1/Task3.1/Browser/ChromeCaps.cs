using OpenQA.Selenium.Chrome;
using Task3._1.Utilities.FilesUtils;

namespace Task3._1.Browser
{
    class ChromeCaps
    {

        public ChromeOptions getCaps()
        {
            string ChromeFile = jsonReader.configFile;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(SettingsReader.getValue(ChromeFile, "windowmode"));
            options.AddUserProfilePreference(SettingsReader.getValue(ChromeFile, "browsersetlang"), SettingsReader.getValue(ChromeFile, "chromelang"));
            return options;
        }
    }
}
