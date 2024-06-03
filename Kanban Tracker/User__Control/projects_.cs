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

namespace Kanban_Tracker.User__Control
{
    public partial class projects_ : UserControl
    {
        public projects_()
        {
            InitializeComponent();
            projelerDataGrid.Rows.Add("Proje 1", "aciklama", "10.05.2024", "10.05.2025");
            projelerDataGrid.Rows.Add("Proje 1", "aciklama", "10.05.2024", "10.05.2025");
        }

        //This method used to add data to DataGridView and send them to database
        public void addData(string ad, string aciklama, string baslangicTarihi, string bitisTarihi)
        {
            projelerDataGrid.Rows.Add(ad, aciklama, baslangicTarihi, bitisTarihi);

            //send to database
        }
        private void yeniProjeBtn_Click(object sender, EventArgs e)
        {
            yeniProjePnl.Visible = true;
            yeniProjePnl.BringToFront();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            yeniProjePnl.Visible = false;
        }

        private void projeEkleBtni_Click(object sender, EventArgs e)
        {
            if (projeName.Text == "")
            {
                MessageBox.Show("Lütfen Proje İsmini Giriniz");
            }
            else
            {
                string projeismi = projeName.Text;
                string projeAciklamasi = aciklama.Text;
                DateTime baslangic = startDate.Value;
                string baslangicTarihi = baslangic.ToString("dd.MM.yyyy");
                DateTime bitis = startDate.Value;
                string bitisTarihi = bitis.ToString("dd.MM.yyyy");

                addData(projeismi, projeAciklamasi, baslangicTarihi, bitisTarihi);
                yeniProjePnl.Visible = false;
                projeName.Text = "";
                aciklama.Text = "";
            }
        }

        private void projelerDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Visible = false;
        }
    }
}
