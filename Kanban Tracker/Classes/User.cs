using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_Tracker.Classes
{
    public class User
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? UserRole { get; set; }
        public Project? Project { get; set; }
        public IList<UserProject> UserProjects { get; set; }
        public User(string userID, string username, string email, string password)
        {
            UserID = userID;
            Username = username;
            Email = email;
            Password = password;
            UserProjects = new List<UserProject>();
        }
        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            UserProjects = new List<UserProject>();
        }
    }
}
