using System;
using System.Windows.Forms;
using DoAn_QuanLyNhaSach_Official.wsPhieuNhapSachBLL;
using DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL;
using DoAn_QuanLyNhaSach_Official.wsSachBLL;
using DoAn_QuanLyNhaSach_Official.wsThamSoBLL;
using DoAn_QuanLyNhaSach_Official.wsChiTietPhieuNhapSachBLL;

namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    public partial class frmPhieuNhapSach : Form
    {
        //DoAn_WebService_BLLSoapClient wsBLL = new DoAn_WebService_BLLSoapClient();
        wsPhieuNhapSachBLLSoapClient wsPhieuNhapSachBLL = new wsPhieuNhapSachBLLSoapClient();
        wsTheLoaiSachBLLSoapClient wsTheLoaiSachBLL = new wsTheLoaiSachBLLSoapClient();
        wsSachBLLSoapClient wsSachBLL = new wsSachBLLSoapClient();
        wsThamSoBLLSoapClient wsThamSoBLL = new wsThamSoBLLSoapClient();
        wsChiTietPhieuNhapSachBLLSoapClient wsChiTietPhieuNhapSachBLL = new wsChiTietPhieuNhapSachBLLSoapClient();

        public frmPhieuNhapSach()
        {
            InitializeComponent();
            this.dgvListBook.AutoGenerateColumns = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeTextBoxState(bool state)
        {
            txtDonGia.Enabled = state;
            txtMaSach.Enabled = state;
            txtTacGia.Enabled = state;
            txtTenSach.Enabled = state;
            numSoLuong.Enabled = state;
            cbxTheLoai.Enabled = state;
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            changeTextBoxState(true);
            btnTiepNhan.Enabled = true;
            btnCapNhat.Enabled = false;
            btnGoBo.Enabled = false;
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtMaSach.Clear();
            txtDonGia.Clear();
            //numSoLuong.ResetText();
            cbxTheLoai.ResetText();
            txtTenSach.Focus();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar!= (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool isCompletedText()
        {
            if (txtTenSach.Text.Length != 0 && txtTacGia.Text.Length != 0 && txtMaSach.Text.Length != 0 && txtDonGia.Text.Length != 0 && cbxTheLoai.Text.Length != 0)
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
            if (txtTenSach.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
            }
            else if (txtMaSach.Text.Length == 0)
            {
                MessageBox.Show("Nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
            }
            else if (txtTacGia.Text.Length == 0)
            {
                MessageBox.Show("Nhập tác giả sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTacGia.Focus();
            }
            else if (cbxTheLoai.Text.Length == 0)
            {
                MessageBox.Show("Chọn thể loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTheLoai.Focus();
            }
            else if (txtDonGia.Text.Length == 0)
            {
                MessageBox.Show("Nhập đơn giá sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGia.Focus();
            }
        }

        private void frmPhieuNhapSach_Load(object sender, EventArgs e)
        {
            reLoadListBookData();

            cbxTheLoai.DataSource = wsTheLoaiSachBLL.getListTheLoaiSach();
            cbxTheLoai.DisplayMember = "TenTheLoai";
            cbxTheLoai.ValueMember = "MaTheLoai";

            changeTextBoxState(false);
            btnTiepNhan.Enabled = false;
            btnGoBo.Enabled = false;
            btnCapNhat.Enabled = false;
            //dgvListBook.DataSource = _chitietphieunhapsachBLL.getListChiTietPhieuNhapSach();
        }

        private bool checkTotalRemain()
        {
            if (wsSachBLL.getSoLuongTon(txtTenSach.Text) < wsThamSoBLL.getSoLuongTonMax())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (isCompletedText())
            {
                SachDTO sachCurr = getSachInFo();
                ChiTietPhieuNhapSachDTO chitietCurr = getChiTietPhieuNhapSachInfo();
                
                try
                {
                    if (checkTotalRemain())
                    {
                        if (wsSachBLL.insertSach(sachCurr))
                        {
                            wsChiTietPhieuNhapSachBLL.insertChiTietPhieuNhapSach(chitietCurr);
                            PhieuNhapSachDTO phieuCurr = getPhieuNhapSachInfo();
                            wsPhieuNhapSachBLL.insertPhieuNhapSach(phieuCurr);
                            MessageBox.Show("Nhập sách mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nhập không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        int sachton = wsSachBLL.getSoLuongTon(txtTenSach.Text);
                        int tonmax = wsThamSoBLL.getSoLuongTonMax();
                        MessageBox.Show("Sách tồn quá giới hạn cho phép:\nTồn tối đa: " + tonmax + "\nSách tồn: " + sachton + " cuốn" , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
                finally
                {
                    reLoadListBookData();
                }
                //MessageBox.Show(chitietCurr.SoLuong.ToString());
            }
            else
            {
                completeText();
            }
        }

        private void reLoadListBookData()
        {
            dgvListBook.DataSource = wsSachBLL.getListSach();
        }

        private SachDTO getSachInFo()
        {
            SachDTO sachCurr = new SachDTO();
            sachCurr.MaSach = txtMaSach.Text;
            sachCurr.TenSach = txtTenSach.Text;
            sachCurr.TacGia = txtTacGia.Text;
            sachCurr.MaTheLoai = wsTheLoaiSachBLL.getMaTheLoai(cbxTheLoai.Text);
            sachCurr.DonGia = int.Parse(txtDonGia.Text);
            sachCurr.SoLuongTon = (int)numSoLuong.Value;
            return sachCurr;
        }

        private ChiTietPhieuNhapSachDTO getChiTietPhieuNhapSachInfo()
        {
            ChiTietPhieuNhapSachDTO chitietCurr = new ChiTietPhieuNhapSachDTO();
            chitietCurr.MaSach = txtMaSach.Text;
            chitietCurr.SoLuong = (int)numSoLuong.Value;
            return chitietCurr;
        }

        private PhieuNhapSachDTO getPhieuNhapSachInfo()
        {
            PhieuNhapSachDTO phieuCurr = new PhieuNhapSachDTO();
            phieuCurr.MaChiTietPhieuNhapSach = wsChiTietPhieuNhapSachBLL.getMaChiTietPhieuNhapSach(txtMaSach.Text);
            phieuCurr.NgayNhap = dtpNgayNhap.Value.ToShortDateString();
            phieuCurr.TongSoLuongNhap = (int)numSoLuong.Value;
            return phieuCurr;
        }

        private void dgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListBook.Rows.Count > 0)
            {
                //int sl = 0;
                btnCapNhat.Enabled = true;
                btnGoBo.Enabled = true;
                btnTiepNhan.Enabled = false;
                changeTextBoxState(true);
                txtMaSach.Enabled = false;
                try
                {
                    txtDonGia.Text = dgvListBook.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                    txtMaSach.Text = dgvListBook.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                    txtTacGia.Text = dgvListBook.Rows[e.RowIndex].Cells["TacGia"].Value.ToString();
                    txtTenSach.Text = dgvListBook.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();
                    cbxTheLoai.Text = wsTheLoaiSachBLL.getTenTheLoai((int)dgvListBook.Rows[e.RowIndex].Cells["MaTheLoai"].Value);
                    //sl = _chitietphieunhapsachBLL.getSoLuongSachNhap(dgvListBook.Rows[e.RowIndex].Cells["MaSach"].Value.ToString());
                    numSoLuong.Value = (decimal)wsChiTietPhieuNhapSachBLL.getSoLuongSachNhap(dgvListBook.Rows[e.RowIndex].Cells["MaSach"].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
        }

        private void btnGoBo_Click(object sender, EventArgs e)
        {
            if (isCompletedText())
            {
                DialogResult dialog = MessageBox.Show("Xác nhận xóa sách này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    SachDTO sachCurr = getSachInFo();
                    ChiTietPhieuNhapSachDTO chitietCurr = getChiTietPhieuNhapSachInfo();
                    PhieuNhapSachDTO phieuCurr = getPhieuNhapSachInfo();
                    try
                    {
                        if (wsPhieuNhapSachBLL.deletePhieuNhapSach(phieuCurr))
                        {
                            if (wsChiTietPhieuNhapSachBLL.deleteChiTietPhieuNhapSach(chitietCurr))
                            {
                                wsSachBLL.deleteSach(sachCurr);
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi xóa chi tiết phiếu nhập sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lỗi xóa phiếu nhập sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw;
                    }
                    finally
                    {
                        reLoadListBookData();
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
            if (isCompletedText())
            {
                SachDTO sachCurr = getSachInFo();
                ChiTietPhieuNhapSachDTO chitietCurr = getChiTietPhieuNhapSachInfo();
                PhieuNhapSachDTO phieuCurr = getPhieuNhapSachInfo();
                try
                {
                    if (wsSachBLL.updateSach(sachCurr))
                    {
                        try
                        {
                            wsChiTietPhieuNhapSachBLL.updateChiTietPhieuNhapSach(chitietCurr);
                            wsPhieuNhapSachBLL.updatePhieuNhapSach(phieuCurr);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Cập nhật thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
                finally
                {
                    reLoadListBookData();
                }
            }
            else
            {
                completeText();
            }
        }

        private void numSoLuong_Validated(object sender, EventArgs e)
        {
            try
            {
                if (wsThamSoBLL.getSoLuongNhapMin() > (int)numSoLuong.Value)
                {
                    MessageBox.Show(" Số lượng sách nhập tối thiểu " + wsThamSoBLL.getSoLuongNhapMin(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //numSoLuong.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numSoLuong.Focus();
                //throw;
            }
        }

    }
}
