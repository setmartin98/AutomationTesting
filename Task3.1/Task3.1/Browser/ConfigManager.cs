using Task3._1.Utilities.FilesUtils;

namespace Task3._1.Browser
{
    public static class ConfigManager
    {
        public static string setBrowser()
        {
            
            string setbrowserfile = jsonReader.configFile;
            return SettingsReader.getValue(setbrowserfile, "browser");
        }
    }
}
