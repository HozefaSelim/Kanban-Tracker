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
    public partial class Board : Form
    {
        private Label selectedLabel = null; // Store the selected label

        public Board()
        {
            InitializeComponent();
            this.KeyPreview = true; // Ensure the form captures key presses
            this.KeyDown += Board_KeyDown; // Handle the KeyDown event
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            // Create a new label
            Label newLabel = new Label();

            // Set label properties
            newLabel.Text = ""; // Start with empty text
            newLabel.AutoSize = true;
            newLabel.BorderStyle = BorderStyle.FixedSingle; // Add border to see the selection
            newLabel.Font = new Font(newLabel.Font, FontStyle.Bold); // Make the font bold
            newLabel.Font = new Font(newLabel.Font.FontFamily, 14); // Increase font size
            newLabel.Click += Label_Click; // Add click event to select the label

            // Find the last label or header in the backLog panel to position the new label
            Control lastControl = this.backLog.Controls.OfType<Label>().LastOrDefault();

            // Adjust yPos to be 30 pixels below the header if there are no labels, otherwise 10 pixels below the last label
            int yPos;
            if (lastControl != null)
            {
                yPos = lastControl.Bottom + 10;
            }
            else
            {
                // Assuming the header has a fixed height or adjust as needed
                yPos = 60; // 0 pixels from the top of the panel or header
            }

            // Set the location of the new label
            newLabel.Location = new Point(10, yPos);

            // Optionally, set the new label to be editable (e.g., using a TextBox instead of a Label)
            TextBox editableTextBox = new TextBox();
            editableTextBox.Location = newLabel.Location;
            editableTextBox.Size = new Size(150, 30);

            // Add the TextBox to the backLog panel
            this.backLog.Controls.Add(editableTextBox);

            // Handle the TextBox's KeyDown event to save text on Enter key press
            editableTextBox.KeyDown += (s, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    newLabel.Text = editableTextBox.Text;
                    this.backLog.Controls.Add(newLabel); // Add the new label to the panel
                    this.backLog.Controls.Remove(editableTextBox); // Remove the TextBox
                    newLabel.Visible = true; // Make sure the label is visible
                    args.Handled = true;
                    args.SuppressKeyPress = true; // Prevent the 'ding' sound
                }
            };

            // Optionally focus on the TextBox for immediate editing
            editableTextBox.Focus();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (selectedLabel != null)
            {
                selectedLabel.BackColor = SystemColors.Control; // Reset previous selection to default color
            }

            selectedLabel = sender as Label;
            if (selectedLabel != null)
            {
                selectedLabel.BackColor = Color.LightBlue; // Highlight selected label with a different background color
            }
        }

        private void Board_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && selectedLabel != null)
            {
                string message = $"Do you want to delete the label '{selectedLabel.Text}'?";
                string title = "Confirm Deletion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.backLog.Controls.Remove(selectedLabel); // Remove from panel
                    selectedLabel.Dispose(); // Dispose of the label
                    selectedLabel = null; // Reset selectedLabel
                    ResortLabels(); // Resort the remaining labels
                }
            }
        }

        private void ResortLabels()
        {
            int yPos = 30; // Start position from the top of the panel or header

            // Iterate through all labels in the backLog panel and adjust their positions
            foreach (Control control in this.backLog.Controls)
            {
                if (control is Label label)
                {
                    label.Location = new Point(10, yPos); // Adjust the label's position
                    yPos += label.Height + 10; // Increment yPos for the next label
                }
            }
        }

       
    }
}
