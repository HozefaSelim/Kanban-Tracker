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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            todo = new Guna.UI2.WinForms.Guna2Panel();
            label4 = new Label();
            doing = new Guna.UI2.WinForms.Guna2Panel();
            label5 = new Label();
            done = new Guna.UI2.WinForms.Guna2Panel();
            label6 = new Label();
            backlog.SuspendLayout();
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
            backlog.Controls.Add(guna2Panel1);
            backlog.Controls.Add(label7);
            backlog.Controls.Add(label3);
            backlog.CustomizableEdges = customizableEdges3;
            backlog.FillColor = Color.FromArgb(237, 245, 252);
            backlog.Location = new Point(122, 79);
            backlog.Margin = new Padding(3, 4, 3, 4);
            backlog.Name = "backlog";
            backlog.ShadowDecoration.CustomizableEdges = customizableEdges4;
            backlog.Size = new Size(309, 733);
            backlog.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(31, 82);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(250, 125);
            guna2Panel1.TabIndex = 38;
            // 
            // label2
            // 
            label2.Location = new Point(53, 33);
            label2.Name = "label2";
            label2.Size = new Size(128, 54);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(237, 245, 252);
            label7.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(85, 9);
            label7.Name = "label7";
            label7.Size = new Size(127, 70);
            label7.TabIndex = 37;
            label7.Text = "Backlog";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 252);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // todo
            // 
            todo.AllowDrop = true;
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
            label4.Size = new Size(94, 70);
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
            label5.Size = new Size(95, 70);
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
            label6.Size = new Size(86, 70);
            label6.TabIndex = 40;
            label6.Text = "Done";
            // 
            // TaskBoardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(done);
            Controls.Add(doing);
            Controls.Add(todo);
            Controls.Add(backlog);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskBoardControl";
            Size = new Size(1540, 937);
            backlog.ResumeLayout(false);
            backlog.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            todo.ResumeLayout(false);
            doing.ResumeLayout(false);
            done.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel backlog;
        private Guna.UI2.WinForms.Guna2Panel todo;
        private Guna.UI2.WinForms.Guna2Panel doing;
        private Guna.UI2.WinForms.Guna2Panel done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
