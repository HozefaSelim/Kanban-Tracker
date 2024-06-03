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
            AbrirFormEnPanel(new Board());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
        private void MainBoard_Load(object sender, EventArgs e)
        {
            olusturBtn.Visible = false;
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
    }
}
