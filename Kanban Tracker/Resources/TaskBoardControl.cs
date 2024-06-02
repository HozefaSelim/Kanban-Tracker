using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kanban_Tracker
{
    public partial class TaskBoardControl : UserControl
    {
        public TaskBoardControl()
        {
            InitializeComponent();
            InitializeDragDrop();
        }

        private void InitializeDragDrop()
        {
            // Set up the drag event handlers for each label in backlog
            foreach (Control control in backlog.Controls)
            {
                if (control is Label)
                {
                    control.MouseDown += new MouseEventHandler(label_MouseDown);
                }
            }

            // Set up the drag event handlers for the panels
            todo.DragEnter += new DragEventHandler(panel_DragEnter);
            todo.DragDrop += new DragEventHandler(panel_DragDrop);

            doing.DragEnter += new DragEventHandler(panel_DragEnter);
            doing.DragDrop += new DragEventHandler(panel_DragDrop);

            done.DragEnter += new DragEventHandler(panel_DragEnter);
            done.DragDrop += new DragEventHandler(panel_DragDrop);
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                // Initiate the drag-and-drop operation
                DoDragDrop(lbl, DragDropEffects.Move);
            }
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                // Check if the target is one of the allowed panels
                Panel pnl = sender as Panel;
                if (pnl == todo || pnl == doing || pnl == done)
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

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                Label lbl = (Label)e.Data.GetData(typeof(Label));
                Panel pnl = (Panel)sender;

                // Reposition the label within the new panel
                lbl.Parent = pnl;

                // Calculate the new position
                int y = 10; // Starting position for the first label
                foreach (Control control in pnl.Controls)
                {
                    if (control is Label && control != lbl)
                    {
                        y = Math.Max(y, control.Bottom + 10); // Stack labels vertically with a 10-pixel gap
                    }
                }
                lbl.Location = new Point(10, y); // 10-pixel padding from the left
            }
        }
    }
}
