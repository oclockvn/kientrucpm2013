using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAn_QuanLyNhaSach_Official.wsHoaDonBanSachBLL;
using DoAn_QuanLyNhaSach_Official.wsKhachHangBLL;
using DoAn_QuanLyNhaSach_Official.wsChiTietHoaDonBLL;
using DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL;
using DoAn_QuanLyNhaSach_Official.wsSachBLL;

namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    public partial class frmHoaDonBanSach : Form
    {
        //DoAn_WebService_BLLSoapClient wsBLL = new DoAn_WebService_BLLSoapClient();
        wsHoaDonBanSachBLLSoapClient wsHoaDonBanSachBLL = new wsHoaDonBanSachBLLSoapClient();
        wsChiTietHoaDonBLLSoapClient wsChiTietHoaDonBLL = new wsChiTietHoaDonBLLSoapClient();
        wsTheLoaiSachBLLSoapClient wsTheLoaiSachBLL = new wsTheLoaiSachBLLSoapClient();
        wsSachBLLSoapClient wsSachBLL = new wsSachBLLSoapClient();
        wsKhachHangBLLSoapClient wsKhachHangBLL = new wsKhachHangBLLSoapClient();

        public frmHoaDonBanSach()
        {
            InitializeComponent();
            this.dgvListSach.AutoGenerateColumns = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reLoadDataChiTietHoaDon()
        {
            dgvListSach.DataSource = wsChiTietHoaDonBLL.getListChiTietHoaDon();
        }

        private KhachHangDTO getKhachHangInfo()
        {
            KhachHangDTO khCurr = new KhachHangDTO();
            khCurr.HoTen = txtHoTen.Text;
            khCurr.SoTienNo = 0;
            khCurr.Email = null;
            khCurr.DiaChi = null;
            khCurr.DienThoai = null;
            return khCurr;
        }        

        private bool isComplete()
        {
            if (txtHoTen.Text.Length != 0 && txtTenSach.Text.Length != 0 && txtDonGia.Text.Length != 0 && txtMaSach.Text.Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void completeText()
        {
            if (txtHoTen.Text.Length == 0)
            {
                MessageBox.Show("Nhập họ tên khách hàng", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
            }
            else if (txtTenSach.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên sách", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
            }
            else if (txtMaSach.Text.Length == 0)
            {
                MessageBox.Show("Nhập mã sách", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
            }
            else if (txtDonGia.Text.Length == 0)
            {
                MessageBox.Show("Nhập đơn giá sách", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGia.Focus();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật sau ^^!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmHoaDonBanSach_Load(object sender, EventArgs e)
        {
            cbxTheLoai.DataSource = wsTheLoaiSachBLL.getListTheLoaiSach();
            cbxTheLoai.DisplayMember = "TenTheLoai";
            cbxTheLoai.ValueMember = "MaTheLoai";
            changeControlState(false);
            btnThemSach.Enabled = false;
            btnXacNhan.Enabled = false;
            btnIn.Enabled = false;
        }

        private void changeControlState(bool state)
        {
            txtDonGia.Enabled = state;
            txtTenSach.Enabled = state;
            txtMaSach.Enabled = state;
            numSoLuong.Enabled = state;
            cbxTheLoai.Enabled = state;
        }

        private void txtMaSach_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSach.Text.Length != 0)
                {
                    cbxTheLoai.Text = wsTheLoaiSachBLL.getTenTheLoai(wsSachBLL.getMaTheLoaiSach(txtMaSach.Text));
                    txtDonGia.Text = (wsSachBLL.getDonGiaSach(txtTenSach.Text, txtMaSach.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại thông tin sách\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ChiTietHoaDonDTO getChiTietHoaDonInfo()
        {
            ChiTietHoaDonDTO chitietCurr = new ChiTietHoaDonDTO();
            chitietCurr.MaSach = txtMaSach.Text;
            chitietCurr.SoLuongBan = (int)numSoLuong.Value;
            chitietCurr.DonGia = int.Parse(txtDonGia.Text);
            return chitietCurr;
        }

        private HoaDonBanSachDTO getHoaDonBanSachInfo()
        {
            HoaDonBanSachDTO hoadonCurr = new HoaDonBanSachDTO();
            //int makhachhang = _khachhangBLL.getMaKhachHang(txtHoTen.Text);
            hoadonCurr.NgayLapHoaDon = dtpNgayLapHoaDon.Value.ToShortDateString();
            hoadonCurr.MaKhachHang = wsKhachHangBLL.getMaKhachHang(txtHoTen.Text);
            hoadonCurr.MaChiTietHoaDon = wsChiTietHoaDonBLL.getMaChiTietHoaDon(txtMaSach.Text);
            hoadonCurr.TongTien = wsChiTietHoaDonBLL.getTongTien(txtMaSach.Text);
            return hoadonCurr;
        }

        private HoaDonBanSachDTO newHoaDonBanSachInfo()
        {
            HoaDonBanSachDTO hoadonCurr = new HoaDonBanSachDTO();
            int makhachhang = wsKhachHangBLL.getMaKhachHang(txtHoTen.Text);
            hoadonCurr.NgayLapHoaDon = dtpNgayLapHoaDon.Value.ToShortDateString();
            hoadonCurr.MaKhachHang = makhachhang;
            hoadonCurr.MaChiTietHoaDon = 0;
            hoadonCurr.TongTien = wsChiTietHoaDonBLL.getTongTien(txtMaSach.Text);
            return hoadonCurr;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên khách hàng để tạo hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Xóa hóa đơn trước?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    try
                    {
                        //_hoadonbansachBLL.deleteAllTableHoaDonBanSach();
                        //_chitiethoadonBLL.deleteAllTableChiTietHoaDon();
                        wsHoaDonBanSachBLL.deleteAllTableHoaDonBanSach();
                        wsChiTietHoaDonBLL.deleteAllTableChiTietHoaDon();
                        changeControlState(true);
                        btnXacNhan.Enabled = true;
                        btnIn.Enabled = true;
                        btnThemSach.Enabled = true;
                        txtTenSach.Clear();
                        txtDonGia.Clear();
                        txtHoTen.Focus();
                        KhachHangDTO khachhangCurr = getKhachHangInfo();
                        wsKhachHangBLL.addNewKhachHang(khachhangCurr);
                        MessageBox.Show("Tạo hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        reLoadDataChiTietHoaDon();
                    }
                }
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (isComplete())
            {
                ChiTietHoaDonDTO chitietCurr = getChiTietHoaDonInfo();
                try
                {
                    if (wsChiTietHoaDonBLL.insertChiTietHoaDon(chitietCurr))
                    {
                        HoaDonBanSachDTO hoadonCurr = getHoaDonBanSachInfo();
                        wsHoaDonBanSachBLL.insertHoaDonBanSach(hoadonCurr);
                        MessageBox.Show("Chi tiết hóa đơn thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenSach.Clear();
                        txtDonGia.Clear();
                        txtMaSach.Clear();
                        //txtHoTen.Focus();
                        txtTenSach.Focus();
                        //numSoLuong.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thêm chi tiết hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    reLoadDataChiTietHoaDon();
                }
            }
            else
            {
                completeText();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int tongtien = wsHoaDonBanSachBLL.getTongTienHoaDonBanSach();

            string message = "Hóa đơn bán sách: \n";
            message += "Khách hàng: " + txtHoTen.Text + "\n";
            message += "Ngày lập hóa đơn: " + dtpNgayLapHoaDon.Value.ToShortDateString() + "\n";
            message += "Tổng tiền: " + tongtien;
            MessageBox.Show(message, "Thông tin hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
