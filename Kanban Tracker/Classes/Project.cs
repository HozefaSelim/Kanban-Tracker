using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_Tracker.Classes
{
    public class Project
    {   
        public string ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Project(string projectID, string projectName, string projectDescription, DateTime? startDate, DateTime? endDate)
        {
            ProjectID = projectID;
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            StartDate = startDate;
            EndDate = endDate;
        }
        public Project(string projectName, string projectDescription, DateTime? endDate)
        {
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            EndDate = endDate;
        }
    }
}
