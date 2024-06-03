using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_Tracker.Classes
{
    public class UserProject
    {
        public Project Project { get; set; }
        public string UserRole { get; set; }
        public IList<Issue> UserIssues { get; set; }

        public UserProject(Project project, string userRole)
        {
            this.Project = project;
            this.UserRole = userRole;
            UserIssues = new List<Issue>();
        }
    }
}
