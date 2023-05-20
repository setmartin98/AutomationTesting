namespace Task3._1.Utilities.FilesUtils
{
    public class UserData
    {
        public string UserNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public string Salary { get; set; }
        public string Department { get; set; }

        public UserData(string userNumber, string firstName, string lastName,
            string email, string age, string salary, string department)
        {
            UserNumber = userNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            Salary = salary;
            Department = department;
        }


    }
}
