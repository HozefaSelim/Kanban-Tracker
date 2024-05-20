﻿using System;
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
        }

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (sidebar.Width == 200)
            {
                sidebar.Width = 103;
            }
            else
            {
                sidebar.Width = 200;
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
            AbrirFormEnPanel(new Button1());
        }
    }
}
