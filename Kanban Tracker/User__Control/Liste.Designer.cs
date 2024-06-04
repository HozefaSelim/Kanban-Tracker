namespace Kanban_Tracker.User_Control
{
    partial class Liste
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            ListeDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            epicID = new DataGridViewTextBoxColumn();
            epicAdi = new DataGridViewTextBoxColumn();
            epicDurumu = new DataGridViewTextBoxColumn();
            tarih = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ListeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(97, 39);
            label1.TabIndex = 0;
            label1.Text = "Liste";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ListeDataGrid
            // 
            ListeDataGrid.AllowUserToAddRows = false;
            ListeDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            ListeDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            ListeDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle6.Font = new Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            ListeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            ListeDataGrid.ColumnHeadersHeight = 40;
            ListeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListeDataGrid.Columns.AddRange(new DataGridViewColumn[] { epicID, epicAdi, epicDurumu, tarih });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            ListeDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            ListeDataGrid.GridColor = Color.FromArgb(231, 229, 255);
            ListeDataGrid.Location = new Point(22, 99);
            ListeDataGrid.Name = "ListeDataGrid";
            ListeDataGrid.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            ListeDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            ListeDataGrid.RowHeadersVisible = false;
            ListeDataGrid.RowHeadersWidth = 51;
            ListeDataGrid.Size = new Size(1034, 713);
            ListeDataGrid.TabIndex = 1;
            ListeDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ListeDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            ListeDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ListeDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ListeDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ListeDataGrid.ThemeStyle.BackColor = Color.White;
            ListeDataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ListeDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ListeDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ListeDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListeDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ListeDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListeDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            ListeDataGrid.ThemeStyle.ReadOnly = true;
            ListeDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            ListeDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListeDataGrid.ThemeStyle.RowsStyle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListeDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ListeDataGrid.ThemeStyle.RowsStyle.Height = 29;
            ListeDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ListeDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // epicID
            // 
            epicID.HeaderText = "ID";
            epicID.MinimumWidth = 6;
            epicID.Name = "epicID";
            epicID.ReadOnly = true;
            // 
            // epicAdi
            // 
            epicAdi.HeaderText = "Ad";
            epicAdi.MinimumWidth = 6;
            epicAdi.Name = "epicAdi";
            epicAdi.ReadOnly = true;
            // 
            // epicDurumu
            // 
            epicDurumu.HeaderText = "Durum";
            epicDurumu.MinimumWidth = 6;
            epicDurumu.Name = "epicDurumu";
            epicDurumu.ReadOnly = true;
            // 
            // tarih
            // 
            tarih.HeaderText = "Oluşturma Tarihi";
            tarih.MinimumWidth = 6;
            tarih.Name = "tarih";
            tarih.ReadOnly = true;
            // 
            // Liste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ListeDataGrid);
            Controls.Add(label1);
            Name = "Liste";
            Size = new Size(1082, 848);
            ((System.ComponentModel.ISupportInitialize)ListeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ListeDataGrid;
        private DataGridViewTextBoxColumn epicID;
        private DataGridViewTextBoxColumn epicAdi;
        private DataGridViewTextBoxColumn epicDurumu;
        private DataGridViewTextBoxColumn tarih;
    }
}
