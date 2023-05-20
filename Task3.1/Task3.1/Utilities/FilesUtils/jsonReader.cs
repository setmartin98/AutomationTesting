using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Task3._1.Utilities.FilesUtils
{
    public class jsonReader
    {
        private static string ConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\Files\\config.json");
        public static string configFile = ConfigFile.Replace("bin\\Debug", string.Empty);
        private static string TestFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\Files\\TestData.json");
        public static string testFile = TestFile.Replace("bin\\Debug", string.Empty);
        private static string Test3File = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\Files\\TestDataStage3.json");
        private static string test3File = Test3File.Replace("bin\\Debug", string.Empty);
        public static string jsonFile = File.ReadAllText(test3File);
        public static string getTestDataValue(string nameValue)
        {
            string json = File.ReadAllText(testFile);
            JObject obj = JObject.Parse(json);
            return (string)obj[nameValue];
        }
        public static string getUserNumber(int i)
        {
            UsersTable usersTable = JsonConvert.DeserializeObject<UsersTable>(jsonFile);
            return usersTable.UsersList[i].UserNumber;
        }
        public static string getFirstName(int i)
        {
            UsersTable usersTable = JsonConvert.DeserializeObject<UsersTable>(jsonFile);
            return usersTable.UsersList[i].FirstName;
        }
        public static string getLastName(int i)
        {
            UsersTable usersTable = JsonConvert.DeserializeObject<UsersTable>(jsonFile);
            return usersTable.UsersList[i].LastName;
        }
        public static string getEmail(int i)
        {
            UsersTable usersTable = JsonConvert.DeserializeObject<UsersTable>(jsonFile);
            return usersTable.UsersList[i].Email;
        }
        public static string getAge(int i)
        {
            UsersTable usersTable = JsonConvert.DeserializeObject<UsersTable>(jsonFile);
            return usersTable.UsersList[i].Age;
        }
        public static string getSalary(int i)
        {
            UsersTable usersTable = JsonConvert.DeserializeObject<UsersTable>(jsonFile);
            return usersTable.UsersList[i].Salary;
        }
        public static string getDepartment(int i)
        {
            UsersTable usersTable = JsonConvert.DeserializeObject<UsersTable>(jsonFile);
            return usersTable.UsersList[i].Department;
        }
        public static List<string> getUserData(int i)
        {
            UsersTable usersTable = JsonConvert.DeserializeObject<UsersTable>(jsonFile);
            UserData User = usersTable.UsersList[i];
            List<string> extractedUserData = new List<string>
            {
                User.FirstName,
                User.LastName,
                User.Age,
                User.Email,
                User.Salary,
                User.Department
            };
            return extractedUserData;
        }
    }
}
