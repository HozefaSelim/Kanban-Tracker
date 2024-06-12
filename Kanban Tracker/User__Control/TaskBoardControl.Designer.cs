namespace Kanban_Tracker
{
    partial class TaskBoardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backlog = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            label10 = new Label();
            label7 = new Label();
            todo = new Guna.UI2.WinForms.Guna2Panel();
            label4 = new Label();
            doing = new Guna.UI2.WinForms.Guna2Panel();
            label5 = new Label();
            done = new Guna.UI2.WinForms.Guna2Panel();
            label6 = new Label();
            newChildPanel = new Guna.UI2.WinForms.Guna2Panel();
            label11 = new Label();
            backlog.SuspendLayout();
            guna2Panel6.SuspendLayout();
            todo.SuspendLayout();
            doing.SuspendLayout();
            done.SuspendLayout();
            newChildPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backlog
            // 
            backlog.AllowDrop = true;
            backlog.AutoScroll = true;
            backlog.BorderColor = Color.Black;
            backlog.BorderRadius = 10;
            backlog.BorderThickness = 1;
            backlog.Controls.Add(guna2Panel6);
            backlog.Controls.Add(newChildPanel);
            backlog.Controls.Add(label7);
            backlog.CustomizableEdges = customizableEdges3;
            backlog.FillColor = Color.FromArgb(237, 245, 252);
            backlog.Location = new Point(122, 79);
            backlog.Margin = new Padding(3, 4, 3, 4);
            backlog.Name = "backlog";
            backlog.ShadowDecoration.CustomizableEdges = customizableEdges4;
            backlog.Size = new Size(309, 733);
            backlog.TabIndex = 0;
            // 
            // guna2Panel6
            // 
            guna2Panel6.Controls.Add(label10);
            guna2Panel6.CustomizableEdges = customizableEdges1;
            guna2Panel6.Location = new Point(32, 73);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel6.Size = new Size(250, 125);
            guna2Panel6.TabIndex = 43;
            guna2Panel6.BackColor = Color.Black;  // Set background color to black
            // 
            // label10
            // 
            label10.Location = new Point(53, 33);
            label10.Name = "label10";
            label10.Size = new Size(128, 54);
            label10.TabIndex = 1;
            label10.Text = "label10";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.ForeColor = Color.White;  // Set label text color to white for better contrast
            // 
            // newChildPanel
            // 
            newChildPanel.Controls.Add(label11);
            newChildPanel.CustomizableEdges = customizableEdges1;
            newChildPanel.Location = new Point(32, 220);
            newChildPanel.Name = "newChildPanel";
            newChildPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            newChildPanel.Size = new Size(250, 125);
            newChildPanel.TabIndex = 44;
            newChildPanel.BackColor = Color.LightGray;  // Set background color of new panel
            // 
            // label11
            // 
            label11.Location = new Point(53, 33);
            label11.Name = "label11";
            label11.Size = new Size(128, 54);
            label11.TabIndex = 1;
            label11.Text = "newChildPanel";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(237, 245, 252);
            label7.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(84, 9);
            label7.Name = "label7";
            label7.Size = new Size(128, 61);
            label7.TabIndex = 39;
            label7.Text = "Backlog";
            // 
            // todo
            // 
            todo.AllowDrop = true;
            todo.AutoScroll = true;
            todo.BorderColor = Color.Black;
            todo.BorderRadius = 10;
            todo.BorderThickness = 1;
            todo.Controls.Add(label4);
            todo.CustomizableEdges = customizableEdges5;
            todo.FillColor = Color.FromArgb(237, 245, 252);
            todo.Location = new Point(470, 79);
            todo.Margin = new Padding(3, 4, 3, 4);
            todo.Name = "todo";
            todo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            todo.Size = new Size(309, 733);
            todo.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(237, 245, 252);
            label4.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 9);
            label4.Name = "label4";
            label4.Size = new Size(94, 61);
            label4.TabIndex = 38;
            label4.Text = "To Do";
            // 
            // doing
            // 
            doing.AllowDrop = true;
            doing.AutoScroll = true;
            doing.BorderColor = Color.Black;
            doing.BorderRadius = 10;
            doing.BorderThickness = 1;
            doing.Controls.Add(label5);
            doing.CustomizableEdges = customizableEdges7;
            doing.FillColor = Color.FromArgb(237, 245, 252);
            doing.Location = new Point(820, 79);
            doing.Margin = new Padding(3, 4, 3, 4);
            doing.Name = "doing";
            doing.ShadowDecoration.CustomizableEdges = customizableEdges8;
            doing.Size = new Size(309, 733);
            doing.TabIndex = 2;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(237, 245, 252);
            label5.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 12);
            label5.Name = "label5";
            label5.Size = new Size(95, 61);
            label5.TabIndex = 39;
            label5.Text = "Doing";
            // 
            // done
            // 
            done.AllowDrop = true;
            done.AutoScroll = true;
            done.BorderColor = Color.Black;
            done.BorderRadius = 10;
            done.BorderThickness = 1;
            done.Controls.Add(label6);
            done.CustomizableEdges = customizableEdges9;
            done.FillColor = Color.FromArgb(237, 245, 252);
            done.Location = new Point(1172, 79);
            done.Margin = new Padding(3, 4, 3, 4);
            done.Name = "done";
            done.ShadowDecoration.CustomizableEdges = customizableEdges10;
            done.Size = new Size(309, 733);
            done.TabIndex = 3;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(237, 245, 252);
            label6.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(123, 12);
            label6.Name = "label6";
            label6.Size = new Size(86, 61);
            label6.TabIndex = 40;
            label6.Text = "Done";
            // 
            // TaskBoardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(done);
            Controls.Add(doing);
            Controls.Add(todo);
            Controls.Add(backlog);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskBoardControl";
            Size = new Size(1540, 937);
            backlog.ResumeLayout(false);
            guna2Panel6.ResumeLayout(false);
            todo.ResumeLayout(false);
            doing.ResumeLayout(false);
            done.ResumeLayout(false);
            newChildPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel backlog;
        private Guna.UI2.WinForms.Guna2Panel todo;
        private Guna.UI2.WinForms.Guna2Panel doing;
        private Guna.UI2.WinForms.Guna2Panel done;
        private Label label4;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Label label10;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Panel newChildPanel;
        private Label label11;
    }
}
