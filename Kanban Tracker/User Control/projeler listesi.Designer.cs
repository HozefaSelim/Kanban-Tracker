namespace Kanban_Tracker.User_Control
{
    partial class projeler
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
            projelerDtaView = new Guna.UI2.WinForms.Guna2DataGridView();
            projeAdi = new DataGridViewTextBoxColumn();
            projeID = new DataGridViewTextBoxColumn();
            projeAnahtari = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            projeOlusturBtn = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)projelerDtaView).BeginInit();
            SuspendLayout();
            // 
            // projelerDtaView
            // 
            projelerDtaView.AllowUserToAddRows = false;
            projelerDtaView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            projelerDtaView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            projelerDtaView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            projelerDtaView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            projelerDtaView.ColumnHeadersHeight = 40;
            projelerDtaView.Columns.AddRange(new DataGridViewColumn[] { projeAdi, projeID, projeAnahtari, Column2 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            projelerDtaView.DefaultCellStyle = dataGridViewCellStyle3;
            projelerDtaView.GridColor = Color.DarkGray;
            projelerDtaView.Location = new Point(35, 109);
            projelerDtaView.MultiSelect = false;
            projelerDtaView.Name = "projelerDtaView";
            projelerDtaView.ReadOnly = true;
            projelerDtaView.RowHeadersVisible = false;
            projelerDtaView.RowHeadersWidth = 51;
            projelerDtaView.Size = new Size(1581, 404);
            projelerDtaView.TabIndex = 1;
            projelerDtaView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            projelerDtaView.ThemeStyle.AlternatingRowsStyle.Font = null;
            projelerDtaView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            projelerDtaView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            projelerDtaView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            projelerDtaView.ThemeStyle.BackColor = Color.White;
            projelerDtaView.ThemeStyle.GridColor = Color.DarkGray;
            projelerDtaView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            projelerDtaView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            projelerDtaView.ThemeStyle.HeaderStyle.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projelerDtaView.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            projelerDtaView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            projelerDtaView.ThemeStyle.HeaderStyle.Height = 40;
            projelerDtaView.ThemeStyle.ReadOnly = true;
            projelerDtaView.ThemeStyle.RowsStyle.BackColor = Color.White;
            projelerDtaView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            projelerDtaView.ThemeStyle.RowsStyle.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projelerDtaView.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            projelerDtaView.ThemeStyle.RowsStyle.Height = 29;
            projelerDtaView.ThemeStyle.RowsStyle.SelectionBackColor = Color.Black;
            projelerDtaView.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            projelerDtaView.CellContentClick += projelerDtaView_CellContentClick;
            projelerDtaView.CellDoubleClick += projelerDtaView_CellDoubleClick;
            // 
            // projeAdi
            // 
            projeAdi.HeaderText = "Ad";
            projeAdi.MinimumWidth = 6;
            projeAdi.Name = "projeAdi";
            projeAdi.ReadOnly = true;
            projeAdi.Resizable = DataGridViewTriState.True;
            projeAdi.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // projeID
            // 
            projeID.HeaderText = "Proje ID";
            projeID.MinimumWidth = 6;
            projeID.Name = "projeID";
            projeID.ReadOnly = true;
            projeID.Resizable = DataGridViewTriState.True;
            projeID.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // projeAnahtari
            // 
            projeAnahtari.HeaderText = "Anahtar";
            projeAnahtari.MinimumWidth = 6;
            projeAnahtari.Name = "projeAnahtari";
            projeAnahtari.ReadOnly = true;
            projeAnahtari.Resizable = DataGridViewTriState.True;
            projeAnahtari.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.HeaderText = "Başlangıç Tarihi";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // projeOlusturBtn
            // 
            projeOlusturBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            projeOlusturBtn.BorderRadius = 6;
            projeOlusturBtn.Cursor = Cursors.Hand;
            projeOlusturBtn.CustomizableEdges = customizableEdges1;
            projeOlusturBtn.DisabledState.BorderColor = Color.DarkGray;
            projeOlusturBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            projeOlusturBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            projeOlusturBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            projeOlusturBtn.FillColor = SystemColors.GradientActiveCaption;
            projeOlusturBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            projeOlusturBtn.ForeColor = Color.Black;
            projeOlusturBtn.Location = new Point(1449, 43);
            projeOlusturBtn.Name = "projeOlusturBtn";
            projeOlusturBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            projeOlusturBtn.Size = new Size(155, 39);
            projeOlusturBtn.TabIndex = 6;
            projeOlusturBtn.Text = "Proje Oluştur";
            projeOlusturBtn.Click += projeOlusturBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(35, 43);
            label1.Name = "label1";
            label1.Size = new Size(149, 39);
            label1.TabIndex = 7;
            label1.Text = "Projeler";
            // 
            // projeler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(projeOlusturBtn);
            Controls.Add(projelerDtaView);
            Name = "projeler";
            Size = new Size(1652, 937);
            ((System.ComponentModel.ISupportInitialize)projelerDtaView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView projelerDtaView;
        private DataGridViewTextBoxColumn projeAdi;
        private DataGridViewTextBoxColumn projeID;
        private DataGridViewTextBoxColumn projeAnahtari;
        private DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2Button projeOlusturBtn;
        private Label label1;
    }
}
