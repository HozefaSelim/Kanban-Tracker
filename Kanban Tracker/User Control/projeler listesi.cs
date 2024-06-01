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

namespace Kanban_Tracker.User_Control
{
    public partial class projeler : UserControl
    {
        public projeler()
        {
            InitializeComponent();
        }

        private void projelerDtaView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void fillDataGridView(string isim, string aciklama, string baslamaTarihi, string bitisTarihi)
        {
            projelerDtaView.Rows.Add(isim, aciklama, baslamaTarihi, bitisTarihi);
        }

        private void projelerDtaView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string satirNumarasi = projelerDtaView.Rows[e.RowIndex].ToString();
            //projePnl.Visible = false;
        }

        private void projeOlusturBtn_Click(object sender, EventArgs e)
        {
            yeniProje proje = new yeniProje();
            proje.Visible = true;
        }
    }
}
