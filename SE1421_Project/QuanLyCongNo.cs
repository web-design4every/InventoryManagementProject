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
    public partial class QuanLyCongNo : Form
    {
        QuanLyCongNoDAO db = new QuanLyCongNoDAO();
        public QuanLyCongNo()
        {
           InitializeComponent();
           loadNCC();
           loadKH();
           loadThongKeNo();
        }
        public void loadThongKeNo()
        {
            lblNoNcc.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", db.tinhTongNoNCC()) + " đồng";
            lblCoNcc.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", db.tinhTongCoNCC()) + " đồng";
            lblNoKH.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", db.tinhTongNoKH()) + " đồng";
            lblCoKH.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", db.tinhTongCoKH()) + " đồng";
            lblCoCK.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", db.tinhTongCoNCC() + db.tinhTongCoKH()) + " đồng";
            lblNoCK.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", db.tinhTongNoKH() + db.tinhTongNoNCC()) + " đồng";
        }
        public void loadNCC()
        {
            DataTable data = db.GetDataNoNCC();
            grdNoNCC.DataSource = data;
        }
        public void loadKH()
        {
            DataTable data = db.GetDataNoKH();
            grdNoKH.DataSource = data;
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
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

        private void txtTimKiemNCC_TextChanged(object sender, EventArgs e)
        {
            DataTable data = db.GetDataNoNCCbyTen(txtTimKiemNCC.Text);
            grdNoNCC.DataSource = data;
        }

        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {
            DataTable data = db.GetDataNoKHbyTen(txtTimKiemKH.Text);
            grdNoKH.DataSource = data;
        }

        public void ShowChiTietNCC()
        {
            int selectedRow = grdNoNCC.SelectedRows[0].Index;
            if (selectedRow != -1)
            {
                string maNo = grdNoNCC.Rows[selectedRow].Cells[0].Value.ToString();
                ThongTinChiTietNCC ttNCC = new ThongTinChiTietNCC(maNo);
                ttNCC.ShowDialog();
            }
            loadNCC();
            loadThongKeNo();
        }

        public void ShowChiTietKH()
        {
            int selectedRow = grdNoKH.SelectedRows[0].Index;
            if (selectedRow != -1)
            {
                string maNo = grdNoKH.Rows[selectedRow].Cells[0].Value.ToString();
                ThongTinChiTietKH ttKH = new ThongTinChiTietKH(maNo);
                ttKH.ShowDialog();
            }
            loadKH();
            loadThongKeNo();
        }

        private void btnChiTietNCC_Click(object sender, EventArgs e)
        {
            ShowChiTietNCC();
        }

        private void btnChiTietKH_Click(object sender, EventArgs e)
        {
            ShowChiTietKH();
        }

        private void grdNoNCC_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowChiTietNCC();
        }

        private void grdNoKH_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowChiTietKH();
        }
    }
}
