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
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Epic Epic { get; set; }
        public User AssignedUser { get; set; }

        public Issue(int issueID, string issueName, string issueDescription, string status, DateTime? startDate, DateTime? endDate, Epic epic, User assignedUser)
        {
            IssueID = issueID;
            IssueName = issueName;
            IssueDescription = issueDescription;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
            Epic = epic;
            AssignedUser = assignedUser;
        }

        public void AssignUser(User assignedUser)
        {
            AssignedUser = assignedUser;
        }
        public User GetAssignedUser()
        {
            return AssignedUser;
        }
        public Epic GetEpic() 
        {
            return Epic;
        }
    }
}
