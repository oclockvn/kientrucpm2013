using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAn_QuanLyNhaSach_Official.wsSachBLL;
using DoAn_QuanLyNhaSach_Official.wsTheLoaiSachBLL;

namespace DoAn_QuanLyNhaSach_Official.Window_forms
{
    public partial class frmTraCuuSach : Form
    {
        //DoAn_WebService_BLLSoapClient wsLL = new DoAn_WebService_BLLSoapClient();
        wsTheLoaiSachBLLSoapClient wsTheLoaiSachBLL = new wsTheLoaiSachBLLSoapClient();
        wsSachBLLSoapClient wsSachBLL = new wsSachBLLSoapClient();
        string muc;

        public frmTraCuuSach()
        {
            InitializeComponent();
            this.dgvList.AutoGenerateColumns = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cbxTheLoaiSach.ResetText();
            rbtTenSach.Checked = true;
            dgvList.DataSource = null;
        }

        private void rbtTenSach_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTenSach.Checked)
            {
                txtTimKiem.Clear();
                txtTimKiem.Focus();
                dgvList.DataSource = null;
                muc = rbtTenSach.Text;
            }
        }

        private void rbtTacGia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTacGia.Checked)
            {
                txtTimKiem.Clear();
                txtTimKiem.Focus();
                dgvList.DataSource = null;
                muc = rbtTacGia.Text;
            }
        }

        private void rbtTheLoai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTheLoai.Checked)
            {
                txtTimKiem.Clear();
                //txtTimKiem.Focus();
                cbxTheLoaiSach.Enabled = true;
                cbxTheLoaiSach.ResetText();
                cbxTheLoaiSach.Focus();
                dgvList.DataSource = null;
                muc = rbtTheLoai.Text;
            }
            else
            {
                cbxTheLoaiSach.Enabled = false;
            }
        }

        //private void reLoadListBookData()
        //{
            //dgvList.DataSource = _sachBLL.getListSach();
        //}

        private void frmTraCuuSach_Load(object sender, EventArgs e)
        {
            cbxTheLoaiSach.DataSource = wsTheLoaiSachBLL.getListTheLoaiSach();
            cbxTheLoaiSach.DisplayMember = "TenTheLoai";
            cbxTheLoaiSach.ValueMember = "MaTheLoai";
            cbxTheLoaiSach.Enabled = false;
        }

        private void cbxTheLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTheLoaiSach.Text.Length != 0)
            {
                try
                {
                    SachDTO sachCurr = new SachDTO();
                    sachCurr.MaTheLoai = wsTheLoaiSachBLL.getMaTheLoai(cbxTheLoaiSach.Text);
                    dgvList.DataSource = wsSachBLL.searchSachByCatalog(sachCurr, muc);
                }
                catch
                { 
                    
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length != 0)
            {
                try
                {
                    SachDTO sachCurr = new SachDTO();
                    //sachCurr.MaSach = -1;
                    sachCurr.MaTheLoai = -1;
                    if (rbtTenSach.Checked)
                    {                        
                        sachCurr.TenSach = txtTimKiem.Text;
                        dgvList.DataSource = wsSachBLL.searchSach(sachCurr);
                    }
                    else if (rbtTacGia.Checked)
                    {
                        sachCurr.TacGia = txtTimKiem.Text;
                        dgvList.DataSource = wsSachBLL.searchSach(sachCurr);
                    }
                    else if (rbtTheLoai.Checked)
                    {
                        sachCurr.MaTheLoai = wsTheLoaiSachBLL.getMaTheLoai(cbxTheLoaiSach.Text);
                        sachCurr.TenSach = txtTimKiem.Text;
                        dgvList.DataSource = wsSachBLL.searchSach(sachCurr);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm thấy sách\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTimKiem.Focus();
            }
        }
    }
}
