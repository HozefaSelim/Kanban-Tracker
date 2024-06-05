using Kanban_Tracker.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_Tracker
{
    public partial class MainBoard : Form
    {
        public MainBoard()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.container.Controls.Count > 0)
                this.container.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.container.Controls.Add(fh);
            this.container.Tag = fh;
            fh.Show();
        }
        //This method used to show yeniProje UserControl
        public void LoadYeniProje()
        {
            yeniProje yp = new yeniProje();
            yp.BringToFront();
            yp.Visible = true;
            Debug.WriteLine("hhhsd");
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void MainBoard_Load(object sender, EventArgs e)
        {
            olusturBtn.Visible = true;
            ProjectsUserControl.BringToFront();
            ProjectsUserControl.Visible = true;
        }

        private void projeOlusturBtn_Click(object sender, EventArgs e)
        {
        }

        private void olusturBtn_Click(object sender, EventArgs e)
        {
            issueOlusturPnl.Visible = true;
            issueOlusturPnl.BringToFront();
        }
        private void sidebarPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boardBtn_Click(object sender, EventArgs e)
        {
            boardUserControl.Visible = true;
            boardUserControl.BringToFront();
            //boardBtn.Checked = true;
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            // listBtn.Checked = true;
            ListeUserControl.Visible = true;
            ListeUserControl.BringToFront();
        }

        private void takimBtn_Click(object sender, EventArgs e)
        {
            //takimBtn.Checked = true;
            TakimListesiUserControl.Visible = true;
            TakimListesiUserControl.BringToFront();
        }
        private void projeEkleBtni_Click(object sender, EventArgs e)
        {
            string projeAdi = projeAdiLbl.Text;
            string ad = issueAdi.Text;
            string issueTipi = issueType.SelectedText;
            string issueDurum = durum.SelectedText;
            string issueAciklama = aciklamaTxtBox.Text;

            issueAdi.Text = "";
            aciklamaTxtBox.Text = "";
            issueType.SelectedIndex = -1;
            durum.SelectedIndex = -1;
            projeAdiLbl.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            issueOlusturPnl.Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            sidebarPnl.BringToFront();
            ProjectsUserControl.BringToFront();
            ProjectsUserControl.Visible = true;
        }

        private void kapsamBtn_Click(object sender, EventArgs e)
        {
            KapsamListeuserControl.Visible = true;
            KapsamListeuserControl.BringToFront();
        }
    }
}
