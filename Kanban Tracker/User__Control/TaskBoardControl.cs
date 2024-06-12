using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Kanban_Tracker.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kanban_Tracker
{
    public partial class TaskBoardControl : UserControl
    {
        string connectionStr;
        MainBoard parentForm;

        public TaskBoardControl()
        {
            InitializeComponent();
            this.Load += UserControlLoad;
            InitializeDragDrop();
        }

        private void UserControlLoad(object sender, EventArgs e)
        {
            try
            {
                parentForm = (MainBoard)this.FindForm();
                this.connectionStr = parentForm.connectionStr;
            }
            catch (Exception ex)
            {
                // Handle exception if necessary
            }
        }

        private void InitializeDragDrop()
        {
            // Set up the drag event handlers for each panel in backlog
            foreach (Control control in backlog.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Panel)
                {
                    control.MouseDown += new MouseEventHandler(panel_MouseDown);
                }
            }

            // Set up the drag event handlers for the main panels
            backlog.DragEnter += new DragEventHandler(mainPanel_DragEnter);
            backlog.DragDrop += new DragEventHandler(mainPanel_DragDrop);

            todo.DragEnter += new DragEventHandler(mainPanel_DragEnter);
            todo.DragDrop += new DragEventHandler(mainPanel_DragDrop);

            doing.DragEnter += new DragEventHandler(mainPanel_DragEnter);
            doing.DragDrop += new DragEventHandler(mainPanel_DragDrop);

            done.DragEnter += new DragEventHandler(mainPanel_DragEnter);
            done.DragDrop += new DragEventHandler(mainPanel_DragDrop);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Guna.UI2.WinForms.Guna2Panel pnl = sender as Guna.UI2.WinForms.Guna2Panel;
            if (pnl != null)
            {
                // Initiate the drag-and-drop operation
                DoDragDrop(pnl, DragDropEffects.Move);
            }
        }

        private void mainPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Guna.UI2.WinForms.Guna2Panel)))
            {
                // Check if the target is one of the allowed main panels
                Panel pnl = sender as Panel;
                if (pnl == backlog || pnl == todo || pnl == doing || pnl == done)
                {
                    // Show the move cursor
                    e.Effect = DragDropEffects.Move;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void mainPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Guna.UI2.WinForms.Guna2Panel)))
            {
                Guna.UI2.WinForms.Guna2Panel draggedPanel = (Guna.UI2.WinForms.Guna2Panel)e.Data.GetData(typeof(Guna.UI2.WinForms.Guna2Panel));
                Panel targetPanel = (Panel)sender;

                // Store the original parent panel
                Panel originalPanel = (Panel)draggedPanel.Parent;

                // Remove the panel from its current parent
                draggedPanel.Parent.Controls.Remove(draggedPanel);

                // Calculate the new position considering all controls (labels and panels)
                int y = GetNextPanelYPosition(targetPanel);

                // Calculate the centered X position
                int x = (targetPanel.Width - draggedPanel.Width) / 2;

                // Reposition the dragged panel within the new main panel
                draggedPanel.Parent = targetPanel;
                draggedPanel.Location = new Point(x, y);

                // Add the panel to the target panel's controls
                targetPanel.Controls.Add(draggedPanel);

                // Update the second label with the parent panel's name
                UpdateParentPanelNameLabel(draggedPanel, targetPanel.Name);

                // Sort the panels in both the original and target panels
                SortPanels(originalPanel);
                SortPanels(targetPanel);

                switch (targetPanel.Name)
                {
                    case "backlog":
                        updateIssueStatus(draggedPanel.Name.Trim(), "Backlog");
                        break;
                    case "todo":
                        updateIssueStatus(draggedPanel.Name.Trim(), "To Do");
                        break;
                    case "doing":
                        updateIssueStatus(draggedPanel.Name.Trim(), "Doing");
                        break;
                    case "done":
                        updateIssueStatus(draggedPanel.Name.Trim(), "Done");
                        break;

                }
            }
        }

        private void UpdateParentPanelNameLabel(Guna.UI2.WinForms.Guna2Panel panel, string parentPanelName)
        {
            foreach (Label label in panel.Controls.OfType<Label>())
            {
                // Update the label with the parent panel's name
                if (label.Tag != null && label.Tag.ToString() == "ParentPanelName")
                {
                    label.Text = parentPanelName;
                }
            }
        }

        private int GetNextPanelYPosition(Panel targetPanel)
        {
            // Calculate the starting y position considering any existing labels at the top
            int y = 0;
            foreach (Control control in targetPanel.Controls)
            {
                if (control is Label)
                {
                    y = Math.Max(y, control.Bottom + 10); // Start below any labels
                }
            }

            // Stack panels vertically with a 10-pixel gap
            foreach (Control control in targetPanel.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Panel)
                {
                    y = Math.Max(y, control.Bottom + 10);
                }
            }

            return y;
        }

        private void SortPanels(Panel targetPanel)
        {
            // Create a list of panels excluding labels
            var panels = new List<Control>();
            foreach (Control control in targetPanel.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Panel)
                {
                    panels.Add(control);
                }
            }

            // Sort the panels by their Y position
            panels = panels.OrderBy(panel => panel.Location.Y).ToList();

            // Reorder the panels in the target panel
            int y = 0;
            foreach (Control control in targetPanel.Controls)
            {
                if (control is Label)
                {
                    y = Math.Max(y, control.Bottom + 10); // Start below any labels
                }
            }
            foreach (Control panel in panels)
            {
                // Calculate the centered X position
                int x = (targetPanel.Width - panel.Width) / 2;
                panel.Location = new Point(x, y);
                y = panel.Bottom + 10;
            }
        }

        public void CreateAndAddPanel(Guna2Panel panel, string panelText)
        {
            if (panel == null)
            {
                MessageBox.Show("Backlog paneli başlatılmadı.");
                return;
            }

            Guna.UI2.WinForms.Guna2Panel newPanel = new Guna.UI2.WinForms.Guna2Panel();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            newPanel.BackColor = Color.White;
            newPanel.BorderColor = Color.Black;
            newPanel.BorderRadius = 8;
            newPanel.BorderThickness = 2;
            newPanel.CustomBorderColor = Color.White;
            newPanel.CustomizableEdges = customizableEdges3;
            newPanel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customizableEdges4.BottomLeft = false;
            customizableEdges4.BottomRight = false;
            customizableEdges4.TopLeft = false;
            customizableEdges4.TopRight = false;
            newPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            newPanel.Size = new Size(311, 138);
            newPanel.BorderThickness = 2;
            newPanel.BorderColor = Color.Black;
            newPanel.Name = panelText;

            Label label = new Label();
            label.Text = panelText;
            label.AutoSize = true;
            label.Location = new Point(18, 23);
            newPanel.Controls.Add(label);

            newPanel.MouseDown += new MouseEventHandler(panel_MouseDown);

            panel.Controls.Add(newPanel);

            int y = GetNextPanelYPosition(panel);
            int x = (panel.Width - newPanel.Width) / 2;
            newPanel.Location = new Point(x, y);

            SortPanels(panel);
        }

        public void ClearPanels()
        {
            //Backlog clear
            backlog.Controls.Clear();
            label7 = new Label();
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(101, 20);
            label7.Name = "label7";
            label7.Size = new Size(128, 50);
            label7.TabIndex = 39;
            label7.Text = "Backlog";
            backlog.Controls.Add(label7);

            //To Do clear
            todo.Controls.Clear();
            label4 = new Label();
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 20);
            label4.Name = "label4";
            label4.Size = new Size(94, 50);
            label4.TabIndex = 38;
            label4.Text = "To Do";
            todo.Controls.Add(label4);


            //Doing clear
            doing.Controls.Clear();
            label5 = new Label();
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(121, 20);
            label5.Name = "label5";
            label5.Size = new Size(95, 50);
            label5.TabIndex = 39;
            label5.Text = "Doing";
            doing.Controls.Add(label5);


            done.Controls.Clear();
            label6 = new Label();
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(137, 20);
            label6.Name = "label6";
            label6.Size = new Size(86, 50);
            label6.TabIndex = 40;
            label6.Text = "Done";
            done.Controls.Add(label6);
        }

        private void updateIssueStatus(string issueID, string newStatus)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UpdateIssueStatus", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@issueID", issueID));
                        command.Parameters.Add(new SqlParameter("@newStatus", newStatus));

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
