﻿using System;
using System.Drawing;
using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kanban_Tracker
{
    public partial class MainBoard : Form
    {
        SignIn sign;
        public string connectionStr = "Data Source = HOZEFA-PC\\SQLEXPRESS; Initial Catalog=KanbanTracker;Integrated Security=true";

        public User user { get; set; }
        public IList<Project> userProjects { get; set; }
        public IList<Issue> projectIssues { get; set; }
        public int selectedProjectIndex;

        public MainBoard(User user)
        {
            InitializeComponent();
            this.user = user;
            userName.Text = user.Username;
            selectedProjectIndex = -1; 
            issueType.SelectedIndexChanged += new EventHandler(issueType_SelectedIndexChanged);
        }
        public void showButtons()
        {
            olusturBtn.Visible = true;
            kisiEkleBtn.Visible = true;
            boardUserControl.Visible = true;
            boardUserControl.BringToFront();
        }
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
            try
            {

            string ad = issueAdiTextBox.Text;
            string issueTipi = "";
            string issueDurum = "";

                if (issueType.SelectedIndex != -1)
                    issueTipi = issueType.SelectedItem.ToString();
                else throw new Exception();

                if (durum.SelectedIndex != -1)
                    issueDurum = durum.SelectedItem.ToString();
                else throw new Exception();

            string issueAciklama = aciklamaTxtBox.Text;
            if (issueType.SelectedItem.ToString() == "Task" || issueType.SelectedItem.ToString() == "Story")
            {
                AddIssueToProject(userProjects[selectedProjectIndex], userProjects[selectedProjectIndex].Epics[projeEpicComboBox.SelectedIndex], new Issue(ad, issueTipi, issueAciklama, issueDurum));
                getProjectIssues(userProjects[selectedProjectIndex], KapsamListeuserControl.ListeDataGrid);
                getIssues(userProjects[selectedProjectIndex]);
            }
            else if (issueType.SelectedItem.ToString() == "Epic")
            {
                AddEpicToProject(userProjects[selectedProjectIndex], new Epic(ad, issueAciklama, issueDurum));
                getProjectEpics(userProjects[selectedProjectIndex], ListeUserControl.ListeDataGrid);
            }
            }catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen Tekrar Deneyiniz.");
            }


            //database connection codes
            issueOlusturPnl.Visible = false;
            issueOlusturPnl.SendToBack();
            issueAdiTextBox.Text = "";
            projeEpicComboBox.Items.Clear();
            aciklamaTxtBox.Text = "";
            issueType.SelectedIndex = -1;
            durum.SelectedIndex = -1;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            issueOlusturPnl.Visible = false;
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            olusturBtn.Visible = false;
            kisiEkleBtn.Visible = false;
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
        private void loadProjectEpics(Project project, Guna2ComboBox comboBox)
        {
            comboBox.Items.Clear();
            userProjects[selectedProjectIndex].Epics.Clear();
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
                                userProjects[selectedProjectIndex].Epics.Add(new Epic(epicID, epicAd));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            foreach (Epic e in userProjects[selectedProjectIndex].Epics)
            {
                comboBox.Items.Add(e.EpicName);
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
        private void AddUserToProject(Project project, string userEmail, string userRole)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("AddUserToProject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@userEmail", userEmail));
                        command.Parameters.Add(new SqlParameter("@projectID", project.ProjectID));
                        command.Parameters.Add(new SqlParameter("@userRole", userRole));

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void AddEpicToProject(Project project, Epic epic)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("AddEpic", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@projectID ", project.ProjectID));
                        command.Parameters.Add(new SqlParameter("@epicName ", epic.EpicName));
                        command.Parameters.Add(new SqlParameter("@epicDescription ", epic.EpicDescription));
                        command.Parameters.Add(new SqlParameter("@status_ ", epic.Status));

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void AddIssueToProject(Project project, Epic epic, Issue issue)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("AddIssue", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@epicID ", epic.EpicID));
                        command.Parameters.Add(new SqlParameter("@issueName ", issue.IssueName));
                        command.Parameters.Add(new SqlParameter("@issueType ", issue.IssueType));
                        command.Parameters.Add(new SqlParameter("@issueDescription ", issue.IssueDescription));
                        command.Parameters.Add(new SqlParameter("@status_ ", issue.Status));

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private bool checkUserEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("getUserByEmail", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@userEmail", email));

                        command.ExecuteNonQuery();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int hesapSayisi = 0;
                            while (reader.Read())
                            {
                                hesapSayisi++;
                            }
                            if (hesapSayisi == 1) return true;
                            else if (hesapSayisi == 0)
                            {
                            }
                            else
                            {
                                MessageBox.Show("Ayni mail'e sahip birden fazla hesap var - " + hesapSayisi);
                            }
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }
        private void kisiPnlCloseButton_Click(object sender, EventArgs e)
        {
            kisiEklePnl.Visible = false;
        }
        private void kisiEkleBtn_Click(object sender, EventArgs e)
        {
            kisiEklePnl.BringToFront();
            kisiEklePnl.Visible = true;
        }
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
            string email = kullaniciAdi.Text;
                string rol = "";
            if (rolComboBox.SelectedIndex != -1)
                 rol = rolComboBox.SelectedItem.ToString();

            if (checkUserEmail(email) & rolComboBox.SelectedIndex != -1)
            {
                AddUserToProject(userProjects[selectedProjectIndex], email, rol);
                kullaniciAdi.Text = "";
                rolComboBox.SelectedIndex = -1;
                kisiEklePnl.Visible = false;
                kisiEklePnl.SendToBack();
                getProjectUsers(userProjects[selectedProjectIndex], TakimListesiUserControl.takimDataGrid);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu. Lütfen Tekrar Deneyiniz.");
            }
            }catch(NullReferenceException ex)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen Tekrar Deneyiniz.");
            }
        }
        private void MainBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign = new SignIn();
            sign.Visible = true;
        }
        private void boardBtn_Click(object sender, EventArgs e)
        {
            getIssues(userProjects[selectedProjectIndex]);
            boardUserControl.BringToFront();
            boardUserControl.Visible = true;
        }
        private void issueType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (issueType.SelectedIndex != -1)
            {
                string selectedItem = issueType.SelectedItem.ToString();
                // Eğer "Story" veya "Task" seçildiyse ekstra TextBox ekle
                if (selectedItem == "Story" || selectedItem == "Task")
                {
                    epicLabel.Visible = true;
                    durum.Items.Clear();
                    durum.Items.Add("Backlog");
                    durum.Items.Add("To Do");
                    durum.Items.Add("Doing");
                    durum.Items.Add("Done");
                    projeEpicComboBox.Visible = true;
                    loadProjectEpics(userProjects[selectedProjectIndex], projeEpicComboBox);
                    //Locations
                    issueStatusLabel.Location = new Point(issueStatusLabel.Location.X, 330);
                    durum.Location = new Point(durum.Location.X, 362);
                    issueLabel.Location = new Point(issueLabel.Location.X, 423);
                    issueAdiTextBox.Location = new Point(issueAdiTextBox.Location.X, 455);
                    issueDescriptionLabel.Location = new Point(issueDescriptionLabel.Location.X, 518);
                    aciklamaTxtBox.Location = new Point(aciklamaTxtBox.Location.X, 550);
                }
                else if (selectedItem == "Epic")
                {
                    epicLabel.Visible = false;
                    durum.Items.Clear();
                    durum.Items.Add("In Progress");
                    durum.Items.Add("Done");
                    projeEpicComboBox.Visible = false;
                    //location
                    issueStatusLabel.Location = new Point(issueStatusLabel.Location.X, 238);
                    durum.Location = new Point(durum.Location.X, 270);
                    issueLabel.Location = new Point(issueLabel.Location.X, 331);
                    issueAdiTextBox.Location = new Point(issueAdiTextBox.Location.X, 363);
                    issueDescriptionLabel.Location = new Point(issueDescriptionLabel.Location.X, 426);
                    aciklamaTxtBox.Location = new Point(aciklamaTxtBox.Location.X, 458);
                }
            }
        }
        public void getIssues(Project project)
        {
            projectIssues = new List<Issue>();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GetIssuesByProjectID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@projectID", project.ProjectID));

                        command.ExecuteNonQuery();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string issueID = reader.GetString(0).ToString();
                                string issueName = reader.GetString(1).ToString();
                                string epicID = reader.GetValue(2).ToString();
                                string epicName = reader.GetValue(3).ToString();
                                string issueType = reader.GetValue(4).ToString();
                                string issueStatus = reader.GetValue(5).ToString();
                                projectIssues.Add(new Issue(issueID, issueName, issueType, issueStatus, new Epic(epicID, epicName)));
                            }
                        }
                    }
                    loadIssuesToBoard();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
        private void loadIssuesToBoard()
        {
            boardUserControl.ClearPanels();
            foreach (Issue issue in projectIssues)
            {
                if(issue.Status == "Backlog")
                {
                    boardUserControl.CreateAndAddPanel(boardUserControl.backlog, issue);
                }
                else if(issue.Status == "To Do")
                {
                    boardUserControl.CreateAndAddPanel(boardUserControl.todo, issue);
                }
                else if (issue.Status == "Doing")
                {
                    boardUserControl.CreateAndAddPanel(boardUserControl.doing, issue);
                }
                else if (issue.Status == "Done")
                {
                    boardUserControl.CreateAndAddPanel(boardUserControl.done, issue);
                }
                else
                {
                    MessageBox.Show("BIG FAIL " + issue.Status);
                }
            }
        }
    }
}
