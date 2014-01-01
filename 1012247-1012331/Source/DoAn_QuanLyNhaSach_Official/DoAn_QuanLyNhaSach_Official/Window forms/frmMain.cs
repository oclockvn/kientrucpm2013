using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thoát chương trình", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void chuongTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Form[] _active = this.MdiChildren;
                bool _flag = false;
                for (int i = 0; i < MdiChildren.Length; i++)
                {
                    if (_active[i].Text == "Thông tin")
                    {
                        MessageBox.Show("Cửa sổ Thông tin đang được hiển thị!");
                        _flag = true;
                        break;
                    }
                }
                if (!_flag)
                {
                    frmThongTin _frmThongtin = new frmThongTin();
                    _frmThongtin.MdiParent = this;
                    _frmThongtin.WindowState = FormWindowState.Maximized;
                    _frmThongtin.Show();
                }
            }
            else
            {
                frmThongTin _frmThongtin = new frmThongTin();
                _frmThongtin.MdiParent = this;
                _frmThongtin.WindowState = FormWindowState.Maximized;
                _frmThongtin.Show();
            }
        }

        private void phieuNhapSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Form[] _active = this.MdiChildren;
                bool _flag = false;
                for (int i = 0; i < MdiChildren.Length; i++)
                {
                    if (_active[i].Text == "Phiếu nhập sách")
                    {
                        MessageBox.Show("Cửa sổ Phiếu nhập sách đang được hiển thị!");
                        _flag = true;
                        break;
                    }
                }
                if (!_flag)
                {
                    frmPhieuNhapSach _frmPhieuNhapSach = new frmPhieuNhapSach();
                    _frmPhieuNhapSach.MdiParent = this;
                    _frmPhieuNhapSach.WindowState = FormWindowState.Maximized;
                    _frmPhieuNhapSach.Show();
                }
            }
            else
            {
                frmPhieuNhapSach _frmPhieuNhapSach = new frmPhieuNhapSach();
                _frmPhieuNhapSach.MdiParent = this;
                _frmPhieuNhapSach.WindowState = FormWindowState.Maximized;
                _frmPhieuNhapSach.Show();
            }
        }

        private void traCuuSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Form[] _active = this.MdiChildren;
                bool _flag = false;
                for (int i = 0; i < MdiChildren.Length; i++)
                {
                    if (_active[i].Text == "Tra cứu sách")
                    {
                        MessageBox.Show("Cửa sổ Tra cứu sách đang được hiển thị!");
                        _flag = true;
                        break;
                    }
                }
                if (!_flag)
                {
                    frmTraCuuSach _frmTraCuuSach = new frmTraCuuSach();
                    _frmTraCuuSach.MdiParent = this;
                    _frmTraCuuSach.WindowState = FormWindowState.Maximized;
                    _frmTraCuuSach.Show();
                }
            }
            else
            {
                frmTraCuuSach _frmTraCuuSach = new frmTraCuuSach();
                _frmTraCuuSach.MdiParent = this;
                _frmTraCuuSach.WindowState = FormWindowState.Maximized;
                _frmTraCuuSach.Show();
            }
        }

        private void hoaDonBanSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Form[] _active = this.MdiChildren;
                bool _flag = false;
                for (int i = 0; i < MdiChildren.Length; i++)
                {
                    if (_active[i].Text == "Hóa đơn bán sách")
                    {
                        MessageBox.Show("Cửa sổ Hóa đơn bán sách đang được hiển thị!");
                        _flag = true;
                        break;
                    }
                }
                if (!_flag)
                {
                    frmHoaDonBanSach _frmHoaDonBanSach = new frmHoaDonBanSach();
                    _frmHoaDonBanSach.MdiParent = this;
                    _frmHoaDonBanSach.WindowState = FormWindowState.Maximized;
                    _frmHoaDonBanSach.Show();
                }
            }
            else
            {
                frmHoaDonBanSach _frmHoaDonBanSach = new frmHoaDonBanSach();
                _frmHoaDonBanSach.MdiParent = this;
                _frmHoaDonBanSach.WindowState = FormWindowState.Maximized;
                _frmHoaDonBanSach.Show();
            }
        }

        private void phieuThuTienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Form[] _active = this.MdiChildren;
                bool _flag = false;
                for (int i = 0; i < MdiChildren.Length; i++)
                {
                    if (_active[i].Text == "Phiếu thu tiền")
                    {
                        MessageBox.Show("Cửa sổ Phiếu thu tiền đang được hiển thị!");
                        _flag = true;
                        break;
                    }
                }
                if (!_flag)
                {
                    frmPhieuThuTien _frmPhieuThuTien = new frmPhieuThuTien();
                    _frmPhieuThuTien.MdiParent = this;
                    _frmPhieuThuTien.WindowState = FormWindowState.Maximized;
                    _frmPhieuThuTien.Show();
                }
            }
            else
            {
                frmPhieuThuTien _frmPhieuThuTien = new frmPhieuThuTien();
                _frmPhieuThuTien.MdiParent = this;
                _frmPhieuThuTien.WindowState = FormWindowState.Maximized;
                _frmPhieuThuTien.Show();
            }
        }

        private void baoCaoNoCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Form[] _active = this.MdiChildren;
                bool _flag = false;
                for (int i = 0; i < MdiChildren.Length; i++)
                {
                    if (_active[i].Text == "Báo cáo nợ công")
                    {
                        MessageBox.Show("Cửa sổ Báo cáo nợ công đang được hiển thị!");
                        _flag = true;
                        break;
                    }
                }
                if (!_flag)
                {
                    frmBaoCaoNoCong _frmBaoCaoNoCong = new frmBaoCaoNoCong();
                    _frmBaoCaoNoCong.MdiParent = this;
                    _frmBaoCaoNoCong.WindowState = FormWindowState.Maximized;
                    _frmBaoCaoNoCong.Show();
                }
            }
            else
            {
                frmBaoCaoNoCong _frmBaoCaoNoCong = new frmBaoCaoNoCong();
                _frmBaoCaoNoCong.MdiParent = this;
                _frmBaoCaoNoCong.WindowState = FormWindowState.Maximized;
                _frmBaoCaoNoCong.Show();
            }
        }

        private void baoCaoTonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Form[] _active = this.MdiChildren;
                bool _flag = false;
                for (int i = 0; i < MdiChildren.Length; i++)
                {
                    if (_active[i].Text == "Báo cáo tồn")
                    {
                        MessageBox.Show("Cửa sổ Báo cáo tồn đang được hiển thị!");
                        _flag = true;
                        break;
                    }
                }
                if (!_flag)
                {
                    frmBaoCaoTon _frmBaoCaoTon = new frmBaoCaoTon();
                    _frmBaoCaoTon.MdiParent = this;
                    _frmBaoCaoTon.WindowState = FormWindowState.Maximized;
                    _frmBaoCaoTon.Show();
                }
            }
            else
            {
                frmBaoCaoTon _frmBaoCaoTon = new frmBaoCaoTon();
                _frmBaoCaoTon.MdiParent = this;
                _frmBaoCaoTon.WindowState = FormWindowState.Maximized;
                _frmBaoCaoTon.Show();
            }
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Form[] _active = this.MdiChildren;
                bool _flag = false;
                for (int i = 0; i < MdiChildren.Length; i++)
                {
                    if (_active[i].Text == "Đăng nhập")
                    {
                        MessageBox.Show("Cửa sổ Đăng nhập đang được hiển thị!");
                        _flag = true;
                        break;
                    }
                }
                if (!_flag)
                {
                    frmDangNhap _frmDangNhap = new frmDangNhap();
                    _frmDangNhap.MdiParent = this;
                    _frmDangNhap.WindowState = FormWindowState.Maximized;
                    _frmDangNhap.Show();
                    _frmDangNhap.changeMenuStateEventHandler+=new frmDangNhap.changeMenuStateHandler(_frmDangNhap_changeMenuStateEventHandler);
                }
            }
            else
            {
                frmDangNhap _frmDangNhap = new frmDangNhap();
                _frmDangNhap.MdiParent = this;
                _frmDangNhap.WindowState = FormWindowState.Maximized;
                _frmDangNhap.Show();
                _frmDangNhap.changeMenuStateEventHandler += new frmDangNhap.changeMenuStateHandler(_frmDangNhap_changeMenuStateEventHandler);
            }
        }

        void _frmDangNhap_changeMenuStateEventHandler(bool state)
        {
            nhapSachToolStripMenuItem.Enabled = state;
            banSachToolStripMenuItem.Enabled = state;
            lapBaoCaoToolStripMenuItem.Enabled = state;
            dangNhapToolStripMenuItem.Enabled = !state;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            changeMenuState(false);
        }

        public void changeMenuState(bool state)
        {
            nhapSachToolStripMenuItem.Enabled = state;
            banSachToolStripMenuItem.Enabled = state;
            lapBaoCaoToolStripMenuItem.Enabled = state;
            dangNhapToolStripMenuItem.Enabled = !state;
        }

    
    }
}
