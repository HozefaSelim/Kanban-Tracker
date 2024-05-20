namespace Kanban_Tracker
{
    partial class SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            panel1 = new Panel();
            checkBoxP = new CheckBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            email = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label1 = new Label();
            logo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(249, 250, 252);
            panel1.Controls.Add(checkBoxP);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(email);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(logo);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 723);
            panel1.TabIndex = 0;
            // 
            // checkBoxP
            // 
            checkBoxP.AutoSize = true;
            checkBoxP.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxP.Location = new Point(544, 575);
            checkBoxP.Name = "checkBoxP";
            checkBoxP.Size = new Size(133, 22);
            checkBoxP.TabIndex = 6;
            checkBoxP.Text = "Show Password";
            checkBoxP.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxP.UseVisualStyleBackColor = true;
            checkBoxP.CheckedChanged += checkBoxP_CheckedChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 175, 239);
            guna2Button1.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(638, 636);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 5;
            guna2Button1.Text = "Sign In";
            // 
            // password
            // 
            password.BorderColor = Color.FromArgb(64, 64, 64);
            password.BorderRadius = 9;
            password.CustomizableEdges = customizableEdges3;
            password.DefaultText = "";
            password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Font = new Font("Segoe UI", 9F);
            password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Location = new Point(534, 508);
            password.Name = "password";
            password.PasswordChar = '●';
            password.PlaceholderText = "";
            password.RightToLeft = RightToLeft.No;
            password.SelectedText = "";
            password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            password.Size = new Size(316, 36);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // email
            // 
            email.BorderColor = Color.FromArgb(64, 64, 64);
            email.BorderRadius = 9;
            email.CustomizableEdges = customizableEdges5;
            email.DefaultText = "";
            email.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            email.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            email.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            email.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            email.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            email.Font = new Font("Segoe UI", 9F);
            email.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            email.Location = new Point(534, 404);
            email.Name = "email";
            email.PasswordChar = '\0';
            email.PlaceholderText = "you@example.com";
            email.RightToLeft = RightToLeft.No;
            email.SelectedText = "";
            email.ShadowDecoration.CustomizableEdges = customizableEdges6;
            email.Size = new Size(316, 36);
            email.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(156, 160, 169);
            label2.Location = new Point(534, 458);
            label2.Name = "label2";
            label2.Size = new Size(122, 26);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(156, 160, 169);
            label1.Location = new Point(534, 349);
            label1.Name = "label1";
            label1.Size = new Size(122, 26);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(422, 32);
            logo.Name = "logo";
            logo.Size = new Size(465, 304);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 722);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SignIn";
            RightToLeft = RightToLeft.Yes;
            Text = "Kanban Tracker";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox logo;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private CheckBox checkBoxP;
    }
}
