using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAn_QuanLyNhaSach_Official.wsBaoCaoTonBLL;

namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    public partial class frmBaoCaoTon : Form
    {
        //DoAn_WebService_BLLSoapClient wsBLL = new DoAn_WebService_BLLSoapClient();
        wsBaoCaoTonBLLSoapClient wsBaoCaoTonBLL = new wsBaoCaoTonBLLSoapClient();

        public frmBaoCaoTon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (isComplete())
            {
                try
                {
                    BaoCaoTonDTO baocaoDTO = getBaoCaoTonInfo();
                    wsBaoCaoTonBLL.insertBaoCaoTon(baocaoDTO);
                    MessageBox.Show("Thêm báo cáo tồn thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sách không tồn tại trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult dialog = MessageBox.Show("Xác nhận xóa", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    try
                    {
                        BaoCaoTonDTO baocaoCurr = getBaoCaoTonInfo();
                        wsBaoCaoTonBLL.deleteBaoCaoTon(baocaoCurr);
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    BaoCaoTonDTO baocaoCurr = getBaoCaoTonInfo();
                    wsBaoCaoTonBLL.updateBaoCaoTon(baocaoCurr);
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            frmBaoCaoTonReport report = new frmBaoCaoTonReport();
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật sau", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            changeControlState(true);
            btnIn.Enabled = true;
            btnBaoCao.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            btnTiepNhan.Enabled = true;
            txtMaSach.Clear();
            txtPhatSinh.Clear();
            txtTonCuoi.Clear();
            txtTonDau.Clear();
            txtMaSach.Focus();

        }

        private void frmBaoCaoTon_Load(object sender, EventArgs e)
        {
            changeControlState(false);
            btnTiepNhan.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            btnIn.Enabled = false;
            //btnBaoCao.Enabled = false;
            reLoadData();
        }

        private bool isComplete()
        {
            if (txtMaSach.Text.Length != 0 && txtPhatSinh.Text.Length != 0 && txtTonCuoi.Text.Length != 0 && txtTonDau.Text.Length != 0)
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
            if (txtMaSach.Text.Length == 0)
            {
                MessageBox.Show("Nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
            }
            else if (txtTonDau.Text.Length == 0)
            {
                MessageBox.Show("Nhập số lượng tồn đầu tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTonDau.Focus();
            }
            else if (txtPhatSinh.Text.Length == 0)
            {
                MessageBox.Show("Nhập số lượng phát sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhatSinh.Focus();
            }
            else if (txtTonCuoi.Text.Length == 0)
            {
                MessageBox.Show("Nhập số lượng tồn cuối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTonCuoi.Focus();
            }
        }

        private void changeControlState(bool state)
        {
            txtMaSach.Enabled = state;
            txtPhatSinh.Enabled = state;
            txtTonCuoi.Enabled = state;
            txtTonDau.Enabled = state;
        }

        private void reLoadData()
        {
            dgvList.DataSource = wsBaoCaoTonBLL.getListBaoCaoTon();
        }

        private BaoCaoTonDTO getBaoCaoTonInfo()
        {
            BaoCaoTonDTO baocaoCurr = new BaoCaoTonDTO();
            baocaoCurr.MaSach = txtMaSach.Text;
            baocaoCurr.PhatSinh = int.Parse(txtPhatSinh.Text);
            baocaoCurr.Thang = dtpNgayLap.Value.ToShortDateString();
            baocaoCurr.TonCuoi = int.Parse(txtTonCuoi.Text);
            baocaoCurr.TonDau = int.Parse(txtTonDau.Text);
            return baocaoCurr;
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvList.Rows.Count > 0)
                {
                    changeControlState(true);
                    btnXoa.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnTiepNhan.Enabled = false;
                    btnIn.Enabled = true;
                    btnBaoCao.Enabled = true;
                    txtMaSach.Text = dgvList.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                    txtPhatSinh.Text = dgvList.Rows[e.RowIndex].Cells["PhatSinh"].Value.ToString();
                    txtTonCuoi.Text = dgvList.Rows[e.RowIndex].Cells["TonCuoi"].Value.ToString();
                    txtTonDau.Text = dgvList.Rows[e.RowIndex].Cells["TonDau"].Value.ToString();
                }
            }
            catch (Exception)
            {
                
                //throw;
            }
        }
    }
}
