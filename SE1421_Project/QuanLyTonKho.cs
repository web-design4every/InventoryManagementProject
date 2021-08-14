using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SE1421_Project
{
    public partial class QuanLyTonKho : Form
    {
        Regex regexInt = new Regex("^\\d+$");
        QuanLyTonKhoDAO dao = new QuanLyTonKhoDAO();
        public QuanLyTonKho()
        {
            InitializeComponent();
            Time();
            loadVatLieu();
            tinhTongTien();
            loadTimKiem();
            setFirstSelected();
        }
        public void Time()
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:mm dd/MM/yyyy");
        }
        public void setFirstSelected()
        {
            txtMaVL.Text = grdTonKho.Rows[0].Cells[0].Value.ToString();
            txtTenVL.Text = grdTonKho.Rows[0].Cells[1].Value.ToString();
            txtNCC.Text = grdTonKho.Rows[0].Cells[2].Value.ToString();
            txtDVT.Text = grdTonKho.Rows[0].Cells[3].Value.ToString();
            txtSLTon.Text = grdTonKho.Rows[0].Cells[4].Value.ToString();
            txtGiaNhap.Text = grdTonKho.Rows[0].Cells[5].Value.ToString();
            txtGiaXuat.Text = grdTonKho.Rows[0].Cells[6].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn quay về trang chủ không?", "Thông báo", MessageBoxButtons.YesNo);
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
                    TrangChu trang = new TrangChu();
                    trang.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (regexInt.IsMatch(txtGiaNhap.Text) == false)
            {
                MessageBox.Show("Không nhập kí tự khác vào giá nhập");
            }
            else if (float.Parse(txtGiaNhap.Text) <= 0)
            {
                MessageBox.Show("Giá nhập phải lớn hơn 0");
            }
            else if (regexInt.IsMatch(txtGiaXuat.Text) == false)
            {
                MessageBox.Show("Không nhập kí tự khác vào giá xuất");
            }
            else if (float.Parse(txtGiaXuat.Text) <= 0)
            {
                MessageBox.Show("Giá xuất phải lớn hơn 0");
            }
            else if (float.Parse(txtGiaXuat.Text) <= float.Parse(txtGiaNhap.Text))
            {
                MessageBox.Show("Giá xuất phải lớn hơn giá nhập");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật giá vật liệu không?", "Thông báo", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        dao.UpdateVatLieu(float.Parse(txtGiaNhap.Text), float.Parse(txtGiaXuat.Text), txtMaVL.Text);
                        loadVatLieu();
                        tinhTongTien();
                        MessageBox.Show("Cập nhật giá vật liệu thành công!");
                        break;
                    default:
                        break;
                }
            }
        }

        public void loadVatLieu()
        {
            DataTable data = dao.GetDataToTable();
            grdTonKho.DataSource = data;
        }

        public void loadTimKiem()
        {
            cbxTimKiem.Items.Add("Tất cả");
            cbxTimKiem.Items.Add("Mã Vật Liệu");
            cbxTimKiem.Items.Add("Tên vật Liệu");
            cbxTimKiem.Items.Add("Tên Nhà cung cấp");
            cbxTimKiem.SelectedIndex = 0;
        }

        public void tinhTongTien()
        {
            float tong = 0;
            foreach (DataGridViewRow row in this.grdTonKho.Rows)
            {
                tong = dao.tinhTongNhapKho();
            }
            string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tong);
            lblTong.Text = tien+ " đồng";
        }

        private void grdTonKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdTonKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = grdTonKho.SelectedRows[0].Index;
            if (selectedRow != -1)
            {
                txtMaVL.Text = grdTonKho.Rows[selectedRow].Cells[0].Value.ToString();
                txtTenVL.Text = grdTonKho.Rows[selectedRow].Cells[1].Value.ToString();
                txtNCC.Text = grdTonKho.Rows[selectedRow].Cells[2].Value.ToString();
                txtDVT.Text = grdTonKho.Rows[selectedRow].Cells[3].Value.ToString();
                txtSLTon.Text = grdTonKho.Rows[selectedRow].Cells[4].Value.ToString();
                txtGiaNhap.Text = grdTonKho.Rows[selectedRow].Cells[5].Value.ToString();
                txtGiaXuat.Text = grdTonKho.Rows[selectedRow].Cells[6].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbxTimKiem.SelectedIndex == 1)
            {
                DataTable data = dao.GetDataToTableByMaVL(txtTimKiem.Text);
                grdTonKho.DataSource = data;
            }
            else if(cbxTimKiem.SelectedIndex == 2)
            {
                DataTable data = dao.GetDataToTableByTenVL(txtTimKiem.Text);
                grdTonKho.DataSource = data;
            }
            else if(cbxTimKiem.SelectedIndex == 3)
            {
                DataTable data = dao.GetDataToTableByNCC(txtTimKiem.Text);
                grdTonKho.DataSource = data;
            }
        }

        private void cbxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTimKiem.SelectedIndex == 0)
            {
                loadVatLieu();
                txtTimKiem.Text = "";
                txtTimKiem.ReadOnly = true;
            }
            else
            {
                txtTimKiem.ReadOnly = false;
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ThongTinChiTietTonKho ttcttk = new ThongTinChiTietTonKho(txtMaVL.Text,txtTenVL.Text,txtNCC.Text,txtDVT.Text,txtSLTon.Text);
            ttcttk.ShowDialog();
        }

        private void grdTonKho_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ThongTinChiTietTonKho ttcttk = new ThongTinChiTietTonKho(txtMaVL.Text, txtTenVL.Text, txtNCC.Text, txtDVT.Text, txtSLTon.Text);
            ttcttk.ShowDialog();
        }
    }
}
