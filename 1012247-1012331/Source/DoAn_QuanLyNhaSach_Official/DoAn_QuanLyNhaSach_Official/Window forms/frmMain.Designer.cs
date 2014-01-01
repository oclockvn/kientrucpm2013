namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieuNhapSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonBanSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieuThuTienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapBaoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoNoCongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoTonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuongTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.nhapSachToolStripMenuItem,
            this.banSachToolStripMenuItem,
            this.lapBaoCaoToolStripMenuItem,
            this.traCuuToolStripMenuItem,
            this.thongTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhapToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.settings;
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.heThongToolStripMenuItem.Text = "&Hệ thống";
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.login;
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.dangNhapToolStripMenuItem.Text = "Đăng &nhập";
            this.dangNhapToolStripMenuItem.Click += new System.EventHandler(this.dangNhapToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.logout;
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.thoatToolStripMenuItem.Text = "&Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // nhapSachToolStripMenuItem
            // 
            this.nhapSachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phieuNhapSachToolStripMenuItem});
            this.nhapSachToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.add_file;
            this.nhapSachToolStripMenuItem.Name = "nhapSachToolStripMenuItem";
            this.nhapSachToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.nhapSachToolStripMenuItem.Text = "&Nhập sách";
            this.nhapSachToolStripMenuItem.ToolTipText = "Đăng nhập vào hệ thống để sử dụng chức năng này";
            // 
            // phieuNhapSachToolStripMenuItem
            // 
            this.phieuNhapSachToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.add_list;
            this.phieuNhapSachToolStripMenuItem.Name = "phieuNhapSachToolStripMenuItem";
            this.phieuNhapSachToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.phieuNhapSachToolStripMenuItem.Text = "&Phiếu nhập sách";
            this.phieuNhapSachToolStripMenuItem.Click += new System.EventHandler(this.phieuNhapSachToolStripMenuItem_Click);
            // 
            // banSachToolStripMenuItem
            // 
            this.banSachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoaDonBanSachToolStripMenuItem,
            this.phieuThuTienToolStripMenuItem});
            this.banSachToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.purchase_order;
            this.banSachToolStripMenuItem.Name = "banSachToolStripMenuItem";
            this.banSachToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.banSachToolStripMenuItem.Text = "&Bán sách";
            // 
            // hoaDonBanSachToolStripMenuItem
            // 
            this.hoaDonBanSachToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.document;
            this.hoaDonBanSachToolStripMenuItem.Name = "hoaDonBanSachToolStripMenuItem";
            this.hoaDonBanSachToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.hoaDonBanSachToolStripMenuItem.Text = "&Hóa đơn bán sách";
            this.hoaDonBanSachToolStripMenuItem.Click += new System.EventHandler(this.hoaDonBanSachToolStripMenuItem_Click);
            // 
            // phieuThuTienToolStripMenuItem
            // 
            this.phieuThuTienToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.wallet;
            this.phieuThuTienToolStripMenuItem.Name = "phieuThuTienToolStripMenuItem";
            this.phieuThuTienToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.phieuThuTienToolStripMenuItem.Text = "&Phiếu thu tiền";
            this.phieuThuTienToolStripMenuItem.Click += new System.EventHandler(this.phieuThuTienToolStripMenuItem_Click);
            // 
            // lapBaoCaoToolStripMenuItem
            // 
            this.lapBaoCaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoNoCongToolStripMenuItem,
            this.baoCaoTonToolStripMenuItem});
            this.lapBaoCaoToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.checkmark;
            this.lapBaoCaoToolStripMenuItem.Name = "lapBaoCaoToolStripMenuItem";
            this.lapBaoCaoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.lapBaoCaoToolStripMenuItem.Text = "&Lập báo cáo";
            // 
            // baoCaoNoCongToolStripMenuItem
            // 
            this.baoCaoNoCongToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.magazine;
            this.baoCaoNoCongToolStripMenuItem.Name = "baoCaoNoCongToolStripMenuItem";
            this.baoCaoNoCongToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.baoCaoNoCongToolStripMenuItem.Text = "Báo cáo nợ &công";
            this.baoCaoNoCongToolStripMenuItem.Click += new System.EventHandler(this.baoCaoNoCongToolStripMenuItem_Click);
            // 
            // baoCaoTonToolStripMenuItem
            // 
            this.baoCaoTonToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.book_stack;
            this.baoCaoTonToolStripMenuItem.Name = "baoCaoTonToolStripMenuItem";
            this.baoCaoTonToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.baoCaoTonToolStripMenuItem.Text = "Báo cáo &tồn";
            this.baoCaoTonToolStripMenuItem.Click += new System.EventHandler(this.baoCaoTonToolStripMenuItem_Click);
            // 
            // traCuuToolStripMenuItem
            // 
            this.traCuuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traCuuSachToolStripMenuItem});
            this.traCuuToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.search;
            this.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
            this.traCuuToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.traCuuToolStripMenuItem.Text = "&Tra cứu";
            // 
            // traCuuSachToolStripMenuItem
            // 
            this.traCuuSachToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.book;
            this.traCuuSachToolStripMenuItem.Name = "traCuuSachToolStripMenuItem";
            this.traCuuSachToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.traCuuSachToolStripMenuItem.Text = "Tr&a cứu sách";
            this.traCuuSachToolStripMenuItem.Click += new System.EventHandler(this.traCuuSachToolStripMenuItem_Click);
            // 
            // thongTinToolStripMenuItem
            // 
            this.thongTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chuongTrinhToolStripMenuItem});
            this.thongTinToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.help;
            this.thongTinToolStripMenuItem.Name = "thongTinToolStripMenuItem";
            this.thongTinToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.thongTinToolStripMenuItem.Text = "Thông t&in";
            // 
            // chuongTrinhToolStripMenuItem
            // 
            this.chuongTrinhToolStripMenuItem.Image = global::DoAn_QuanLyNhaSach_Official.Properties.Resources.info;
            this.chuongTrinhToolStripMenuItem.Name = "chuongTrinhToolStripMenuItem";
            this.chuongTrinhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chuongTrinhToolStripMenuItem.Text = "Chươn&g trình";
            this.chuongTrinhToolStripMenuItem.Click += new System.EventHandler(this.chuongTrinhToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieuNhapSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoaDonBanSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieuThuTienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lapBaoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoNoCongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoTonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuongTrinhToolStripMenuItem;
    }
}

