namespace Kanban_Tracker
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void checkBoxP_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
