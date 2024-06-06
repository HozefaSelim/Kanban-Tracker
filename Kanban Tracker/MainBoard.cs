using System;
﻿using Guna.UI2.WinForms;
using Kanban_Tracker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private string connectionStr = "Data Source = DESKTOP-GKGSCQS\\SQLEXPRESS; Initial Catalog=KanbanTracker;Integrated Security=true";

        public User user { get; set; }
        public IList<Project> userProjects { get; set; }
        public int selectedProjectIndex;

        public MainBoard()
        {
            InitializeComponent();
        }

        public MainBoard(User user)
        {
            InitializeComponent();
            this.user = user;
            userName.Text = user.Username;
            selectedProjectIndex = -1;
        }

        public void showButtons()
        {
            olusturBtn.Visible = true;
            kisiEkleBtn.Visible = true;
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
        private void MainBoard_Load(object sender, EventArgs e)
        {
            ProjectsUserControl.BringToFront();
            ProjectsUserControl.Visible = true;
        }

        private void olusturBtn_Click(object sender, EventArgs e)
        {
            issueOlusturPnl.Visible = true;
            issueOlusturPnl.BringToFront();
        }
        private void boardBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("borad görüntülendi");
            boardUserControl.BringToFront();
            boardUserControl.Visible = true;
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            getProjectEpics(userProjects[selectedProjectIndex], ListeUserControl.ListeDataGrid);
            ListeUserControl.Visible = true;
            ListeUserControl.BringToFront();
        }

        private void takimBtn_Click(object sender, EventArgs e)
        {
            getProjectUsers(userProjects[selectedProjectIndex], TakimListesiUserControl.takimDataGrid);
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
            olusturBtn.Visible = false;
            kisiEkleBtn.Visible = true;
            sidebarPnl.BringToFront();
            selectedProjectIndex = -1;
            ProjectsUserControl.BringToFront();
            ProjectsUserControl.Visible = true;
        }

        private void kapsamBtn_Click(object sender, EventArgs e)
        {
            getProjectIssues(userProjects[selectedProjectIndex], KapsamListeuserControl.ListeDataGrid);
            KapsamListeuserControl.Visible = true;
            KapsamListeuserControl.BringToFront();
        }

        private void getProjectEpics(Project project, Guna2DataGridView gridView)
        {
            gridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ListProjectEpics", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@projectID", project.ProjectID));

                        command.ExecuteNonQuery();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string epicID = reader.GetString(0).ToString();
                                string epicAd = reader.GetValue(1).ToString();
                                string epicDurum = reader.GetValue(2).ToString();
                                gridView.Rows.Add(epicID, epicAd, epicDurum);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void getProjectUsers(Project project, Guna2DataGridView gridView)
        {
            gridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ListProjectUsers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@projectID", project.ProjectID));

                        command.ExecuteNonQuery();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string username = reader.GetString(0).ToString();
                                string userEmail = reader.GetValue(1).ToString();
                                string userRole = reader.GetValue(2).ToString();
                                gridView.Rows.Add(username, userEmail, userRole);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void getProjectIssues(Project project, Guna2DataGridView gridView)
        {
            gridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ListProjectIssues", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@projectID", project.ProjectID));

                        command.ExecuteNonQuery();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string issueID = reader.GetString(0).ToString();
                                string issueAd = reader.GetValue(1).ToString();
                                string epicAd = reader.GetValue(2).ToString();
                                string issueDurum = reader.GetValue(3).ToString();
                                DateTime issueTarih = (DateTime)reader.GetValue(4);
                                gridView.Rows.Add(issueID, issueAd, epicAd, issueDurum, issueTarih.ToString("dd.MM.yyyy"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            kisiEklePnl.Visible = false;
        }

        private void kisiEkleBtn_Click(object sender, EventArgs e)
        {
            kisiEklePnl.BringToFront();
            kisiEklePnl.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string ad = kullaniciAdi.Text;
            string rol = rolComboBox.SelectedText;

            kullaniciAdi.Text = "";
            rolComboBox.SelectedIndex = -1;

        }

        private void MainBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
