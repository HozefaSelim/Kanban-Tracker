using Kanban_Tracker.Classes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kanban_Tracker
{
    public partial class SignIn : Form
    {
        private string connectionStr = "Data Source = MALIK-S-LAPTOP\\SQLEXPRESS; Initial Catalog=KanbanTracker;Integrated Security=true";
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
            if (checkNameSurnameField(adSoyadTxtBox.Text.Trim()))
            {
                if (checkEmailField(olusturMailTxtBox.Text))
                {
                    if (!checkUserEmail(olusturMailTxtBox.Text))
                    {
                        if (olusturSifreTxtBox.Text == sifreTekrarTxtBox.Text)
                        {
                            User newUser = new User(adSoyadTxtBox.Text.Trim(), olusturMailTxtBox.Text, olusturSifreTxtBox.Text);
                            if (AddUser(newUser))
                            {
                                olusturPnl.Visible = false;
                                girisPnl.Visible = true;
                                //User created sucessfuly
                            }
                            else
                            {
                                //User did not get created
                            }
                        }
                        else
                        {
                            //Password does not match
                        }
                    }
                    else
                    {
                        //Email already exsists
                    }
                }
                else
                {
                    //Email Typing Error
                }
            }
            else
            {
                //Name Surname Typing Error
            }
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

            if (checkUserEmail(mailTxtBox.Text.Trim()))
            {
                if (checkUserPassword(mailTxtBox.Text.Trim(), sifreTxtBox.Text))
                {
                    MainBoard m = new MainBoard(getUserByEmail(mailTxtBox.Text.Trim()));
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
                // Email error
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

        private User getUserByEmail(string email)
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
                                string userID = reader.GetValue(0).ToString();
                                string username = reader.GetValue(1).ToString();
                                string mail = reader.GetValue(2).ToString();
                                string password = reader.GetValue(3).ToString();
                                return new User(userID, username, mail, password);
                            }
                            return new User("ERROR", "ERROR", "ERROR", "ERROR");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return new User("ERROR", "ERROR", "ERROR", "ERROR");
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
                                if (reader.GetValue(3).ToString() == password)
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

        private bool checkNameSurnameField(string nameSurname)
        {
            if (nameSurname.Length <= 0) return false;
            string nameSurnamePattern = @"^[a-zA-Z\s\-]+$";
            return Regex.IsMatch(nameSurname, nameSurnamePattern);
        }

        private bool checkEmailField(string email)
        {
            if (email.Length <= 0) return false;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool AddUser(User newUser)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("AddUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@username", newUser.Username));
                        command.Parameters.Add(new SqlParameter("@email", newUser.Email));
                        command.Parameters.Add(new SqlParameter("@password", newUser.Password));

                        command.ExecuteNonQuery();
                        return true;
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
