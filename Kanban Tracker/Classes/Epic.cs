using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_Tracker.Classes
{
    public class Epic
    {
        public string EpicID { get; set; }
        public string EpicName { get; set; }
        public string EpicDescription { get; set; }
        public string Status { get; set; }

        public Epic(string epicID, string epicName)
        {
            EpicID = epicID;
            EpicName = epicName;
        }

        public Epic(string epicName, string epicDescription, string status)
        {
            EpicName = epicName;
            EpicDescription = epicDescription;
            Status = status;
        }
    }
}
