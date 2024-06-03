using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_Tracker.Classes
{
    public class Epic
    {
        public int EpicID { get; set; }
        public string EpicName { get; set; }
        public string EpicDescription { get; set; }
        public string Status { get; set; }
        public Project Project { get; set; }
        public IList<Issue> Issues { get; set; }


        public Epic(int epicID, string epicName, string epicDescription, string status, Project project)
        {
            EpicID = epicID;
            EpicName = epicName;
            EpicDescription = epicDescription;
            Status = status;
            Project = project;
            Issues = new List<Issue>();
        }

        public Project GetProject()
        {
            return Project;
        } 
        public void AddIssue(Issue issue)
        {
            Issues.Add(issue);
        }
        public int GetIssueIndex(Issue issue)
        {
            for (int i = 0; i < Issues.Count; i++)
            {
                if (issue.IssueID == Issues[i].IssueID)
                {
                    return i;
                }
            }
            return -1;
        }
        public int GetIssueIndex(int issueID)
        {
            for (int i = 0; i < Issues.Count; i++)
            {
                if (issueID == Issues[i].IssueID)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
