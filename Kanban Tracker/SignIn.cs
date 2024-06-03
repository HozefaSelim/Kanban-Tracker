namespace Kanban_Tracker
{
    public partial class SignIn : Form
    {
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
            if (mailTxtBox.Text == "1" && sifreTxtBox.Text == "1")
            {
                MainBoard m = new MainBoard();
                m.Show();

                this.Hide();

                m.FormClosed += (s, args) => this.Close();
            }
        }

        private void mailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
