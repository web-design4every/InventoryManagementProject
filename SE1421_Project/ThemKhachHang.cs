using DAL;
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
    public partial class ThemKhachHang : Form
    {
        QuanLyKhachHangDAO db = new QuanLyKhachHangDAO();
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tạo mới khách hàng không?", "Thông báo", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    string maKH = (int.Parse(db.getLastMaKH()) + 1).ToString("D2");
                    db.TaoMoiKhachHang(maKH,txtTenKH.Text,txtDiaChi.Text,txtSDT.Text);
                    string maSoNo = (int.Parse(db.getLastMaSoNo()) + 1).ToString("D2");
                    db.TaoSoNoKH(maSoNo,maKH,"0");
                    MessageBox.Show("Khách hàng được tạo mới thành công!\n"+"Mã số Khách Hàng: "+maKH);
                    break;
                default:
                    break;
            }
        }
    }
}
