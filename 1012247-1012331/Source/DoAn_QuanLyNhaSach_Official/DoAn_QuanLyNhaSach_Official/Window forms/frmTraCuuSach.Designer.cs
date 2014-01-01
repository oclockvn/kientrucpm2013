namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    partial class frmTraCuuSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTheLoaiSach = new System.Windows.Forms.ComboBox();
            this.rbtTheLoai = new System.Windows.Forms.RadioButton();
            this.rbtTacGia = new System.Windows.Forms.RadioButton();
            this.rbtTenSach = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTimMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxTheLoaiSach);
            this.groupBox1.Controls.Add(this.rbtTheLoai);
            this.groupBox1.Controls.Add(this.rbtTacGia);
            this.groupBox1.Controls.Add(this.rbtTenSach);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbxTheLoaiSach
            // 
            this.cbxTheLoaiSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTheLoaiSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxTheLoaiSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTheLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheLoaiSach.FormattingEnabled = true;
            this.cbxTheLoaiSach.Location = new System.Drawing.Point(396, 11);
            this.cbxTheLoaiSach.Name = "cbxTheLoaiSach";
            this.cbxTheLoaiSach.Size = new System.Drawing.Size(357, 21);
            this.cbxTheLoaiSach.TabIndex = 5;
            this.cbxTheLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cbxTheLoaiSach_SelectedIndexChanged);
            // 
            // rbtTheLoai
            // 
            this.rbtTheLoai.AutoSize = true;
            this.rbtTheLoai.Location = new System.Drawing.Point(327, 15);
            this.rbtTheLoai.Name = "rbtTheLoai";
            this.rbtTheLoai.Size = new System.Drawing.Size(63, 17);
            this.rbtTheLoai.TabIndex = 4;
            this.rbtTheLoai.Text = "Thể loại";
            this.rbtTheLoai.UseVisualStyleBackColor = true;
            this.rbtTheLoai.CheckedChanged += new System.EventHandler(this.rbtTheLoai_CheckedChanged);
            // 
            // rbtTacGia
            // 
            this.rbtTacGia.AutoSize = true;
            this.rbtTacGia.Location = new System.Drawing.Point(244, 15);
            this.rbtTacGia.Name = "rbtTacGia";
            this.rbtTacGia.Size = new System.Drawing.Size(61, 17);
            this.rbtTacGia.TabIndex = 3;
            this.rbtTacGia.Text = "Tác giả";
            this.rbtTacGia.UseVisualStyleBackColor = true;
            this.rbtTacGia.CheckedChanged += new System.EventHandler(this.rbtTacGia_CheckedChanged);
            // 
            // rbtTenSach
            // 
            this.rbtTenSach.AutoSize = true;
            this.rbtTenSach.Checked = true;
            this.rbtTenSach.Location = new System.Drawing.Point(157, 15);
            this.rbtTenSach.Name = "rbtTenSach";
            this.rbtTenSach.Size = new System.Drawing.Size(70, 17);
            this.rbtTenSach.TabIndex = 2;
            this.rbtTenSach.TabStop = true;
            this.rbtTenSach.Text = "Tên sách";
            this.rbtTenSach.UseVisualStyleBackColor = true;
            this.rbtTenSach.CheckedChanged += new System.EventHandler(this.rbtTenSach_CheckedChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(10, 37);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(743, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo mục";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Location = new System.Drawing.Point(13, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tìm kiếm";
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoLuongTon,
            this.DonGia,
            this.TacGia,
            this.MaTheLoai,
            this.TenSach,
            this.MaSach});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 16);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(753, 243);
            this.dgvList.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.search;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(109, 85);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(657, 35);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTimMoi
            // 
            this.btnTimMoi.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.monitor;
            this.btnTimMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimMoi.Location = new System.Drawing.Point(13, 85);
            this.btnTimMoi.Name = "btnTimMoi";
            this.btnTimMoi.Size = new System.Drawing.Size(90, 35);
            this.btnTimMoi.TabIndex = 2;
            this.btnTimMoi.Text = "Tìm &mới";
            this.btnTimMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimMoi.UseVisualStyleBackColor = true;
            this.btnTimMoi.Click += new System.EventHandler(this.btnTimMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.cancel;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(682, 394);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "Mã Thể Loại";
            this.MaTheLoai.Name = "MaTheLoai";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // frmTraCuuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnTimMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuuSach";
            this.Text = "Tra cứu sách";
            this.Load += new System.EventHandler(this.frmTraCuuSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTheLoaiSach;
        private System.Windows.Forms.RadioButton rbtTheLoai;
        private System.Windows.Forms.RadioButton rbtTacGia;
        private System.Windows.Forms.RadioButton rbtTenSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnTimMoi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
    }
}