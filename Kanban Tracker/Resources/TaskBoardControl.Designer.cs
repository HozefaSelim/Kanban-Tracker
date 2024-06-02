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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backlog = new Guna.UI2.WinForms.Guna2Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            todo = new Guna.UI2.WinForms.Guna2Panel();
            doing = new Guna.UI2.WinForms.Guna2Panel();
            done = new Guna.UI2.WinForms.Guna2Panel();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            backlog.SuspendLayout();
            todo.SuspendLayout();
            doing.SuspendLayout();
            done.SuspendLayout();
            SuspendLayout();
            // 
            // backlog
            // 
            backlog.AllowDrop = true;
            backlog.Controls.Add(label7);
            backlog.Controls.Add(label3);
            backlog.Controls.Add(label2);
            backlog.Controls.Add(label1);
            backlog.CustomizableEdges = customizableEdges1;
            backlog.FillColor = SystemColors.ActiveCaption;
            backlog.Location = new Point(44, 59);
            backlog.Name = "backlog";
            backlog.ShadowDecoration.CustomizableEdges = customizableEdges2;
            backlog.Size = new Size(206, 384);
            backlog.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 131);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 101);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 71);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // todo
            // 
            todo.AllowDrop = true;
            todo.Controls.Add(label4);
            todo.CustomizableEdges = customizableEdges3;
            todo.FillColor = SystemColors.MenuHighlight;
            todo.Location = new Point(288, 59);
            todo.Name = "todo";
            todo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            todo.Size = new Size(206, 384);
            todo.TabIndex = 1;
            // 
            // doing
            // 
            doing.AllowDrop = true;
            doing.Controls.Add(label5);
            doing.CustomizableEdges = customizableEdges5;
            doing.FillColor = Color.IndianRed;
            doing.Location = new Point(530, 59);
            doing.Name = "doing";
            doing.ShadowDecoration.CustomizableEdges = customizableEdges6;
            doing.Size = new Size(206, 384);
            doing.TabIndex = 2;
            // 
            // done
            // 
            done.AllowDrop = true;
            done.Controls.Add(label6);
            done.CustomizableEdges = customizableEdges7;
            done.FillColor = Color.DarkKhaki;
            done.Location = new Point(772, 59);
            done.Name = "done";
            done.ShadowDecoration.CustomizableEdges = customizableEdges8;
            done.Size = new Size(206, 372);
            done.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(4, 10);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 37;
            label7.Text = "Backlog";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 38;
            label4.Text = "To Do";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 39;
            label5.Text = "Donig";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 40;
            label6.Text = "Done";
            // 
            // TaskBoardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(done);
            Controls.Add(doing);
            Controls.Add(todo);
            Controls.Add(backlog);
            Name = "TaskBoardControl";
            Size = new Size(996, 523);
            backlog.ResumeLayout(false);
            backlog.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
