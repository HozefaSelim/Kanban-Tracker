using System;
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
        SignIn s = new SignIn();
        private TaskBoardControl board;
        public string connectionStr = "Data Source = DESKTOP-GKGSCQS\\SQLEXPRESS; Initial Catalog=KanbanTracker; Integrated Security=true";

        public User user { get; set; }
        public IList<Project> userProjects { get; set; }
        public int selectedProjectIndex;

        public MainBoard()
        {
            InitializeComponent();
            issueType.SelectedIndexChanged += new EventHandler(issueType_SelectedIndexChanged);
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
            boardUserControl.Visible = true;
            boardUserControl.BringToFront();
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
            string ad = issueAdi.Text;
            string issueTipi = issueType.SelectedText;
            string issueDurum = durum.SelectedText;
            string issueAciklama = aciklamaTxtBox.Text;
            if (issueType.SelectedItem.ToString() == "Task" || issueType.SelectedItem.ToString() == "Story")
            {
                // add panel to the board
            }
            
            //database connection codes


            issueAdi.Text = "";
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
                                MessageBox.Show("Öyle bir hesap yok");
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
            string email = kullaniciAdi.Text;
            string rol = rolComboBox.SelectedItem.ToString();
            MessageBox.Show("." + rol + ".");
            if (checkUserEmail(email) & rolComboBox.SelectedIndex != -1)
            {
                AddUserToProject(userProjects[selectedProjectIndex], email, rol);
                kullaniciAdi.Text = "";
                rolComboBox.SelectedIndex = -1;
                kisiEklePnl.Visible = false;
                kisiEklePnl.SendToBack();
            }
            else
            {
                MessageBox.Show("email not found error ( no such user )");
                //email not found error ( no such user )
            }



        }

        private void MainBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            s.Visible = true;
        }

        private void boardBtn_Click(object sender, EventArgs e)
        {
            boardUserControl.BringToFront();
            boardUserControl.Visible = true;
        }

        private void issueType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = issueType.SelectedItem.ToString();
            // Eğer "Story" veya "Task" seçildiyse ekstra TextBox ekle
            if (selectedItem == "Story" || selectedItem == "Task")
            {
                label7.Visible = true;
                projeEpicComboBox.Visible = true;
                //Locations
                label4.Location = new Point(label4.Location.X, 330);
                durum.Location = new Point(durum.Location.X, 362);
                label5.Location = new Point(label5.Location.X, 423);
                issueAdi.Location = new Point(issueAdi.Location.X, 455);
                label1.Location = new Point(label1.Location.X, 518);
                aciklamaTxtBox.Location = new Point(aciklamaTxtBox.Location.X, 550);
            }
            else
            {
                label7.Visible = false;
                projeEpicComboBox.Visible = false;
                //location
                label4.Location = new Point(label4.Location.X, 238);
                durum.Location = new Point(durum.Location.X, 270);
                label5.Location = new Point(label5.Location.X, 331);
                issueAdi.Location = new Point(issueAdi.Location.X, 363);
                label1.Location = new Point(label1.Location.X, 426);
                aciklamaTxtBox.Location = new Point(aciklamaTxtBox.Location.X, 458);
            }
        }
    }
}
