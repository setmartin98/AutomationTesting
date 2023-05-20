namespace Task3._1.Utilities.FilesUtils
{
    public class UsersTable
    {
        public List<UserData> UsersList { get; set; }

        public UsersTable()
        {
            UsersList = new List<UserData>();
        }

        public void AddUser(UserData user)
        {
            UsersList.Add(user);
        }
    }
}
