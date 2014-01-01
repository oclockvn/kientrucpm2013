using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAn_QuanLyNhaSach_Official.wsBaoCaoNoCongBLL;
using DoAn_QuanLyNhaSach_Official.wsKhachHangBLL;

namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    public partial class frmBaoCaoNoCong : Form
    {
        //DoAn_WebService_BLLSoapClient wsBLL = new DoAn_WebService_BLLSoapClient();
        wsBaoCaoNoCongBLLSoapClient wsBaoCaoNoCongBLL = new wsBaoCaoNoCongBLLSoapClient();
        wsKhachHangBLLSoapClient wsKhachHangBLL = new wsKhachHangBLLSoapClient();

        public frmBaoCaoNoCong()
        {
            InitializeComponent();
            this.dgvList.AutoGenerateColumns = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isComplete())
            {
                try
                {
                    BaoCaoNoCongDTO baocaoCurr = getBaoCaoNoCongInfo();
                    wsBaoCaoNoCongBLL.insertBaoCaoNoCong(baocaoCurr);
                    MessageBox.Show("Thêm báo cáo nợ công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Khách hàng không tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult dialog = MessageBox.Show("Xác nhận xóa báo cáo nợ công", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    try
                    {
                        BaoCaoNoCongDTO baocaoCurr = getBaoCaoNoCongInfo();
                        wsBaoCaoNoCongBLL.deleteBaoCaoNoCong(baocaoCurr);
                        MessageBox.Show("Xóa báo cáo thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    BaoCaoNoCongDTO baocaoCurr = getBaoCaoNoCongInfo();
                    wsBaoCaoNoCongBLL.updateBaoCaoNoCong(baocaoCurr);
                    MessageBox.Show("Cập nhật báo cáo thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCaoNoCongReport report = new frmBaoCaoNoCongReport();
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật sau", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {            
            btnIn.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnBaoCao.Enabled = true;
            btnCapNhat.Enabled = false;
            changeControlState(true);
            txtKhachHang.Clear();
            txtPhatSinh.Clear();
            txtNoCuoi.Clear();
            txtNoDau.Clear();            
        }

        private void frmBaoCaoNoCong_Load(object sender, EventArgs e)
        {
            changeControlState(false);
            btnIn.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = false;
            //btnBaoCao.Enabled = false;
            reLoadData();
        }

        private void reLoadData()
        {
            dgvList.DataSource = wsBaoCaoNoCongBLL.getListBaoCaoNoCong();
        }

        BaoCaoNoCongDTO getBaoCaoNoCongInfo()
        {
            BaoCaoNoCongDTO baocaoCurr = new BaoCaoNoCongDTO();
            try
            {
                baocaoCurr.MaKhachHang = wsKhachHangBLL.getMaKhachHang(txtKhachHang.Text);
            }
            catch
            {
                MessageBox.Show("Khách hàng không tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baocaoCurr.MaKhachHang = 0;
            }
            finally
            {
                //baocaoCurr.MaKhachHang = 0;
            }
            baocaoCurr.Thang = dtpNgayLap.Value.ToShortDateString();
            baocaoCurr.NoCuoi = int.Parse(txtNoCuoi.Text);
            baocaoCurr.NoDau = int.Parse(txtNoDau.Text);
            baocaoCurr.PhatSinh = int.Parse(txtPhatSinh.Text);
            return baocaoCurr;
        }

        private void changeControlState(bool state)
        {
            txtKhachHang.Enabled = state;
            txtNoCuoi.Enabled = state;
            txtNoDau.Enabled = state;
            txtPhatSinh.Enabled = state;
        }

        private bool isComplete()
        {
            if (txtKhachHang.Text.Length != 0 && txtNoCuoi.Text.Length != 0 && txtNoDau.Text.Length != 0 && txtPhatSinh.Text.Length != 0)
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
            if (txtKhachHang.Text.Length == 0)
            {
                MessageBox.Show("Nhập họ tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhachHang.Focus();
            }
            else if (txtNoDau.Text.Length == 0)
            {
                MessageBox.Show("Nhập nợ đầu tháng của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNoDau.Focus();
            }
            else if (txtPhatSinh.Text.Length == 0)
            {
                MessageBox.Show("Nhập nợ phát sinh của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhatSinh.Focus();
            }
            else if (txtNoCuoi.Text.Length == 0)
            {
                MessageBox.Show("Nhập nợ cuối của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtNoDau_KeyPress(object sender, KeyPressEventArgs e)
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
                    btnIn.Enabled = true;
                    btnBaoCao.Enabled = true;
                    int makh = int.Parse(dgvList.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString());
                    txtKhachHang.Text = wsKhachHangBLL.getKhachHangInfo(makh).HoTen;
                    txtNoCuoi.Text = dgvList.Rows[e.RowIndex].Cells["NoCuoi"].Value.ToString();
                    txtNoDau.Text = dgvList.Rows[e.RowIndex].Cells["NoDau"].Value.ToString();
                    txtPhatSinh.Text = dgvList.Rows[e.RowIndex].Cells["PhatSinh"].Value.ToString();
                    //dtpNgayLap.Value = (DateTime)dgvList.Rows[e.RowIndex].Cells["Thang"].Value.ToString();
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
