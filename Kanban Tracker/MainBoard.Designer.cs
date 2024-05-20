namespace Kanban_Tracker
{
    partial class MainBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            sidebar = new Panel();
            issuses = new Button();
            Goals = new Button();
            list = new Button();
            Board = new Button();
            timeline = new Button();
            pictureBox1 = new PictureBox();
            BtnSlide = new PictureBox();
            container = new Panel();
            header = new Panel();
            Teams = new Button();
            Dashboards = new Button();
            Create = new Button();
            projects = new Button();
            button2 = new Button();
            userName = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnSlide).BeginInit();
            container.SuspendLayout();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(0, 175, 239);
            sidebar.Controls.Add(issuses);
            sidebar.Controls.Add(Goals);
            sidebar.Controls.Add(list);
            sidebar.Controls.Add(Board);
            sidebar.Controls.Add(timeline);
            sidebar.Controls.Add(pictureBox1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 677);
            sidebar.TabIndex = 0;
            // 
            // issuses
            // 
            issuses.FlatAppearance.BorderSize = 0;
            issuses.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            issuses.FlatStyle = FlatStyle.Flat;
            issuses.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issuses.ForeColor = Color.White;
            issuses.Image = (Image)resources.GetObject("issuses.Image");
            issuses.ImageAlign = ContentAlignment.MiddleLeft;
            issuses.Location = new Point(0, 410);
            issuses.Name = "issuses";
            issuses.Padding = new Padding(20, 0, 0, 0);
            issuses.Size = new Size(255, 60);
            issuses.TabIndex = 4;
            issuses.Text = "Issues";
            issuses.UseVisualStyleBackColor = true;
            // 
            // Goals
            // 
            Goals.FlatAppearance.BorderSize = 0;
            Goals.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Goals.FlatStyle = FlatStyle.Flat;
            Goals.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Goals.ForeColor = Color.White;
            Goals.Image = (Image)resources.GetObject("Goals.Image");
            Goals.ImageAlign = ContentAlignment.MiddleLeft;
            Goals.Location = new Point(0, 347);
            Goals.Name = "Goals";
            Goals.Padding = new Padding(20, 0, 0, 0);
            Goals.Size = new Size(255, 57);
            Goals.TabIndex = 3;
            Goals.Text = "Goals";
            Goals.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            list.FlatAppearance.BorderSize = 0;
            list.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            list.FlatStyle = FlatStyle.Flat;
            list.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            list.ForeColor = Color.White;
            list.Image = (Image)resources.GetObject("list.Image");
            list.ImageAlign = ContentAlignment.MiddleLeft;
            list.Location = new Point(0, 284);
            list.Name = "list";
            list.Padding = new Padding(20, 0, 0, 0);
            list.Size = new Size(255, 57);
            list.TabIndex = 2;
            list.Text = "List";
            list.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            Board.FlatAppearance.BorderSize = 0;
            Board.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Board.FlatStyle = FlatStyle.Flat;
            Board.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Board.ForeColor = Color.White;
            Board.Image = (Image)resources.GetObject("Board.Image");
            Board.ImageAlign = ContentAlignment.MiddleLeft;
            Board.Location = new Point(0, 212);
            Board.Name = "Board";
            Board.Padding = new Padding(20, 0, 0, 0);
            Board.Size = new Size(255, 57);
            Board.TabIndex = 1;
            Board.Text = "Board";
            Board.UseVisualStyleBackColor = true;
            // 
            // timeline
            // 
            timeline.FlatAppearance.BorderSize = 0;
            timeline.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            timeline.FlatStyle = FlatStyle.Flat;
            timeline.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeline.ForeColor = Color.White;
            timeline.Image = (Image)resources.GetObject("timeline.Image");
            timeline.ImageAlign = ContentAlignment.MiddleLeft;
            timeline.Location = new Point(0, 149);
            timeline.Name = "timeline";
            timeline.Padding = new Padding(20, 0, 0, 0);
            timeline.Size = new Size(258, 57);
            timeline.TabIndex = 0;
            timeline.Text = "Timeline";
            timeline.UseVisualStyleBackColor = true;
            timeline.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnSlide
            // 
            BtnSlide.Cursor = Cursors.Hand;
            BtnSlide.Image = (Image)resources.GetObject("BtnSlide.Image");
            BtnSlide.Location = new Point(5, 3);
            BtnSlide.Name = "BtnSlide";
            BtnSlide.Size = new Size(35, 35);
            BtnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSlide.TabIndex = 0;
            BtnSlide.TabStop = false;
            BtnSlide.Click += BtnSlide_Click;
            // 
            // container
            // 
            container.BackColor = SystemColors.Control;
            container.BorderStyle = BorderStyle.FixedSingle;
            container.Controls.Add(header);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(200, 0);
            container.Name = "container";
            container.Size = new Size(916, 677);
            container.TabIndex = 2;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(0, 175, 239);
            header.Controls.Add(Teams);
            header.Controls.Add(Dashboards);
            header.Controls.Add(Create);
            header.Controls.Add(projects);
            header.Controls.Add(button2);
            header.Controls.Add(userName);
            header.Controls.Add(button1);
            header.Controls.Add(pictureBox2);
            header.Controls.Add(BtnSlide);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(914, 49);
            header.TabIndex = 1;
            // 
            // Teams
            // 
            Teams.Cursor = Cursors.Hand;
            Teams.FlatAppearance.BorderSize = 0;
            Teams.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Teams.FlatStyle = FlatStyle.Flat;
            Teams.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Teams.ForeColor = Color.White;
            Teams.Location = new Point(307, 0);
            Teams.Name = "Teams";
            Teams.Size = new Size(118, 50);
            Teams.TabIndex = 5;
            Teams.Text = "Teams";
            Teams.UseVisualStyleBackColor = true;
            // 
            // Dashboards
            // 
            Dashboards.Cursor = Cursors.Hand;
            Dashboards.FlatAppearance.BorderSize = 0;
            Dashboards.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            Dashboards.FlatStyle = FlatStyle.Flat;
            Dashboards.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboards.ForeColor = Color.White;
            Dashboards.Location = new Point(193, 0);
            Dashboards.Name = "Dashboards";
            Dashboards.Size = new Size(118, 50);
            Dashboards.TabIndex = 3;
            Dashboards.Text = "Dashboards";
            Dashboards.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            Create.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Create.BackColor = Color.FromArgb(45, 45, 48);
            Create.Cursor = Cursors.Hand;
            Create.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            Create.FlatAppearance.BorderSize = 2;
            Create.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 175, 239);
            Create.FlatStyle = FlatStyle.Flat;
            Create.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Create.ForeColor = Color.White;
            Create.Location = new Point(516, -1);
            Create.Name = "Create";
            Create.Size = new Size(118, 50);
            Create.TabIndex = 4;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = false;
            // 
            // projects
            // 
            projects.Cursor = Cursors.Hand;
            projects.FlatAppearance.BorderSize = 0;
            projects.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            projects.FlatStyle = FlatStyle.Flat;
            projects.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projects.ForeColor = Color.White;
            projects.Location = new Point(84, -1);
            projects.Name = "projects";
            projects.Size = new Size(118, 50);
            projects.TabIndex = 2;
            projects.Text = "Projects";
            projects.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(656, 12);
            button2.Name = "button2";
            button2.Size = new Size(36, 27);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userName.AutoSize = true;
            userName.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName.ForeColor = Color.White;
            userName.Location = new Point(738, 12);
            userName.Name = "userName";
            userName.Size = new Size(110, 21);
            userName.TabIndex = 2;
            userName.Text = "NameOfUser";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(698, 12);
            button1.Name = "button1";
            button1.Size = new Size(34, 27);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(854, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // MainBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 677);
            Controls.Add(container);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainBoard";
            Text = "MainBoard";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnSlide).EndInit();
            container.ResumeLayout(false);
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private PictureBox BtnSlide;
        private Panel container;
        private PictureBox pictureBox1;
        private Button timeline;
        private Button Board;
        private Button list;
        private Button issuses;
        private Button Goals;
        private Panel header;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Label userName;
        private Button projects;
        private Button Create;
        private Button Teams;
        private Button Dashboards;
    }
}