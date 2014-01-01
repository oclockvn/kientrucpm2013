using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAn_QuanLyNhaSach_Official.wsPhieuThuTienBLL;
using DoAn_QuanLyNhaSach_Official.wsKhachHangBLL;

namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    public partial class frmPhieuThuTien : Form
    {
        //DoAn_WebService_BLLSoapClient wsBLL = new DoAn_WebService_BLLSoapClient();
        wsPhieuThuTienBLLSoapClient wsPhieuThuTienBLL = new wsPhieuThuTienBLLSoapClient();
        wsKhachHangBLLSoapClient wsKhachHangBLL = new wsKhachHangBLLSoapClient();

        public frmPhieuThuTien()
        {
            InitializeComponent();
            this.dgvList.AutoGenerateColumns = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            changeControlState(true);
            btnIn.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            txtHoTen.Focus();
            txtHoTen.Clear();
            txtTienNo.Clear();
            txtTienThu.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isComplete())
            {
                try
                {
                    KhachHangDTO khachhangCurr = getKhachHangInfo();
                    if (wsKhachHangBLL.insertKhachHang(khachhangCurr))
                    {
                        PhieuThuTienDTO phieuthuCurr = getPhieuThuTienInfo();
                        wsPhieuThuTienBLL.insertPhieuThuTien(phieuthuCurr);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
                finally
                {
                    reLoadData();
                }
            }
            else
            {
                completeText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (isComplete())
            {
                DialogResult dialog = MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    PhieuThuTienDTO phieuthuCurr = getPhieuThuTienInfo();
                    try
                    {
                        if (wsPhieuThuTienBLL.deletePhieuThuTien(phieuthuCurr))
                        {
                            MessageBox.Show("Xóa phiếu thu thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KhachHangDTO khachhangCurr = getKhachHangInfo();
                            wsKhachHangBLL.deleteKhachHang(khachhangCurr);
                        }
                        else
                        {
                            MessageBox.Show("Xóa phiếu thu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw;
                    }
                    finally
                    {
                        reLoadData();
                    }
                }
            }
            else
            {
                completeText();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (isComplete())
            {
                try
                {
                    KhachHangDTO khachhangCurr = getKhachHangInfo();
                    if (wsKhachHangBLL.updateKhachHang(khachhangCurr))
                    {
                        PhieuThuTienDTO phieuthuCurr = getPhieuThuTienInfo();
                        wsPhieuThuTienBLL.updatePhieuThuTien(phieuthuCurr);
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    reLoadData();
                }
            }
            else
            {
                completeText();
            }
        }

        private void frmPhieuThuTien_Load(object sender, EventArgs e)
        {
            changeControlState(false);
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            reLoadData();
        }

        private void reLoadData()
        {
            dgvList.DataSource = wsPhieuThuTienBLL.getListPhieuThuTien();
        }

        private void changeControlState(bool state)
        {
            txtTienThu.Enabled = state;
            txtTienNo.Enabled = state;
            txtHoTen.Enabled = state;
            txtEmail.Enabled = state;
            txtDienThoai.Enabled = state;
            txtDiaChi.Enabled = state;
        }

        private bool isComplete()
        {
            if (txtHoTen.Text.Length != 0 && txtDiaChi.Text.Length != 0 && txtDienThoai.Text.Length != 0 && txtEmail.Text.Length != 0 && txtTienNo.Text.Length != 0 && txtTienThu.Text.Length != 0)
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
                MessageBox.Show("Nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
            }
            else if (txtDiaChi.Text.Length == 0)
            {
                MessageBox.Show("Nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
            }
            else if (txtDienThoai.Text.Length == 0)
            {
                MessageBox.Show("Nhập điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
            }
            else if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Nhập email khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else if (txtTienNo.Text.Length == 0)
            {
                MessageBox.Show("Nhập tiền nợ của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTienNo.Focus();
            }
            else if (txtTienThu.Text.Length == 0)
            {
                MessageBox.Show("Nhập tiền thu khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTienThu.Focus();
            }
        }

        private KhachHangDTO getKhachHangInfo()
        {
            KhachHangDTO khachhangCurr = new KhachHangDTO();
            khachhangCurr.DiaChi = txtDiaChi.Text;
            khachhangCurr.DienThoai = txtDienThoai.Text;
            khachhangCurr.Email = txtEmail.Text;
            khachhangCurr.HoTen = txtHoTen.Text;
            khachhangCurr.SoTienNo = int.Parse(txtTienNo.Text);
            return khachhangCurr;
        }

        private PhieuThuTienDTO getPhieuThuTienInfo()
        {
            PhieuThuTienDTO phieuthuCurr = new PhieuThuTienDTO();
            phieuthuCurr.NgayThu = dtpNgayThu.Value.ToShortDateString();
            phieuthuCurr.MaKhachHang = wsKhachHangBLL.getMaKhachHang(txtHoTen.Text);
            phieuthuCurr.SoTienThu = int.Parse(txtTienThu.Text);
            return phieuthuCurr;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvList.Rows.Count > 0)
                {
                    changeControlState(true);
                    btnThem.Enabled = false;
                    btnXoa.Enabled = true;
                    btnCapNhat.Enabled = true;
                    int i = e.RowIndex;
                    int makh = (int)dgvList.Rows[i].Cells["MaKhachHang"].Value;
                    KhachHangDTO khCurr = wsKhachHangBLL.getKhachHangInfo(makh);
                    txtHoTen.Text = khCurr.HoTen;
                    txtTienNo.Text = khCurr.SoTienNo.ToString();
                    txtEmail.Text = khCurr.Email;
                    txtDienThoai.Text = khCurr.DienThoai;
                    txtDiaChi.Text = khCurr.DiaChi;
                    txtTienThu.Text = dgvList.Rows[i].Cells["SoTienThu"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
    }
}
