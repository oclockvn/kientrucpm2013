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
    public partial class frmDangNhap : Form
    {
        public delegate void changeMenuStateHandler(bool state);
        public event changeMenuStateHandler changeMenuStateEventHandler = null;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            ckbHelp.Checked = false;
            changeCheckBox(false);
        }

        private void ckbHelp_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHelp.Checked)
            {
                changeCheckBox(true);
            }
            else
            {
                changeCheckBox(false);
            }
        }

        private void changeCheckBox(bool state)
        {
            lblTaiKhoan.Visible = state;
            lblMatkhau.Visible = state;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
            txtTaiKhoan.Clear();
            ckbAuto.Checked = false;
            ckbHelp.Checked = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (isComplete())
            {
                if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "1")
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (changeMenuStateEventHandler != null)
                    {
                        changeMenuStateEventHandler(true);
                    }
                    Close();   
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                completeText();
            }
        }

        private bool isComplete()
        {
            if (txtTaiKhoan.Text.Length != 0 && txtMatKhau.Text.Length != 0)
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
            if (txtTaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Nhập mật khẩu người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
            }
        }

        private void ckbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAuto.Checked)
            {
                txtTaiKhoan.Text = "admin";
                txtMatKhau.Text = "1";
            }
            else
            {
                txtMatKhau.Clear();
                txtTaiKhoan.Clear();
            }
        }
    }
}
