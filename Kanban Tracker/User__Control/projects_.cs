using System;
﻿using Guna.UI2.WinForms;
using Kanban_Tracker.Classes;
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
        private string connectionStr = "Data Source = DESKTOP-GKGSCQS\\SQLEXPRESS; Initial Catalog=KanbanTracker;Integrated Security=true";
        MainBoard parentForm;

        public projects_()
        {
            InitializeComponent();
            this.Load += UserControlLoad;
        }
        private void UserControlLoad(object sender, EventArgs e)
        {
            try
            {
                parentForm = (MainBoard)this.FindForm();
                getUserProjects(parentForm.user, projelerDataGrid);
            }catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            
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
                string projeAciklamasi = aciklamaTxtBox.Text;
                DateTime baslangic = startDate.Value;
                string baslangicTarihi = baslangic.ToString("dd.MM.yyyy");
                DateTime bitis = endDate.Value;
                string bitisTarihi = bitis.ToString("dd.MM.yyyy");

                createProjectByUser(parentForm.user, new Project(projeismi, projeAciklamasi, bitis));
                getUserProjects(parentForm.user, projelerDataGrid);
                yeniProjePnl.Visible = false;
                projeName.Text = "";
                aciklamaTxtBox.Text = "";
            }
        }

        private void projelerDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1) { 
                this.Visible = false;
                this.parentForm.selectedProjectIndex = e.RowIndex;
                this.parentForm.boardUserControl = new TaskBoardControl();
                this.parentForm.boardUserControl.BringToFront();
                this.parentForm.boardUserControl.Visible = true;
                this.parentForm.showButtons();
            }
        }

        private void getUserProjects(User user, Guna2DataGridView gridView)
        {
            gridView.Rows.Clear();
            parentForm.userProjects = new List<Project>();
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
                                string projeID = reader.GetString(0).ToString();
                                string projeAd = reader.GetValue(1).ToString();
                                string projeAciklama = reader.GetValue(2).ToString();
                                DateTime baslangicTarih = (DateTime) reader.GetValue(3);
                                DateTime bitisTarih = (DateTime) reader.GetValue(4);
                                parentForm.userProjects.Add(new Project(projeID , projeAd, projeAciklama, baslangicTarih, bitisTarih));
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
