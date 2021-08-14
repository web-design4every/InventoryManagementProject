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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QuanLyNhapKho qlnk = new QuanLyNhapKho();
            qlnk.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            QuanLyTonKho qlton = new QuanLyTonKho();
            qlton.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QuanLyXuatKho qlxuat = new QuanLyXuatKho();
            qlxuat.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            QuanLyCongNo qlno = new QuanLyCongNo();
            qlno.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            QuanLyPhieuNX qlbg = new QuanLyPhieuNX();
            qlbg.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            QuanLyQuyKho qlqk = new QuanLyQuyKho();
            qlqk.Show();
            this.Hide();
        }
    }
}
