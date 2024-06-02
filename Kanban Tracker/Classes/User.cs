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
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? UserRole { get; set; }
        public Project? Project { get; set; }
        public IList<UserProject> UserProjects { get; set; }
        public User(int userID, string username, string email, string password)
        {
            UserID = userID;
            Username = username;
            Email = email;
            Password = password;
            UserProjects = new List<UserProject>();
        }

        public int GetProjectIndex(Project project)
        {
            for (int i = 0; i<UserProjects.Count ; i++)
            {
                if(project.ProjectID == UserProjects[i].Project.ProjectID)
                {
                    return i;
                }
            }
            return -1;
        }
        public int GetProjectIndex(int projectID)
        {
            for (int i = 0; i < UserProjects.Count; i++)
            {
                if (projectID == UserProjects[i].Project.ProjectID)
                {
                    return i;
                }
            }
            return -1;
        }
        public void AddUserProject(Project project, string userRole)
        {
            UserProject newUserProject = new UserProject(Project, userRole);
            UserProjects.Add(newUserProject);
        }
        public IList<Project> GetUserProjects()
        {
            IList<Project> users = new List<Project>();

            foreach(UserProject up in UserProjects)
            {
                users.Add(up.Project);
            }

            return users;
        }
        public string GetUserRole(Project project)
        {
            int projectIndex = GetProjectIndex(project);

            if (projectIndex != -1)
            {
                return UserProjects[projectIndex].UserRole;
            }
            return "ERROR ( NO ROLE )";
        }
        public string GetUserRole(int ProjectID)
        {
            int projectIndex = GetProjectIndex(ProjectID);

            if(projectIndex != -1)
            {
               return UserProjects[projectIndex].UserRole;
            }
            return "ERROR ( NO ROLE )";
        }
    }
}
