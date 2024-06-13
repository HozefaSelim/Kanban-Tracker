using Kanban_Tracker.Classes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kanban_Tracker
{
    public partial class SignIn : Form
    {
        string connectionStr = "Data Source = MALIK-S-LAPTOP\\SQLEXPRESS; Initial Catalog=KanbanTracker;Integrated Security=true";
        public SignIn()
        {
            InitializeComponent();
            olusturPnl.Visible = false;
            girisPnl.Visible = true;
            timer1.Interval = 2000; // Set the interval to 2 seconds
            timer1.Tick += new EventHandler(timer1_Tick);
            sifreTxtBox.UseSystemPasswordChar = true;
            olusturSifreTxtBox.UseSystemPasswordChar = true;
            sifreTekrarTxtBox.UseSystemPasswordChar = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Clear the sifreError text
            emailError.Text = "";
            sifreError.Text = "";
            // Stop the timer
            timer1.Stop();
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
                    sifreError.Text = "Yalnış Şifre girdiniz";
                    mailTxtBox.Text = "";
                    sifreTxtBox.Text = "";
                    timer1.Start();
                }
            }
            else
            {
                emailError.Text = "Yalnış Email girdiniz";
                mailTxtBox.Text = "";
                sifreTxtBox.Text = "";
                timer1.Start();
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
                                //
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sifreTxtBox.UseSystemPasswordChar = !sifreTxtBox.UseSystemPasswordChar;
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sifreGoster_CheckedChanged_1(object sender, EventArgs e)
        {
            sifreTxtBox.UseSystemPasswordChar = !sifreTxtBox.UseSystemPasswordChar;
        }

        private void olusturBtn_Click(object sender, EventArgs e)
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
                                girisPnl.Visible = false;
                                MessageBox.Show("Kullancı Başarıyla Eklendi");
                                MainBoard m = new MainBoard(getUserByEmail(mailTxtBox.Text.Trim()));
                                m.Show();
                                this.Hide();
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("Şifrler eşleşmiyor");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanılmış Email");
                    }
                }
                else
                {
                    MessageBox.Show("Yanlış Email");
                }
            }
            else
            {
                MessageBox.Show("Yanlış Isim");
            }
        }

        private void olusturSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            olusturSifreTxtBox.UseSystemPasswordChar = !olusturSifreTxtBox.UseSystemPasswordChar;
            sifreTekrarTxtBox.UseSystemPasswordChar = !sifreTekrarTxtBox.UseSystemPasswordChar;

        }
    }
}
