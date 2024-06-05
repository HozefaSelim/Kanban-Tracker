using Guna.UI2.WinForms;
using Kanban_Tracker.Classes;
using Kanban_Tracker.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kanban_Tracker.User__Control
{
    public partial class projects_ : UserControl
    {
        private string connectionStr = "Data Source = MALIK-S-LAPTOP\\SQLEXPRESS; Initial Catalog=KanbanTracker;Integrated Security=true";
        public User user { get; set; }
        public projects_()
        {
            InitializeComponent();
            projelerDataGrid.Rows.Add("Proje 1", "aciklama", "10.05.2024", "10.05.2025");
            projelerDataGrid.Rows.Add("Proje 1", "aciklama", "10.05.2024", "10.05.2025");
            this.Load += UserControlLoad;
        }
        private void UserControlLoad(object sender, EventArgs e)
        {
            MainBoard parentForm = (MainBoard) this.FindForm();
            this.user = parentForm.user;
            getUserProjects(user, projelerDataGrid);
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
                DateTime bitis = endDate.Value;
                string bitisTarihi = bitis.ToString("dd.MM.yyyy");

                createProjectByUser(user, new Project(projeismi, projeAciklamasi, bitis));
                getUserProjects(user, projelerDataGrid);
                yeniProjePnl.Visible = false;
                projeName.Text = "";
                aciklama.Text = "";
            }
        }

        private void projelerDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Visible = false;
            TaskBoardControl t = new TaskBoardControl();
            t.BringToFront();
            t.Visible = true;
        }

        private void getUserProjects(User user, Guna2DataGridView gridView)
        {
            gridView.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ListUserProjects", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@userID", user.UserID));

                        command.ExecuteNonQuery();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string projeAd = reader.GetValue(0).ToString();
                                string projeAciklama = reader.GetValue(1).ToString();
                                DateTime baslangicTarih = (DateTime) reader.GetValue(2);
                                DateTime bitisTarih = (DateTime) reader.GetValue(3);
                                gridView.Rows.Add(projeAd, projeAciklama, baslangicTarih.ToString("dd.MM.yyyy"), bitisTarih.ToString("dd.MM.yyyy"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        private void createProjectByUser(User user, Project project)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AddProject", connection))
                    {   
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@projectName", project.ProjectName));
                        command.Parameters.Add(new SqlParameter("@projectDescription", project.ProjectDescription));
                        command.Parameters.Add(new SqlParameter("@endDate", project.EndDate));
                        command.Parameters.Add(new SqlParameter("@userID", user.UserID));

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
