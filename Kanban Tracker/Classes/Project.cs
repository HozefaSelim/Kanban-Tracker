using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_Tracker.Classes
{
    public class Project
    {   
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Project(int projectID, string projectName, string projectDescription, string status, DateTime? startDate, DateTime? endDate)
        {
            ProjectID = projectID;
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
