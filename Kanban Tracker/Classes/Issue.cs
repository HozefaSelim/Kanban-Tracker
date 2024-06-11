using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_Tracker.Classes
{
    public class Issue
    {
        public int IssueID { get; set; }
        public string IssueName { get; set; }
        public string IssueDescription { get; set; }

        public string IssueType { get; set; }

        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Epic Epic { get; set; }
        public User AssignedUser { get; set; }

        public Issue(string issueName, string issueType,string issueDescription, string status)
        {
            IssueName = issueName;
            IssueType = issueType;
            IssueDescription = issueDescription;
            Status = status;
        }
    }
}
