using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1.Utilities.FilesUtils
{
    public static class SettingsReader
    {
        public static void readFile(string file)
        {
            string json = File.ReadAllText(file);
        }
        public static string getValue(string filelocator, string nameValue)
        {
            string json = File.ReadAllText(filelocator);
            JObject obj = JObject.Parse(json);
            return (string)obj[nameValue];
        }

    }
}
