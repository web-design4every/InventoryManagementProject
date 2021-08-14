using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1421_Project
{
    public partial class DangNhap : Form
    {
        DangNhapDAO db = new DangNhapDAO();
        public DangNhap()
        {
            InitializeComponent();
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.MaxLength = 14;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (TaiKhoan tk in db.getTaiKhoan())
            {
                if (tk.taiKhoan.TrimEnd().Equals(txtTaiKhoan.Text)&& tk.matKhau.TrimEnd().Equals(txtMatKhau.Text))
                {
                    check = true;
                }
            }
            if (check == true)
            {
                TrangChu trangChu = new TrangChu();
                trangChu.Show();
                this.Hide();
                return;
            }else
            MessageBox.Show("Tài Khoản và Mật Khẩu sai!");
        }

        private void cbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMK.Checked==true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
