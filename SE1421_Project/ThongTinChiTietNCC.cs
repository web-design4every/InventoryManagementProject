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
    public partial class ThongTinChiTietNCC : Form
    {
        string maNo;
        QuanLyCongNoDAO dao = new QuanLyCongNoDAO();
        QuanLyQuyKhoDAO daodb = new QuanLyQuyKhoDAO();
        QuanLyNhaCungCapDAO db = new QuanLyNhaCungCapDAO();
        DateTime dt = DateTime.Now;
        public ThongTinChiTietNCC(string maNo)
        {
            InitializeComponent();
            this.maNo = maNo;
            loadThongTinNCC();
            loadTTNoNCC();
            btnTraNo.Enabled = false;
        }
        public void loadThongTinNCC()
        {
            txtMaNCC.Text = db.getNhaCungCapByMaNo(maNo).Ma.ToString();
            txtTenNCC.Text = db.getNhaCungCapByMaNo(maNo).Ten.ToString();
            txtDiaChi.Text = db.getNhaCungCapByMaNo(maNo).DiaChi.ToString();
            txtSDT.Text = db.getNhaCungCapByMaNo(maNo).SDT.ToString();
            loadTien();
        }
        public void loadTien()
        {
            if (dao.noNCCbyMaNo(maNo) < 0)
            {
                lblTienNo.Text = "Tiền Có";
                lblTraTien.Text = "Trả Nợ";
                btnTraNo.Text = "Trả Nợ";
                txtTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", (-dao.noNCCbyMaNo(maNo))) + " đồng";
            }
            else
            {
                lblTienNo.Text = "Tiền Nợ";
                lblTraTien.Text = "Thu Nợ";
                btnTraNo.Text = "Thu Nợ";
                txtTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", dao.noNCCbyMaNo(maNo)) + " đồng";
            }
        }
        public void loadTTNoNCC()
        {
            DataTable data = db.GetDataTTNoNCCbyMaNo(maNo);
            grdNoNCC.DataSource = data;
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
            if (float.Parse(txtTraNo.Text)<1000)
            {
                MessageBox.Show("Yêu cầu trả nợ trên 1000 đồng!!!");
            }
            else
            {
                float tienNo;
                if (dao.noNCCbyMaNo(maNo) < 0)
                {
                    tienNo = float.Parse(txtTraNo.Text) + dao.noNCCbyMaNo(maNo);
                    dao.UpdateTienNoNCC(maNo, txtMaNCC.Text, tienNo);
                    daodb.CapNhatQuyKho(-float.Parse(txtTraNo.Text), dt);
                    daodb.insertPhieuChi(txtTenNCC.Text, "Nhà cung cấp", "Trả nợ nhà cung cấp mã "+txtMaNCC.Text, float.Parse(txtTraNo.Text), dt);
                    MessageBox.Show("Trả nợ thành công!!!");
                }
                else
                {
                    tienNo = dao.noNCCbyMaNo(maNo) - float.Parse(txtTraNo.Text);
                    dao.UpdateTienNoNCC(maNo, txtMaNCC.Text, tienNo);
                    daodb.CapNhatQuyKho(float.Parse(txtTraNo.Text), dt);
                    daodb.insertPhieuThu(txtTenNCC.Text, "Nhà cung cấp", "Thu nợ nhà cung cấp mã " + txtMaNCC.Text, float.Parse(txtTraNo.Text), dt);
                    MessageBox.Show("Thu nợ thành công!!!");
                }
                txtTraNo.Text = "";
                loadTien();
            }
        }
    }
}
