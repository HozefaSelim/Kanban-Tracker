using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_Tracker
{
    public partial class MainBoard : Form
    {
        public MainBoard()
        {
            InitializeComponent();
        }


        private void boardBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to open
            Board buttonForm = new Board();

            // Call the method to open the form in a panel
            AbrirFormEnPanel(buttonForm);
        }

        private void AbrirFormEnPanel(Form form)
        {
            // Assuming you have a panel named mainPanel to add the form to
            Panel mainPanel = this.container;

            // Clear any existing controls from the panel
            mainPanel.Controls.Clear();

            // Set the form's properties
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None; // Remove the border for better appearance

            // Calculate the center position
            form.StartPosition = FormStartPosition.Manual; // Manually set the position
            form.Location = new Point((mainPanel.Width - form.Width) / 2, (mainPanel.Height - form.Height) / 2);

            // Add the form to the panel and show it
            mainPanel.Controls.Add(form);
            form.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
