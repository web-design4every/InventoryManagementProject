using DAL;
using Entity;
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
    public partial class QuanLyXuatKho : Form
    {
        QuanLyXuatKhoDAO db = new QuanLyXuatKhoDAO();
        QuanLyNhapKhoDAO dbNhap = new QuanLyNhapKhoDAO();
        QuanLyQuyKhoDAO dao = new QuanLyQuyKhoDAO();
        List<string> listmaVL = new List<string>();
        public float tongtien = 0;
        public string maVL;
        bool nhapMoi = true;
        int count = 0;
        DateTime dt = DateTime.Now;
        public QuanLyXuatKho()
        {
            InitializeComponent();
            Time();
            DanhSachKhachHang();
            DanhSachVatLieu();
            txtSoLuong.Text = "0";
            DataTable data = new DataTable();
            grdXuatKho.DataSource = data;
        }
        public void Time()
        {
            lblTime.Text = dt.ToString("HH:mm dd/MM/yyyy");
        }

        public void kiemTraSoNo()
        {
            if (db.getSoNoKH(cbxKhachHang.SelectedValue.ToString()) > 0)
            {
                string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", db.getSoNoKH(cbxKhachHang.SelectedValue.ToString()));
                lblNo.Text = "*(Số tiền nợ của KH: " + tien + " đồng)";
            }
            else if (db.getSoNoKH(cbxKhachHang.SelectedValue.ToString()) < 0)
            {
                string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", -db.getSoNoKH(cbxKhachHang.SelectedValue.ToString()));
                lblNo.Text = "*(Số tiền thiếu KH: " + tien + " đồng)";
            }
            else
            {
                lblNo.Text = "*(Khách Hàng chưa có nợ)";
            }
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

        public void DanhSachKhachHang()
        {
            List<Object> items = new List<Object>();
            foreach (KhachHang kh in db.danhSachKhachHang())
            {
                cbxKhachHang.DisplayMember = "Text";
                cbxKhachHang.ValueMember = "Value";
                items.Add(new { Text = kh.Ten, Value = kh.Ma });
            }
            cbxKhachHang.DataSource = items;
        }

        public void DanhSachVatLieu()
        {
            List<Object> items = new List<Object>();
            foreach (VatLieu vl in db.listVatLieu())
            {
                cbxVatLieu.DisplayMember = "Text";
                cbxVatLieu.ValueMember = "Value";
                items.Add(new { Text = vl.TenVatLieu, Value = vl.MaSo });
            }
            cbxVatLieu.DataSource = items;
        }

        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            ThemKhachHang themKhach = new ThemKhachHang();
            themKhach.ShowDialog();
            DanhSachKhachHang();
            cbxKhachHang.SelectedValue = db.getLastMaKH();
            kiemTraSoNo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                grdXuatKho.DataSource = null;
                count++;
            }
            cbxKhachHang.Enabled = false;
            int tongSL = 0;
            foreach (DataGridViewRow row in this.grdXuatKho.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(cbxVatLieu.SelectedValue.ToString()))
                {
                    tongSL = int.Parse(row.Cells[2].Value.ToString())+int.Parse(txtSoLuong.Text);
                }
            }
            if ((int.Parse(txtSoLuong.Text) > db.getSLTonbyMaVL(cbxVatLieu.SelectedValue.ToString())) || tongSL > db.getSLTonbyMaVL(cbxVatLieu.SelectedValue.ToString()))
            {
                MessageBox.Show("Số lượng vật liệu xuất lớn hơn số lượng tồn\n" + "Số lượng tồn trong kho: " + db.getSLTonbyMaVL(cbxVatLieu.SelectedValue.ToString()) + " " + dbNhap.getTenDVT(maVL).Ten.ToString());
                return;
            }
            foreach (DataGridViewRow row in this.grdXuatKho.Rows)
            {
                for (int i = 0; i < listmaVL.Count; i++)
                {
                    if ((row.Cells[0].Value.ToString().Equals(listmaVL[i])) && cbxVatLieu.SelectedValue.ToString().Equals(row.Cells[0].Value.ToString()))
                    {
                        row.Cells[2].Value = decimal.Parse(row.Cells[2].Value.ToString()) +decimal.Parse(txtSoLuong.Text);
                        row.Cells[4].Value = (float.Parse(row.Cells[2].Value.ToString()) * float.Parse(row.Cells[3].Value.ToString())).ToString("0." + new string('#', 339));
                        nhapMoi = false;
                    }
                }
            }
            if (txtSoLuong.Text.Equals("") || int.Parse(txtSoLuong.Text) == 0)
            {
                MessageBox.Show("Nhập số lượng phải lớn hơn 0");
            }
            else if (txtGiaXuat.Text.Equals("")||float.Parse(txtGiaXuat.Text) <= 1000)
            {
                MessageBox.Show("Đơn giá xuất phải lớn hơn 1000 đồng");
            }
            else
            {
                if (nhapMoi == true)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(grdXuatKho);
                    newRow.Cells[0].Value = cbxVatLieu.SelectedValue.ToString();
                    newRow.Cells[1].Value = cbxVatLieu.Text;
                    newRow.Cells[2].Value = txtSoLuong.Text;
                    newRow.Cells[3].Value = txtGiaXuat.Text;
                    newRow.Cells[4].Value = (float.Parse(newRow.Cells[2].Value.ToString()) * float.Parse(newRow.Cells[3].Value.ToString())).ToString("0." + new string('#', 339));
                    grdXuatKho.Rows.Add(newRow);
                    listmaVL.Add(newRow.Cells[0].Value.ToString());
                    listmaVL = listmaVL.Distinct().ToList();
                }
            }
            nhapMoi = true;
            tongtien = 0;
            foreach (DataGridViewRow row in this.grdXuatKho.Rows)
            {
                tongtien += float.Parse((float.Parse(row.Cells[2].Value.ToString()) * float.Parse(row.Cells[3].Value.ToString())).ToString());
            }
            string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tongtien);
            lblTongTien.Text = tien + " đồng";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (grdXuatKho.SelectedRows.Count == 0)
                return;
            foreach (DataGridViewRow row in this.grdXuatKho.SelectedRows)
            {
                grdXuatKho.Rows.RemoveAt(row.Index);
                tongtien -= float.Parse((string)row.Cells[4].Value);
            }
            if (grdXuatKho.SelectedRows.Count != 0)
            {
                int selectedRow = grdXuatKho.SelectedRows[0].Index;
                if (selectedRow != -1)
                {
                    cbxVatLieu.Text = grdXuatKho.Rows[selectedRow].Cells[1].Value.ToString();
                    txtSoLuong.Text = grdXuatKho.Rows[selectedRow].Cells[2].Value.ToString();
                    txtGiaXuat.Text = grdXuatKho.Rows[selectedRow].Cells[3].Value.ToString();
                }
            }
            string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tongtien);
            lblTongTien.Text = tien + " đồng";
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (txtThanhToan.Text.Equals("")||float.Parse(txtThanhToan.Text)==0)
            {
                MessageBox.Show("Xin vui lòng nhập số tiền cần thanh toán!");
            }
            else if (grdXuatKho.Rows.Count <= 0)
            {
                MessageBox.Show("Xin vui lòng nhập vật liệu để thanh toán!");
            }
            else if (float.Parse(txtThanhToan.Text) <= 1000)
            {
                MessageBox.Show("Xin vui lòng nhập số tiền thanh toán trên 1000 đồng!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xuất vật liệu không?", "Thông báo", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        string maXuat = (int.Parse(db.getLastMaXuat()) + 1).ToString("D4");
                        db.TaoPhieuXuat(new PhieuXuat { MaXuat = maXuat, NgayTao = DateTime.Now });
                        if (grdXuatKho.SelectedRows.Count == 0)
                            return;
                        foreach (DataGridViewRow row in this.grdXuatKho.Rows)
                        {
                            string maKH = cbxKhachHang.SelectedValue.ToString();
                            db.TaoThongTinPhieuXuat(maXuat, (string)row.Cells[0].Value, maKH, int.Parse(row.Cells[2].Value.ToString()), float.Parse(row.Cells[3].Value.ToString()), float.Parse(row.Cells[4].Value.ToString()));
                        }
                        db.TaoThongTinNoKH(db.getMaSoNoKH(cbxKhachHang.SelectedValue.ToString()), maXuat, float.Parse(txtThanhToan.Text), tongtien-float.Parse(txtThanhToan.Text), dt);
                        kiemTraSoNo();
                        dao.CapNhatQuyKho(float.Parse(txtThanhToan.Text), dt);
                        dao.insertPhieuThu("Tùng Lâm", "Giám Đốc", "Xuất kho vật liệu mã số "+maXuat, float.Parse(txtThanhToan.Text), dt);
                        MessageBox.Show("Tạo phiếu xuất thành công!\n" + "Mã Hóa Đơn Xuất: " + maXuat);
                        cbxKhachHang.Enabled = true;
                        grdXuatKho.Rows.Clear();
                        lblTongTien.Text = "0 đồng";
                        txtGiaXuat.Text = db.getGiaXuat(cbxVatLieu.SelectedValue.ToString()).GiaXuat.ToString();
                        txtSoLuong.Text = "0";
                        txtThanhToan.Text = "";
                        break;
                    default:
                        break;
                }
            }
        }

        private void cbxVatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            maVL = cbxVatLieu.SelectedValue.ToString();
            lblDVT.Text = "*(Đơn vị tính : " + dbNhap.getTenDVT(maVL).Ten.ToString() + ")";
            txtGiaXuat.Text = db.getGiaXuat(cbxVatLieu.SelectedValue.ToString()).GiaXuat.ToString();
            txtSoLuong.Text = "0";
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGiaXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbxKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiemTraSoNo();
        }

        private void btnKHMoi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
