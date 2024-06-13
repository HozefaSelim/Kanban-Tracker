﻿using Guna.UI2.WinForms;

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
            backlog = new Guna2Panel();
            guna2Panel6 = new Guna2Panel();
            EpicAdi = new Label();
            issueTipi = new Label();
            label7 = new Label();
            todo = new Guna2Panel();
            label4 = new Label();
            doing = new Guna2Panel();
            label5 = new Label();
            done = new Guna2Panel();
            label6 = new Label();
            issueAdi = new Label();
            backlog.SuspendLayout();
            guna2Panel6.SuspendLayout();
            todo.SuspendLayout();
            doing.SuspendLayout();
            done.SuspendLayout();
            SuspendLayout();
            // 
            // backlog
            // 
            backlog.AllowDrop = true;
            backlog.AutoScroll = true;
            backlog.BorderColor = Color.Black;
            backlog.BorderRadius = 10;
            backlog.BorderThickness = 2;
            backlog.Controls.Add(guna2Panel6);
            backlog.Controls.Add(label7);
            backlog.CustomizableEdges = customizableEdges3;
            backlog.FillColor = Color.WhiteSmoke;
            backlog.Location = new Point(140, 79);
            backlog.Margin = new Padding(3, 4, 3, 4);
            backlog.Name = "backlog";
            backlog.ShadowDecoration.BorderRadius = 0;
            backlog.ShadowDecoration.Color = Color.Bisque;
            customizableEdges4.BottomLeft = false;
            customizableEdges4.BottomRight = false;
            customizableEdges4.TopLeft = false;
            customizableEdges4.TopRight = false;
            backlog.ShadowDecoration.CustomizableEdges = customizableEdges4;
            backlog.Size = new Size(343, 733);
            backlog.TabIndex = 0;
            // 
            // guna2Panel6
            // 
            guna2Panel6.BackColor = Color.White;
            guna2Panel6.BorderColor = Color.Black;
            guna2Panel6.BorderRadius = 8;
            guna2Panel6.BorderThickness = 2;
            guna2Panel6.Controls.Add(issueAdi);
            guna2Panel6.Controls.Add(EpicAdi);
            guna2Panel6.Controls.Add(issueTipi);
            guna2Panel6.CustomBorderColor = Color.White;
            guna2Panel6.CustomizableEdges = customizableEdges1;
            guna2Panel6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Panel6.Location = new Point(18, 73);
            guna2Panel6.Name = "guna2Panel6";
            customizableEdges2.BottomLeft = false;
            customizableEdges2.BottomRight = false;
            customizableEdges2.TopLeft = false;
            customizableEdges2.TopRight = false;
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel6.Size = new Size(311, 138);
            guna2Panel6.TabIndex = 43;
            // 
            // EpicAdi
            // 
            EpicAdi.AutoSize = true;
            EpicAdi.BackColor = Color.FromArgb(128, 255, 128);
            EpicAdi.Location = new Point(18, 92);
            EpicAdi.Name = "EpicAdi";
            EpicAdi.Size = new Size(56, 18);
            EpicAdi.TabIndex = 1;
            EpicAdi.Text = "Header";
            EpicAdi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // issueTipi
            // 
            issueTipi.AutoSize = true;
            issueTipi.Location = new Point(18, 23);
            issueTipi.Name = "issueTipi";
            issueTipi.Size = new Size(98, 18);
            issueTipi.TabIndex = 0;
            issueTipi.Text = "Task or Story";
            issueTipi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(101, 20);
            label7.Name = "label7";
            label7.Size = new Size(128, 50);
            label7.TabIndex = 39;
            label7.Text = "Backlog";
            // 
            // todo
            // 
            todo.AllowDrop = true;
            todo.AutoScroll = true;
            todo.BorderColor = Color.Black;
            todo.BorderRadius = 10;
            todo.BorderThickness = 2;
            todo.Controls.Add(label4);
            todo.CustomizableEdges = customizableEdges5;
            todo.FillColor = Color.WhiteSmoke;
            todo.Location = new Point(510, 79);
            todo.Margin = new Padding(3, 4, 3, 4);
            todo.Name = "todo";
            todo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            todo.Size = new Size(343, 733);
            todo.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 20);
            label4.Name = "label4";
            label4.Size = new Size(94, 50);
            label4.TabIndex = 38;
            label4.Text = "To Do";
            // 
            // doing
            // 
            doing.AllowDrop = true;
            doing.AutoScroll = true;
            doing.BorderColor = Color.Black;
            doing.BorderRadius = 10;
            doing.BorderThickness = 2;
            doing.Controls.Add(label5);
            doing.CustomizableEdges = customizableEdges7;
            doing.FillColor = Color.WhiteSmoke;
            doing.Location = new Point(880, 79);
            doing.Margin = new Padding(3, 4, 3, 4);
            doing.Name = "doing";
            doing.ShadowDecoration.CustomizableEdges = customizableEdges8;
            doing.Size = new Size(343, 733);
            doing.TabIndex = 2;
            // 
            // label5
            // 
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(121, 20);
            label5.Name = "label5";
            label5.Size = new Size(95, 50);
            label5.TabIndex = 39;
            label5.Text = "Doing";
            // 
            // done
            // 
            done.AllowDrop = true;
            done.AutoScroll = true;
            done.BorderColor = Color.Black;
            done.BorderRadius = 10;
            done.BorderThickness = 2;
            done.Controls.Add(label6);
            done.CustomizableEdges = customizableEdges9;
            done.FillColor = Color.WhiteSmoke;
            done.Location = new Point(1250, 79);
            done.Margin = new Padding(3, 4, 3, 4);
            done.Name = "done";
            done.ShadowDecoration.CustomizableEdges = customizableEdges10;
            done.Size = new Size(343, 733);
            done.TabIndex = 3;
            // 
            // label6
            // 
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(137, 20);
            label6.Name = "label6";
            label6.Size = new Size(86, 50);
            label6.TabIndex = 40;
            label6.Text = "Done";
            // 
            // issueAdi
            // 
            issueAdi.AutoSize = true;
            issueAdi.Location = new Point(18, 56);
            issueAdi.Name = "issueAdi";
            issueAdi.Size = new Size(48, 18);
            issueAdi.TabIndex = 2;
            issueAdi.Text = "Name";
            issueAdi.TextAlign = ContentAlignment.MiddleLeft;
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
            Size = new Size(1729, 937);
            backlog.ResumeLayout(false);
            guna2Panel6.ResumeLayout(false);
            guna2Panel6.PerformLayout();
            todo.ResumeLayout(false);
            doing.ResumeLayout(false);
            done.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Label issueTipi;
        private Label EpicAdi;
        public Guna2Panel backlog;
        public Guna2Panel todo;
        public Guna2Panel doing;
        public Guna2Panel done;
        private Label issueAdi;
    }
}
