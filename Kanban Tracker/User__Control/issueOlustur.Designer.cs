namespace Kanban_Tracker
{
    partial class issueOlustur
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issueOlustur));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            closeBtn = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            label3 = new Label();
            aciklamaTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            projeEkleBtni = new Guna.UI2.WinForms.Guna2Button();
            issueType = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            label7 = new Label();
            projeAdiLbl = new Label();
            durum = new Guna.UI2.WinForms.Guna2ComboBox();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.CustomizableEdges = customizableEdges1;
            closeBtn.DisabledState.BorderColor = Color.DarkGray;
            closeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            closeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeBtn.FillColor = Color.White;
            closeBtn.Font = new Font("Segoe UI", 9F);
            closeBtn.ForeColor = Color.White;
            closeBtn.HoverState.FillColor = Color.GhostWhite;
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.ImageSize = new Size(50, 50);
            closeBtn.Location = new Point(454, 18);
            closeBtn.Name = "closeBtn";
            closeBtn.PressedColor = Color.GhostWhite;
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            closeBtn.Size = new Size(50, 51);
            closeBtn.TabIndex = 32;
            closeBtn.Click += closeBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(86, 353);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 27;
            label4.Text = "Durum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(86, 244);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 26;
            label3.Text = "Issue tipi";
            // 
            // aciklamaTxtBox
            // 
            aciklamaTxtBox.BorderColor = Color.Black;
            aciklamaTxtBox.BorderRadius = 9;
            aciklamaTxtBox.CustomizableEdges = customizableEdges3;
            aciklamaTxtBox.DefaultText = "";
            aciklamaTxtBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            aciklamaTxtBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            aciklamaTxtBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            aciklamaTxtBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            aciklamaTxtBox.FillColor = SystemColors.GradientActiveCaption;
            aciklamaTxtBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            aciklamaTxtBox.Font = new Font("Segoe UI", 9F);
            aciklamaTxtBox.ForeColor = Color.Black;
            aciklamaTxtBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            aciklamaTxtBox.Location = new Point(86, 493);
            aciklamaTxtBox.Margin = new Padding(3, 5, 3, 5);
            aciklamaTxtBox.Name = "aciklamaTxtBox";
            aciklamaTxtBox.PasswordChar = '\0';
            aciklamaTxtBox.PlaceholderForeColor = Color.Gray;
            aciklamaTxtBox.PlaceholderText = "";
            aciklamaTxtBox.RightToLeft = RightToLeft.No;
            aciklamaTxtBox.SelectedText = "";
            aciklamaTxtBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            aciklamaTxtBox.Size = new Size(361, 155);
            aciklamaTxtBox.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(86, 55);
            label2.Name = "label2";
            label2.Size = new Size(236, 39);
            label2.TabIndex = 23;
            label2.Text = "Issue Oluştur";
            // 
            // projeEkleBtni
            // 
            projeEkleBtni.CustomizableEdges = customizableEdges5;
            projeEkleBtni.DisabledState.BorderColor = Color.DarkGray;
            projeEkleBtni.DisabledState.CustomBorderColor = Color.DarkGray;
            projeEkleBtni.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            projeEkleBtni.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            projeEkleBtni.FillColor = SystemColors.GradientActiveCaption;
            projeEkleBtni.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projeEkleBtni.ForeColor = Color.Black;
            projeEkleBtni.Location = new Point(197, 700);
            projeEkleBtni.Name = "projeEkleBtni";
            projeEkleBtni.ShadowDecoration.CustomizableEdges = customizableEdges6;
            projeEkleBtni.Size = new Size(138, 44);
            projeEkleBtni.TabIndex = 33;
            projeEkleBtni.Text = "Ekle";
            projeEkleBtni.Click += projeEkleBtni_Click;
            // 
            // issueType
            // 
            issueType.BackColor = Color.Transparent;
            issueType.CustomizableEdges = customizableEdges7;
            issueType.DisplayMember = "Task";
            issueType.DrawMode = DrawMode.OwnerDrawFixed;
            issueType.DropDownStyle = ComboBoxStyle.DropDownList;
            issueType.FillColor = SystemColors.GradientActiveCaption;
            issueType.FocusedColor = Color.FromArgb(94, 148, 255);
            issueType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            issueType.Font = new Font("Segoe UI", 10F);
            issueType.ForeColor = Color.FromArgb(68, 88, 112);
            issueType.ItemHeight = 30;
            issueType.Items.AddRange(new object[] { "task", "epik", "story" });
            issueType.Location = new Point(86, 276);
            issueType.Margin = new Padding(3, 4, 3, 4);
            issueType.Name = "issueType";
            issueType.ShadowDecoration.CustomizableEdges = customizableEdges8;
            issueType.Size = new Size(361, 36);
            issueType.TabIndex = 34;
            issueType.ValueMember = "Task ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(86, 460);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 35;
            label1.Text = "Issue Açıklaması";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(86, 135);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 36;
            label7.Text = "Proje Adı";
            // 
            // projeAdiLbl
            // 
            projeAdiLbl.BackColor = SystemColors.GradientActiveCaption;
            projeAdiLbl.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projeAdiLbl.Location = new Point(86, 172);
            projeAdiLbl.Name = "projeAdiLbl";
            projeAdiLbl.Size = new Size(361, 48);
            projeAdiLbl.TabIndex = 41;
            projeAdiLbl.Text = "Proje Adı";
            projeAdiLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // durum
            // 
            durum.BackColor = Color.Transparent;
            durum.CustomizableEdges = customizableEdges9;
            durum.DisplayMember = "Task";
            durum.DrawMode = DrawMode.OwnerDrawFixed;
            durum.DropDownStyle = ComboBoxStyle.DropDownList;
            durum.FillColor = SystemColors.GradientActiveCaption;
            durum.FocusedColor = Color.FromArgb(94, 148, 255);
            durum.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            durum.Font = new Font("Segoe UI", 10F);
            durum.ForeColor = Color.FromArgb(68, 88, 112);
            durum.ItemHeight = 30;
            durum.Items.AddRange(new object[] { "Done", "in progress" });
            durum.Location = new Point(88, 385);
            durum.Margin = new Padding(3, 4, 3, 4);
            durum.Name = "durum";
            durum.ShadowDecoration.CustomizableEdges = customizableEdges10;
            durum.Size = new Size(361, 36);
            durum.TabIndex = 42;
            durum.ValueMember = "Task ";
            // 
            // issueOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(durum);
            Controls.Add(projeAdiLbl);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(issueType);
            Controls.Add(projeEkleBtni);
            Controls.Add(closeBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(aciklamaTxtBox);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "issueOlustur";
            Size = new Size(535, 804);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button closeBtn;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox aciklamaTxtBox;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button projeEkleBtni;
        private Guna.UI2.WinForms.Guna2ComboBox issueType;
        private Label label1;
        private Label label7;
        private Label projeAdiLbl;
        private Guna.UI2.WinForms.Guna2ComboBox durum;
    }
}
