namespace Kanban_Tracker.User__Control
{
    partial class takimListesi
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            takimDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            kullaniciAdi = new DataGridViewTextBoxColumn();
            eposta = new DataGridViewTextBoxColumn();
            kullaniciRolu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)takimDataGrid).BeginInit();
            SuspendLayout();
            // 
            // takimDataGrid
            // 
            takimDataGrid.AllowUserToAddRows = false;
            takimDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            takimDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            takimDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            takimDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            takimDataGrid.ColumnHeadersHeight = 40;
            takimDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            takimDataGrid.Columns.AddRange(new DataGridViewColumn[] { kullaniciAdi, eposta, kullaniciRolu });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            takimDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            takimDataGrid.GridColor = Color.FromArgb(231, 229, 255);
            takimDataGrid.Location = new Point(58, 110);
            takimDataGrid.Name = "takimDataGrid";
            takimDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            takimDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            takimDataGrid.RowHeadersVisible = false;
            takimDataGrid.RowHeadersWidth = 51;
            takimDataGrid.Size = new Size(969, 660);
            takimDataGrid.TabIndex = 2;
            takimDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            takimDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            takimDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            takimDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            takimDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            takimDataGrid.ThemeStyle.BackColor = Color.White;
            takimDataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            takimDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            takimDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            takimDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            takimDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            takimDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            takimDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            takimDataGrid.ThemeStyle.ReadOnly = true;
            takimDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            takimDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            takimDataGrid.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            takimDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            takimDataGrid.ThemeStyle.RowsStyle.Height = 29;
            takimDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            takimDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(58, 41);
            label1.Name = "label1";
            label1.Size = new Size(110, 39);
            label1.TabIndex = 3;
            label1.Text = "Takım";
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.HeaderText = "Ad";
            kullaniciAdi.MinimumWidth = 6;
            kullaniciAdi.Name = "kullaniciAdi";
            kullaniciAdi.ReadOnly = true;
            // 
            // eposta
            // 
            eposta.HeaderText = "E-posta";
            eposta.MinimumWidth = 6;
            eposta.Name = "eposta";
            eposta.ReadOnly = true;
            // 
            // kullaniciRolu
            // 
            kullaniciRolu.HeaderText = "Rol";
            kullaniciRolu.MinimumWidth = 6;
            kullaniciRolu.Name = "kullaniciRolu";
            kullaniciRolu.ReadOnly = true;
            // 
            // takimListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(takimDataGrid);
            Name = "takimListesi";
            Size = new Size(1082, 848);
            ((System.ComponentModel.ISupportInitialize)takimDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public Guna.UI2.WinForms.Guna2DataGridView takimDataGrid;
        private DataGridViewTextBoxColumn kullaniciAdi;
        private DataGridViewTextBoxColumn eposta;
        private DataGridViewTextBoxColumn kullaniciRolu;
    }
}
