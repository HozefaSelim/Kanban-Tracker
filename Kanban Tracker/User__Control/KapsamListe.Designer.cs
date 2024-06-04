﻿namespace Kanban_Tracker.User__Control
{
    partial class KapsamListe
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
            ListeDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            epicID = new DataGridViewTextBoxColumn();
            issueAdi = new DataGridViewTextBoxColumn();
            epicAdi = new DataGridViewTextBoxColumn();
            epicDurumu = new DataGridViewTextBoxColumn();
            tarih = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ListeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ListeDataGrid
            // 
            ListeDataGrid.AllowUserToAddRows = false;
            ListeDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            ListeDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListeDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListeDataGrid.ColumnHeadersHeight = 40;
            ListeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListeDataGrid.Columns.AddRange(new DataGridViewColumn[] { epicID, issueAdi, epicAdi, epicDurumu, tarih });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListeDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            ListeDataGrid.GridColor = Color.FromArgb(231, 229, 255);
            ListeDataGrid.Location = new Point(58, 110);
            ListeDataGrid.Name = "ListeDataGrid";
            ListeDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ListeDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ListeDataGrid.RowHeadersVisible = false;
            ListeDataGrid.RowHeadersWidth = 51;
            ListeDataGrid.Size = new Size(969, 660);
            ListeDataGrid.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(58, 41);
            label1.Name = "label1";
            label1.Size = new Size(102, 39);
            label1.TabIndex = 3;
            label1.Text = "Pano";
            // 
            // epicID
            // 
            epicID.HeaderText = "ID";
            epicID.MinimumWidth = 6;
            epicID.Name = "epicID";
            epicID.ReadOnly = true;
            // 
            // issueAdi
            // 
            issueAdi.HeaderText = "Ad";
            issueAdi.MinimumWidth = 6;
            issueAdi.Name = "issueAdi";
            issueAdi.ReadOnly = true;
            // 
            // epicAdi
            // 
            epicAdi.HeaderText = "Epic Adı";
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
            // KapsamListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(ListeDataGrid);
            Name = "KapsamListe";
            Size = new Size(1082, 848);
            ((System.ComponentModel.ISupportInitialize)ListeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView ListeDataGrid;
        private Label label1;
        private DataGridViewTextBoxColumn epicID;
        private DataGridViewTextBoxColumn issueAdi;
        private DataGridViewTextBoxColumn epicAdi;
        private DataGridViewTextBoxColumn epicDurumu;
        private DataGridViewTextBoxColumn tarih;
    }
}
