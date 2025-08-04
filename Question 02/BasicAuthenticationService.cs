namespace ConsoleApp1.Question_02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private User[] users = new User[]
        {
            new User("admin", "admin", "admin"),
            new User("hamza", "123456", "user")
        };

        public bool AuthenticateUser(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            foreach (User user in users)
            {
                if (user.Username == username && user.Role == role)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
