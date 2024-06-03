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
            olusturBtn.Visible = false;
            projects_1.BringToFront();
            projects_1.Visible = true;

            boardBtn.Checked = true;
        }

        private void projeOlusturBtn_Click(object sender, EventArgs e)
        {
            yeniProje1.Visible = true;
        }

        private void olusturBtn_Click(object sender, EventArgs e)
        {

        }
        private void sidebarPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boardBtn_Click(object sender, EventArgs e)
        {
            taskBoardControl1.Visible = true;
            taskBoardControl1.BringToFront();
            //boardBtn.Checked = true;
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            // listBtn.Checked = true;
            liste2.Visible = true;
            liste2.BringToFront();
        }

        private void takimBtn_Click(object sender, EventArgs e)
        {
            //takimBtn.Checked = true;
        }

        private void hedefBtn_Click(object sender, EventArgs e)
        {
            //hedefBtn.Checked = true;
        }
    }
}
