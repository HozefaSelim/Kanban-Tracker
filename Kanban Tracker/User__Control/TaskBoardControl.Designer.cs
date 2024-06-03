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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backlog = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label9 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            label7 = new Label();
            todo = new Guna.UI2.WinForms.Guna2Panel();
            label4 = new Label();
            doing = new Guna.UI2.WinForms.Guna2Panel();
            label5 = new Label();
            done = new Guna.UI2.WinForms.Guna2Panel();
            label6 = new Label();
            backlog.SuspendLayout();
            guna2Panel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            todo.SuspendLayout();
            doing.SuspendLayout();
            done.SuspendLayout();
            SuspendLayout();
            // 
            // backlog
            // 
            backlog.AllowDrop = true;
            backlog.BorderColor = Color.Black;
            backlog.BorderRadius = 10;
            backlog.BorderThickness = 1;
            backlog.Controls.Add(guna2Panel2);
            backlog.Controls.Add(guna2Panel1);
            backlog.Controls.Add(label7);
            backlog.CustomizableEdges = customizableEdges5;
            backlog.FillColor = Color.FromArgb(237, 245, 252);
            backlog.Location = new Point(41, 59);
            backlog.Name = "backlog";
            backlog.ShadowDecoration.CustomizableEdges = customizableEdges6;
            backlog.Size = new Size(270, 550);
            backlog.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(label9);
            guna2Panel2.CustomizableEdges = customizableEdges1;
            guna2Panel2.FillColor = Color.FromArgb(128, 255, 128);
            guna2Panel2.Location = new Point(27, 153);
            guna2Panel2.Margin = new Padding(3, 2, 3, 2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(219, 71);
            guna2Panel2.TabIndex = 39;
            // 
            // label9
            // 
            label9.Location = new Point(46, 16);
            label9.Name = "label9";
            label9.Size = new Size(112, 40);
            label9.TabIndex = 1;
            label9.Text = "label9";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.FromArgb(128, 255, 128);
            guna2Panel1.Location = new Point(27, 63);
            guna2Panel1.Margin = new Padding(3, 2, 3, 2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(219, 68);
            guna2Panel1.TabIndex = 38;
            // 
            // label2
            // 
            label2.Location = new Point(46, 13);
            label2.Name = "label2";
            label2.Size = new Size(112, 40);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(237, 245, 252);
            label7.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(74, 7);
            label7.Name = "label7";
            label7.Size = new Size(100, 26);
            label7.TabIndex = 37;
            label7.Text = "Backlog";
            // 
            // todo
            // 
            todo.AllowDrop = true;
            todo.BorderColor = Color.Black;
            todo.BorderRadius = 10;
            todo.BorderThickness = 1;
            todo.Controls.Add(label4);
            todo.CustomizableEdges = customizableEdges7;
            todo.FillColor = Color.FromArgb(237, 245, 252);
            todo.Location = new Point(345, 59);
            todo.Name = "todo";
            todo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            todo.Size = new Size(270, 550);
            todo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(237, 245, 252);
            label4.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 7);
            label4.Name = "label4";
            label4.Size = new Size(74, 26);
            label4.TabIndex = 38;
            label4.Text = "To Do";
            // 
            // doing
            // 
            doing.AllowDrop = true;
            doing.BorderColor = Color.Black;
            doing.BorderRadius = 10;
            doing.BorderThickness = 1;
            doing.Controls.Add(label5);
            doing.CustomizableEdges = customizableEdges9;
            doing.FillColor = Color.FromArgb(237, 245, 252);
            doing.Location = new Point(644, 59);
            doing.Name = "doing";
            doing.ShadowDecoration.CustomizableEdges = customizableEdges10;
            doing.Size = new Size(270, 550);
            doing.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(237, 245, 252);
            label5.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 9);
            label5.Name = "label5";
            label5.Size = new Size(74, 26);
            label5.TabIndex = 39;
            label5.Text = "Donig";
            // 
            // done
            // 
            done.AllowDrop = true;
            done.BorderColor = Color.Black;
            done.BorderRadius = 10;
            done.BorderThickness = 1;
            done.Controls.Add(label6);
            done.CustomizableEdges = customizableEdges11;
            done.FillColor = Color.FromArgb(237, 245, 252);
            done.Location = new Point(944, 59);
            done.Name = "done";
            done.ShadowDecoration.CustomizableEdges = customizableEdges12;
            done.Size = new Size(255, 550);
            done.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(237, 245, 252);
            label6.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(90, 9);
            label6.Name = "label6";
            label6.Size = new Size(67, 26);
            label6.TabIndex = 40;
            label6.Text = "Done";
            // 
            // TaskBoardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(done);
            Controls.Add(doing);
            Controls.Add(todo);
            Controls.Add(backlog);
            Name = "TaskBoardControl";
            Size = new Size(1348, 703);
            backlog.ResumeLayout(false);
            backlog.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            todo.ResumeLayout(false);
            todo.PerformLayout();
            doing.ResumeLayout(false);
            doing.PerformLayout();
            done.ResumeLayout(false);
            done.PerformLayout();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel backlog;
        private Guna.UI2.WinForms.Guna2Panel todo;
        private Guna.UI2.WinForms.Guna2Panel doing;
        private Guna.UI2.WinForms.Guna2Panel done;
        private System.Windows.Forms.Label label2;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label9;
    }
}
