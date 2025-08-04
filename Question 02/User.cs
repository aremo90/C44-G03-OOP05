using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Question_02
{
    internal class User
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

        public User(string? username, string? password, string? role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
