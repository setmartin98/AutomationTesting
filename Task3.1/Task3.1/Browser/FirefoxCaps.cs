using OpenQA.Selenium.Firefox;
using System.Reflection;
using Task3._1.Utilities.FilesUtils;

namespace Task3._1.Browser
{
    class FirefoxCaps
    {


        public FirefoxOptions getCaps()
        {

            string FirefoxFile = jsonReader.configFile;
            FirefoxOptions options = new FirefoxOptions();
            FirefoxProfile profile = new FirefoxProfile();
            profile.SetPreference(SettingsReader.getValue(FirefoxFile, "browsersetlang"), SettingsReader.getValue(FirefoxFile, "firefoxsetlang"));
            options.Profile = profile;
            return options;
        }
    }
}
