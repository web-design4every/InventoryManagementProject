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
    public partial class QuanLyPhieuNX : Form
    {
        PhieuNhapXuatDAO dao = new PhieuNhapXuatDAO();
        public QuanLyPhieuNX()
        {
            InitializeComponent();
            loadPhieuNhap();
            loadPhieuXuat();
            loadTKPhieuNhap();
            loadTKPhieuXuat();
        }
        public void loadTKPhieuNhap()
        {
            cbxPN.Items.Add("Tất cả");
            cbxPN.Items.Add("Mã Nhập");
            cbxPN.Items.Add("Tên Nhà cung cấp");
            cbxPN.SelectedIndex = 0;
        }
        public void loadTKPhieuXuat()
        {
            cbxPX.Items.Add("Tất cả");
            cbxPX.Items.Add("Mã Xuất");
            cbxPX.Items.Add("Tên Khách Hàng");
            cbxPX.SelectedIndex = 0;
        }

        public void loadPhieuNhap()
        {
            grdPhieuNhap.DataSource = dao.GetDataPhieuNhap();
        }
        public void loadPhieuXuat()
        {
            grdPhieuXuat.DataSource = dao.GetDataPhieuXuat();
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

        private void cbxPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPN.SelectedIndex == 0)
            {
                loadPhieuNhap();
                txtTimKiemPN.Text = "";
                txtTimKiemPN.ReadOnly = true;
            }
            else
            {
                txtTimKiemPN.ReadOnly = false;
            }
        }

        private void cbxPX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPX.SelectedIndex == 0)
            {
                loadPhieuXuat();
                txtTimKiemPX.Text = "";
                txtTimKiemPX.ReadOnly = true;
            }
            else
            {
                txtTimKiemPX.ReadOnly = false;
            }
        }

        private void txtTimKiemPN_TextChanged(object sender, EventArgs e)
        {
            if (cbxPN.SelectedIndex == 1)
            {
                grdPhieuNhap.DataSource = dao.GetDataPhieuNhapBy(1,txtTimKiemPN.Text);
            }
            else if (cbxPN.SelectedIndex == 2)
            {
                grdPhieuNhap.DataSource = dao.GetDataPhieuNhapBy(2, txtTimKiemPN.Text);
            }
        }

        private void txtTimKiemPX_TextChanged(object sender, EventArgs e)
        {
            if (cbxPX.SelectedIndex == 1)
            {
                grdPhieuXuat.DataSource = dao.GetDataPhieuXuatBy(1, txtTimKiemPX.Text);
            }
            else if (cbxPX.SelectedIndex == 2)
            {
                grdPhieuXuat.DataSource = dao.GetDataPhieuXuatBy(2, txtTimKiemPX.Text);
            }
        }

        private void grdPhieuNhap_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showChiTietPN();
        }

        private void grdPhieuXuat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showChiTietPX();
        }

        private void btnChiTietPN_Click(object sender, EventArgs e)
        {
            showChiTietPN();
        }

        private void btnChiTietPX_Click(object sender, EventArgs e)
        {
            showChiTietPX();
        }
        public void showChiTietPN()
        {
            int selectedRow = grdPhieuNhap.SelectedRows[0].Index;
            if (selectedRow != -1)
            {
                string maNhap = grdPhieuNhap.Rows[selectedRow].Cells[0].Value.ToString();
                string tenNCC = grdPhieuNhap.Rows[selectedRow].Cells[1].Value.ToString();
                string tongTien = grdPhieuNhap.Rows[selectedRow].Cells[2].Value.ToString();
                string ngayTao = grdPhieuNhap.Rows[selectedRow].Cells[3].Value.ToString();
                ThongTinChiTietPhieuNhap ttPN = new ThongTinChiTietPhieuNhap(maNhap,tenNCC,tongTien,ngayTao);
                ttPN.ShowDialog();
            }
        }
        public void showChiTietPX()
        {
            int selectedRow = grdPhieuXuat.SelectedRows[0].Index;
            if (selectedRow != -1)
            {
                string maXuat = grdPhieuXuat.Rows[selectedRow].Cells[0].Value.ToString();
                string tenKH = grdPhieuXuat.Rows[selectedRow].Cells[1].Value.ToString();
                string tongTien = grdPhieuXuat.Rows[selectedRow].Cells[2].Value.ToString();
                string ngayTao = grdPhieuXuat.Rows[selectedRow].Cells[3].Value.ToString();
                ThongTinChiTietPhieuXuat ttPX = new ThongTinChiTietPhieuXuat(maXuat, tenKH, tongTien, ngayTao);
                ttPX.ShowDialog();
            }
        }
    }
}
