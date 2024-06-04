using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_Tracker
{
    public partial class issueOlustur : UserControl
    {
        public issueOlustur()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void projeEkleBtni_Click(object sender, EventArgs e)
        {
            string projeadi = projeAdiLbl.Text;
            string issueTipi = issueType.SelectedText;
            
        }
    }
}
