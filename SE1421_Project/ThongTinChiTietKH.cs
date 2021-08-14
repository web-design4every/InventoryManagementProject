using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1421_Project
{
    public partial class ThongTinChiTietKH : Form
    {
        string maNo;
        QuanLyCongNoDAO dao = new QuanLyCongNoDAO();
        QuanLyQuyKhoDAO daodb = new QuanLyQuyKhoDAO();
        QuanLyKhachHangDAO db = new QuanLyKhachHangDAO();
        DateTime dt = DateTime.Now;
        public ThongTinChiTietKH(string maNo)
        {
            InitializeComponent();
            this.maNo = maNo;
            loadThongTinKH();
            loadTTNoKH();
            btnTraNo.Enabled = false;
        }
        public void loadThongTinKH()
        {
            txtMaKH.Text = db.getKhachHangByMaNo(maNo).Ma.ToString();
            txtTenKH.Text = db.getKhachHangByMaNo(maNo).Ten.ToString();
            txtDiaChi.Text = db.getKhachHangByMaNo(maNo).DiaChi.ToString();
            txtSDT.Text = db.getKhachHangByMaNo(maNo).SDT.ToString();
            loadTien();
        }
        public void loadTien()
        {
            if (dao.noKHbyMaNo(maNo) < 0)
            {
                lblTienNo.Text = "Tiền Có";
                lblTraTien.Text = "Trả Nợ";
                btnTraNo.Text = "Trả Nợ";
                txtTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", (-dao.noKHbyMaNo(maNo))) + " đồng";
            }
            else
            {
                lblTienNo.Text = "Tiền Nợ";
                lblTraTien.Text = "Thu Nợ";
                btnTraNo.Text = "Thu Nợ";
                txtTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", dao.noKHbyMaNo(maNo)) + " đồng";
            }
        }
        public void loadTTNoKH()
        {
            DataTable data = db.GetDataTTNoKHbyMaNo(maNo);
            grdNoKH.DataSource = data;
        }
        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTraNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTraNo.Text.Equals(""))
            {
                btnTraNo.Enabled = false;
            }
            else
            {
                btnTraNo.Enabled = true;
            }
        }

        private void txtTraNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnTraNo_Click(object sender, EventArgs e)
        {
            if (float.Parse(txtTraNo.Text) < 1000)
            {
                MessageBox.Show("Yêu cầu trả nợ trên 1000 đồng!!!");
            }
            else
            {
                float tienNo;
                if (dao.noKHbyMaNo(maNo) < 0)
                {
                    tienNo = float.Parse(txtTraNo.Text) + dao.noKHbyMaNo(maNo);
                    dao.UpdateTienNoKhachHang(maNo, txtMaKH.Text, tienNo);
                    daodb.CapNhatQuyKho(-float.Parse(txtTraNo.Text), dt);
                    daodb.insertPhieuChi(txtTenKH.Text, "Khách hàng", "Trả nợ khách hàng mã " + txtMaKH.Text, float.Parse(txtTraNo.Text), dt);
                    MessageBox.Show("Trả nợ thành công!!!");
                }
                else
                {
                    tienNo = dao.noKHbyMaNo(maNo) - float.Parse(txtTraNo.Text);
                    dao.UpdateTienNoKhachHang(maNo, txtMaKH.Text, tienNo);
                    daodb.CapNhatQuyKho(float.Parse(txtTraNo.Text), dt);
                    daodb.insertPhieuThu(txtTenKH.Text, "Khách hàng", "Thu nợ khách hàng mã " + txtMaKH.Text, float.Parse(txtTraNo.Text), dt);
                    MessageBox.Show("Thu nợ thành công!!!");
                }
                txtTraNo.Text = "";
                loadTien();
            }
        }
    }
}
