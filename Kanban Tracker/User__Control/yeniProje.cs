using Kanban_Tracker.User__Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_Tracker.Resources
{
    public partial class yeniProje : UserControl
    {
        public yeniProje()
        {
            InitializeComponent();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void projeEkleBtni_Click(object sender, EventArgs e)
        {
            string projeismi = projeAdi.Text;
            string projeAciklamasi = aciklama.Text;
            string baslangicTarihi = startDate.Text;
            string bitisTarihi = endDate.Text;

        }
    }
}
