using Kanban_Tracker.Resources;
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
    public partial class MainBoard : Form
    {
        public MainBoard()
        {
            InitializeComponent();
            fillDataGridView("Hello World", "P35220", "HW", "25.06.2025");
            fillDataGridView("Hello World", "P35220", "HW", "25.06.2025");
            fillDataGridView("Hello World", "P35220", "HW", "25.06.2025");
            fillDataGridView("Hello World", "P35220", "HW", "25.06.2025");

        }

        public MainBoard(string isim, string aciklama, string start, string end)
        {
            fillDataGridView(isim, aciklama, start, end);
        }

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (sidebarPnl.Width == 200)
            {
                sidebarPnl.Width = 103;
            }
            else
            {
                sidebarPnl.Width = 200;
            }
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
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
        //DataGridView'a veri ekleme metodu
        public void fillDataGridView(string isim, string aciklama, string baslamaTarihi, string bitisTarihi)
        {
            
            projelerDtaView.Rows.Add(isim, aciklama, baslamaTarihi, bitisTarihi);
        }

        private void yeniProje1_Load(object sender, EventArgs e)
        {

        }

        private void projelerDtaView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // çift tıklanan satırın numarasını alır
            string satirNumarasi = projelerDtaView.Rows[e.RowIndex].ToString();
            projePnl.Visible = false;
        }
    }
}
