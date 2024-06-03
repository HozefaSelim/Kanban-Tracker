using System.Data;
using System.Data.SqlClient;

namespace Kanban_Tracker
{
    public partial class SignIn : Form
    {
        string connectionStr = "Data Source = MALIK-S-LAPTOP\\SQLEXPRESS; Initial Catalog=Kanban_Tracker;Integrated Security=true";
        public SignIn()
        {
            InitializeComponent();
            olusturPnl.Visible = false;
            girisPnl.Visible = true;
        }

        private void checkBoxP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            olusturPnl.Visible = true;
            girisPnl.Visible = false;
        }

        private void img_Click(object sender, EventArgs e)
        {
            olusturPnl.Visible = false;
            girisPnl.Visible = true;
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {

            if(checkUserEmail(mailTxtBox.Text.Trim()))
            { 
                if(checkUserPassword(mailTxtBox.Text.Trim(), sifreTxtBox.Text))
                {
                    MainBoard m = new MainBoard();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    //Password error
                }
            }
            else
            {
                //Email error
            }
        }

        private void mailTxtBox_TextChanged(object sender, EventArgs e)
        {

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
                            while(reader.Read())
                            {
                                hesapSayisi++;
                            }
                            if (hesapSayisi == 1) return true;
                            else if ( hesapSayisi == 0)
                            {
                                MessageBox.Show("Öyle bir hesap yok");
                            }
                            else
                            {
                                MessageBox.Show("Ayný mail'e sahip birden fazla hesap var - "+hesapSayisi);
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

        private bool checkUserPassword(string email, string password)
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
                            while (reader.Read())
                            {
                                if(reader.GetValue(3).ToString() == password)
                                {
                                    return true;
                                }
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
    }
}
