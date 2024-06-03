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
            projelerDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            projeAdi = new DataGridViewTextBoxColumn();
            projeAciklama = new DataGridViewTextBoxColumn();
            baslangicTarih = new DataGridViewTextBoxColumn();
            bitistarih = new DataGridViewTextBoxColumn();
            yeniProjeBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)projelerDataGrid).BeginInit();
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
            yeniProjeBtn.Location = new Point(1423, 31);
            yeniProjeBtn.Name = "yeniProjeBtn";
            yeniProjeBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            yeniProjeBtn.Size = new Size(184, 39);
            yeniProjeBtn.TabIndex = 4;
            yeniProjeBtn.Text = "Yeni Proje";
            // 
            // projects_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(yeniProjeBtn);
            Controls.Add(projelerDataGrid);
            Name = "projects_";
            Size = new Size(1652, 937);
            ((System.ComponentModel.ISupportInitialize)projelerDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView projelerDataGrid;
        private DataGridViewTextBoxColumn projeAdi;
        private DataGridViewTextBoxColumn projeAciklama;
        private DataGridViewTextBoxColumn baslangicTarih;
        private DataGridViewTextBoxColumn bitistarih;
        private Guna.UI2.WinForms.Guna2Button yeniProjeBtn;
    }
}
