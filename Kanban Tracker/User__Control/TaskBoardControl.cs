using Kanban_Tracker.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Kanban_Tracker
{
    public partial class TaskBoardControl : UserControl
    {
        //private string connectionStr = "Data Source = DESKTOP-GKGSCQS\\SQLEXPRESS; Initial Catalog=KanbanTracker;Integrated Security=true";
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
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
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

                // Sort the panels in both the original and target panels
                SortPanels(originalPanel);
                SortPanels(targetPanel);
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
        private void CreateAndAddPanelToBacklog(string panelText)
        {
            // Küçük panel oluştur
            Guna.UI2.WinForms.Guna2Panel newPanel = new Guna.UI2.WinForms.Guna2Panel();
            newPanel.Size = new Size(200, 100); // Panelin boyutları, ihtiyacınıza göre ayarlayın
            newPanel.BorderThickness = 1; // Kenarlık kalınlığı
            newPanel.BorderColor = Color.Black; // Kenarlık rengi

            // Panelin içine yazı ekle
            Label label = new Label();
            label.Text = panelText;
            label.AutoSize = true;
            label.Location = new Point(10, 10); // Panel içindeki yazının konumu
            newPanel.Controls.Add(label);

            // Panelin MouseDown olayını ayarla
            newPanel.MouseDown += new MouseEventHandler(panel_MouseDown);

            // Paneli backlog içine ekle
            backlog.Controls.Add(newPanel);

            // Yeni panelin konumunu ayarla
            int y = GetNextPanelYPosition(backlog);
            int x = (backlog.Width - newPanel.Width) / 2;
            newPanel.Location = new Point(x, y);

            // Panelleri sırala
            SortPanels(backlog);
        }


    }
}
