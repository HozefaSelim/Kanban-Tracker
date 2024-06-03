namespace Kanban_Tracker.User__Control
{
    partial class projects_
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projects_));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            projelerDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            projeAdi = new DataGridViewTextBoxColumn();
            projeAciklama = new DataGridViewTextBoxColumn();
            baslangicTarih = new DataGridViewTextBoxColumn();
            bitistarih = new DataGridViewTextBoxColumn();
            yeniProjeBtn = new Guna.UI2.WinForms.Guna2Button();
            yeniProjePnl = new Guna.UI2.WinForms.Guna2Panel();
            closeBtn = new Guna.UI2.WinForms.Guna2Button();
            projeEkleBtni = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            label5 = new Label();
            endDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            startDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            aciklama = new Guna.UI2.WinForms.Guna2TextBox();
            projeName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)projelerDataGrid).BeginInit();
            yeniProjePnl.SuspendLayout();
            SuspendLayout();
            // 
            // projelerDataGrid
            // 
            projelerDataGrid.AllowUserToAddRows = false;
            projelerDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            projelerDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            projelerDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            projelerDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            projelerDataGrid.ColumnHeadersHeight = 40;
            projelerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            projelerDataGrid.Columns.AddRange(new DataGridViewColumn[] { projeAdi, projeAciklama, baslangicTarih, bitistarih });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            projelerDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            projelerDataGrid.GridColor = Color.FromArgb(231, 229, 255);
            projelerDataGrid.Location = new Point(38, 91);
            projelerDataGrid.Name = "projelerDataGrid";
            projelerDataGrid.ReadOnly = true;
            projelerDataGrid.RowHeadersVisible = false;
            projelerDataGrid.RowHeadersWidth = 51;
            projelerDataGrid.Size = new Size(1569, 593);
            projelerDataGrid.TabIndex = 3;
            projelerDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            projelerDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            projelerDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            projelerDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            projelerDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            projelerDataGrid.ThemeStyle.BackColor = Color.White;
            projelerDataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            projelerDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            projelerDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            projelerDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            projelerDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            projelerDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            projelerDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            projelerDataGrid.ThemeStyle.ReadOnly = true;
            projelerDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            projelerDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            projelerDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            projelerDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            projelerDataGrid.ThemeStyle.RowsStyle.Height = 29;
            projelerDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            projelerDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            projelerDataGrid.CellDoubleClick += projelerDataGrid_CellDoubleClick;
            // 
            // projeAdi
            // 
            projeAdi.HeaderText = "Ad";
            projeAdi.MinimumWidth = 6;
            projeAdi.Name = "projeAdi";
            projeAdi.ReadOnly = true;
            // 
            // projeAciklama
            // 
            projeAciklama.HeaderText = "Açıklama";
            projeAciklama.MinimumWidth = 6;
            projeAciklama.Name = "projeAciklama";
            projeAciklama.ReadOnly = true;
            // 
            // baslangicTarih
            // 
            baslangicTarih.HeaderText = "Başlangıç Tarihi";
            baslangicTarih.MinimumWidth = 6;
            baslangicTarih.Name = "baslangicTarih";
            baslangicTarih.ReadOnly = true;
            // 
            // bitistarih
            // 
            bitistarih.HeaderText = "Bitiş Tarihi";
            bitistarih.MinimumWidth = 6;
            bitistarih.Name = "bitistarih";
            bitistarih.ReadOnly = true;
            // 
            // yeniProjeBtn
            // 
            yeniProjeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yeniProjeBtn.BorderRadius = 10;
            yeniProjeBtn.BorderThickness = 1;
            yeniProjeBtn.CustomizableEdges = customizableEdges1;
            yeniProjeBtn.DisabledState.BorderColor = Color.DarkGray;
            yeniProjeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            yeniProjeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            yeniProjeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            yeniProjeBtn.FillColor = SystemColors.GradientActiveCaption;
            yeniProjeBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yeniProjeBtn.ForeColor = Color.White;
            yeniProjeBtn.Location = new Point(1423, 32);
            yeniProjeBtn.Name = "yeniProjeBtn";
            yeniProjeBtn.PressedColor = SystemColors.GradientInactiveCaption;
            yeniProjeBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            yeniProjeBtn.Size = new Size(184, 39);
            yeniProjeBtn.TabIndex = 4;
            yeniProjeBtn.Text = "Yeni Proje";
            yeniProjeBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            yeniProjeBtn.Click += yeniProjeBtn_Click;
            // 
            // yeniProjePnl
            // 
            yeniProjePnl.Anchor = AnchorStyles.Top;
            yeniProjePnl.BackColor = Color.GhostWhite;
            yeniProjePnl.BorderColor = Color.Black;
            yeniProjePnl.BorderRadius = 5;
            yeniProjePnl.BorderThickness = 1;
            yeniProjePnl.Controls.Add(closeBtn);
            yeniProjePnl.Controls.Add(projeEkleBtni);
            yeniProjePnl.Controls.Add(label6);
            yeniProjePnl.Controls.Add(label5);
            yeniProjePnl.Controls.Add(endDate);
            yeniProjePnl.Controls.Add(startDate);
            yeniProjePnl.Controls.Add(label4);
            yeniProjePnl.Controls.Add(label3);
            yeniProjePnl.Controls.Add(aciklama);
            yeniProjePnl.Controls.Add(projeName);
            yeniProjePnl.Controls.Add(label2);
            yeniProjePnl.CustomizableEdges = customizableEdges15;
            yeniProjePnl.Location = new Point(541, 0);
            yeniProjePnl.Name = "yeniProjePnl";
            yeniProjePnl.ShadowDecoration.CustomizableEdges = customizableEdges16;
            yeniProjePnl.Size = new Size(579, 850);
            yeniProjePnl.TabIndex = 8;
            yeniProjePnl.Visible = false;
            // 
            // closeBtn
            // 
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.CustomizableEdges = customizableEdges3;
            closeBtn.DisabledState.BorderColor = Color.DarkGray;
            closeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            closeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeBtn.FillColor = Color.GhostWhite;
            closeBtn.Font = new Font("Segoe UI", 9F);
            closeBtn.ForeColor = Color.GhostWhite;
            closeBtn.HoverState.FillColor = Color.GhostWhite;
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.ImageSize = new Size(50, 50);
            closeBtn.Location = new Point(516, 13);
            closeBtn.Name = "closeBtn";
            closeBtn.PressedColor = Color.GhostWhite;
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            closeBtn.Size = new Size(50, 50);
            closeBtn.TabIndex = 22;
            closeBtn.Click += closeBtn_Click;
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
            projeEkleBtni.Location = new Point(188, 730);
            projeEkleBtni.Name = "projeEkleBtni";
            projeEkleBtni.ShadowDecoration.CustomizableEdges = customizableEdges6;
            projeEkleBtni.Size = new Size(225, 56);
            projeEkleBtni.TabIndex = 21;
            projeEkleBtni.Text = "Ekle";
            projeEkleBtni.Click += projeEkleBtni_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(113, 562);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 20;
            label6.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(113, 452);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 19;
            label5.Text = "Başlangıç Tarihi";
            // 
            // endDate
            // 
            endDate.Checked = true;
            endDate.CustomizableEdges = customizableEdges7;
            endDate.FillColor = SystemColors.GradientActiveCaption;
            endDate.Font = new Font("Segoe UI", 9F);
            endDate.Format = DateTimePickerFormat.Long;
            endDate.Location = new Point(113, 593);
            endDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            endDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            endDate.Name = "endDate";
            endDate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            endDate.Size = new Size(250, 45);
            endDate.TabIndex = 18;
            endDate.Value = new DateTime(2024, 5, 23, 19, 52, 5, 568);
            // 
            // startDate
            // 
            startDate.Checked = true;
            startDate.CustomizableEdges = customizableEdges9;
            startDate.FillColor = SystemColors.GradientActiveCaption;
            startDate.Font = new Font("Segoe UI", 9F);
            startDate.Format = DateTimePickerFormat.Long;
            startDate.Location = new Point(113, 483);
            startDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            startDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            startDate.Size = new Size(250, 45);
            startDate.TabIndex = 17;
            startDate.Value = new DateTime(2024, 5, 23, 19, 52, 5, 568);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(113, 245);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 16;
            label4.Text = "Proje Açıklaması";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(113, 139);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 15;
            label3.Text = "Proje Adı";
            // 
            // aciklama
            // 
            aciklama.Anchor = AnchorStyles.Left;
            aciklama.BorderColor = Color.Black;
            aciklama.BorderRadius = 9;
            aciklama.CustomizableEdges = customizableEdges11;
            aciklama.DefaultText = "";
            aciklama.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            aciklama.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            aciklama.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            aciklama.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            aciklama.FillColor = SystemColors.GradientInactiveCaption;
            aciklama.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            aciklama.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aciklama.ForeColor = Color.Black;
            aciklama.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            aciklama.Location = new Point(113, 277);
            aciklama.Margin = new Padding(3, 4, 3, 4);
            aciklama.Name = "aciklama";
            aciklama.PasswordChar = '\0';
            aciklama.PlaceholderForeColor = Color.Gray;
            aciklama.PlaceholderText = "";
            aciklama.RightToLeft = RightToLeft.No;
            aciklama.SelectedText = "";
            aciklama.ShadowDecoration.CustomizableEdges = customizableEdges12;
            aciklama.Size = new Size(406, 132);
            aciklama.TabIndex = 14;
            // 
            // projeName
            // 
            projeName.Anchor = AnchorStyles.Left;
            projeName.BorderColor = Color.Black;
            projeName.BorderRadius = 9;
            projeName.CustomizableEdges = customizableEdges13;
            projeName.DefaultText = "";
            projeName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            projeName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            projeName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            projeName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            projeName.FillColor = SystemColors.GradientInactiveCaption;
            projeName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            projeName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projeName.ForeColor = Color.Black;
            projeName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            projeName.Location = new Point(113, 171);
            projeName.Margin = new Padding(3, 4, 3, 4);
            projeName.Name = "projeName";
            projeName.PasswordChar = '\0';
            projeName.PlaceholderForeColor = Color.Gray;
            projeName.PlaceholderText = "";
            projeName.RightToLeft = RightToLeft.No;
            projeName.SelectedText = "";
            projeName.ShadowDecoration.CustomizableEdges = customizableEdges14;
            projeName.Size = new Size(406, 41);
            projeName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(188, 49);
            label2.Name = "label2";
            label2.Size = new Size(185, 39);
            label2.TabIndex = 0;
            label2.Text = "Proje Ekle";
            // 
            // projects_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(projelerDataGrid);
            Controls.Add(yeniProjePnl);
            Controls.Add(yeniProjeBtn);
            Name = "projects_";
            Size = new Size(1652, 937);
            ((System.ComponentModel.ISupportInitialize)projelerDataGrid).EndInit();
            yeniProjePnl.ResumeLayout(false);
            yeniProjePnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView projelerDataGrid;
        private Guna.UI2.WinForms.Guna2Button yeniProjeBtn;
        private Guna.UI2.WinForms.Guna2Panel yeniProjePnl;
        private Guna.UI2.WinForms.Guna2Button closeBtn;
        private Guna.UI2.WinForms.Guna2Button projeEkleBtni;
        private Label label6;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker endDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker startDate;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox aciklama;
        private Guna.UI2.WinForms.Guna2TextBox projeName;
        private Label label2;
        private DataGridViewTextBoxColumn projeAdi;
        private DataGridViewTextBoxColumn projeAciklama;
        private DataGridViewTextBoxColumn baslangicTarih;
        private DataGridViewTextBoxColumn bitistarih;
    }
}
