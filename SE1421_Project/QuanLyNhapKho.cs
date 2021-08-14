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
    public partial class QuanLyNhapKho : Form
    {
        public string maVL;
        List<string> listmaVL = new List<string>();
        QuanLyNhapKhoDAO db = new QuanLyNhapKhoDAO();
        QuanLyQuyKhoDAO dao = new QuanLyQuyKhoDAO();
        public float tongtien=0;
        bool nhapMoi = true;
        DateTime dt = DateTime.Now;
        int count = 0;
        public QuanLyNhapKho()
        {
            InitializeComponent();
            Time();
            NhaCungCap();
            kiemTraSoNo();
            txtSoLuong.Text = "0";
            DataTable data = new DataTable();
            grdNhapKho.DataSource = data;
        }
        public void Time()
        {
            lblTime.Text = dt.ToString("HH:mm dd/MM/yyyy");
        }
        public void NhaCungCap()
        {
            List<Object> items = new List<Object>();
            foreach (NhaCungCap ncc in db.listSupplier())
            {
                cbxNCC.DisplayMember = "Text";
                cbxNCC.ValueMember = "Value";
                items.Add(new { Text = ncc.Ten , Value = ncc.Ma});
            }
            cbxNCC.DataSource = items;
        }

        public void kiemTraSoNo()
        {
            if (db.getSoNoNCC(cbxNCC.SelectedValue.ToString()) > 0)
            {
                string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", db.getSoNoNCC(cbxNCC.SelectedValue.ToString()));
                lblNo.Text = "*(Số tiền nợ của NCC: " + tien + " đồng)";
            }
            else if (db.getSoNoNCC(cbxNCC.SelectedValue.ToString()) < 0)
            {
                string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", -db.getSoNoNCC(cbxNCC.SelectedValue.ToString()));
                lblNo.Text = "*(Số tiền thiếu NCC: " + tien + " đồng)";
            }
        }

        private void cbxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Object> items = new List<Object>();
            foreach (VatLieu vl in db.listVatLieubyNCC(cbxNCC.SelectedValue.ToString()))
            {
                    cbxVatLieu.DisplayMember = "Text";
                    cbxVatLieu.ValueMember = "Value";
                    items.Add(new { Text = vl.TenVatLieu, Value = vl.MaSo });
             }
            cbxVatLieu.DataSource = items;
            kiemTraSoNo();
        }

        private void cbxVatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            maVL = cbxVatLieu.SelectedValue.ToString();
            lblDVT.Text = "*(Đơn vị tính : " + db.getTenDVT(maVL).Ten.ToString()+ ")";
            txtSoLuong.Text = "0";
            txtGiaNhap.Text = db.getGiaNhap(cbxVatLieu.SelectedValue.ToString()).GiaNhap.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (count==0)
            {
                grdNhapKho.DataSource = null;
                count++;
            }
            cbxNCC.Enabled = false;
            foreach (DataGridViewRow row in this.grdNhapKho.Rows)
            {
                for (int i = 0;i<listmaVL.Count;i++)
                {
                    if ((row.Cells[0].Value.ToString().Equals(listmaVL[i]))&&cbxVatLieu.SelectedValue.ToString().Equals(row.Cells[0].Value.ToString()))
                    {
                        row.Cells[3].Value = decimal.Parse(row.Cells[3].Value.ToString()) + decimal.Parse(txtSoLuong.Text);
                        row.Cells[5].Value = (float.Parse(row.Cells[3].Value.ToString()) * float.Parse(row.Cells[4].Value.ToString())).ToString("0." + new string('#', 339));
                        nhapMoi = false;
                    }
                }
            }
            if (txtSoLuong.Text.Equals("")|| float.Parse(txtSoLuong.Text) == 0)
            {
                MessageBox.Show("Nhập số lượng phải lớn hơn 0");
            }
            else if (txtGiaNhap.Text.Equals("")||float.Parse(txtGiaNhap.Text)<=1000)
            {
                MessageBox.Show("Đơn giá nhập phải lớn hơn 1000 đồng");
            }
            else
            {
                if (nhapMoi == true)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(grdNhapKho);
                    newRow.Cells[0].Value = cbxVatLieu.SelectedValue.ToString();
                    newRow.Cells[1].Value = cbxVatLieu.Text;
                    newRow.Cells[2].Value = cbxNCC.Text;
                    newRow.Cells[3].Value = txtSoLuong.Text;
                    newRow.Cells[4].Value = txtGiaNhap.Text;
                    newRow.Cells[5].Value = (float.Parse(newRow.Cells[3].Value.ToString()) * float.Parse(newRow.Cells[4].Value.ToString())).ToString("0." + new string('#', 339));
                    grdNhapKho.Rows.Add(newRow);
                    listmaVL.Add(newRow.Cells[0].Value.ToString());
                    listmaVL = listmaVL.Distinct().ToList();
                }
            }
            nhapMoi = true;
            tongtien = 0;
            foreach (DataGridViewRow row in this.grdNhapKho.Rows)
            {
                tongtien += float.Parse((float.Parse(row.Cells[3].Value.ToString()) * float.Parse(row.Cells[4].Value.ToString())).ToString());
            }
            string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tongtien);
            lblTongTien.Text = tien + " đồng";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (grdNhapKho.SelectedRows.Count == 0)
                return;
            foreach (DataGridViewRow row in this.grdNhapKho.SelectedRows)
            {
                grdNhapKho.Rows.RemoveAt(row.Index);
                tongtien -= float.Parse((string)row.Cells[5].Value);
            }
            if (grdNhapKho.SelectedRows.Count!=0)
            {
                int selectedRow = grdNhapKho.SelectedRows[0].Index;
                if (selectedRow != -1)
                {
                    cbxVatLieu.Text = grdNhapKho.Rows[selectedRow].Cells[1].Value.ToString();
                    txtSoLuong.Text = grdNhapKho.Rows[selectedRow].Cells[3].Value.ToString();
                    txtGiaNhap.Text = grdNhapKho.Rows[selectedRow].Cells[4].Value.ToString();
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
            else if (grdNhapKho.Rows.Count<=0)
            {
                MessageBox.Show("Xin vui lòng nhập vật liệu để thanh toán!");
            }
            else if (float.Parse(txtThanhToan.Text)<=1000)
            {
                MessageBox.Show("Xin vui lòng nhập số tiền thanh toán trên 1000 đồng!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn nhập vật liệu không?", "Thông báo", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        string maNhap = (int.Parse(db.getLastMaNhap()) + 1).ToString("D4");
                        db.TaoPhieuNhap(new PhieuNhap { Ma = maNhap, NgayTao = DateTime.Now });
                        if (grdNhapKho.SelectedRows.Count == 0)
                            return;
                        foreach (DataGridViewRow row in this.grdNhapKho.Rows)
                        {
                            string maNCC = db.getMaNCC((string)row.Cells[2].Value).Ma;
                            db.TaoThongTinPhieuNhap(maNhap, (string)row.Cells[0].Value, maNCC, int.Parse(row.Cells[3].Value.ToString()), float.Parse(row.Cells[4].Value.ToString()), float.Parse(row.Cells[5].Value.ToString()));
                        }
                        db.TaoThongTinNoNCC(db.getMaSoNoNCC(cbxNCC.SelectedValue.ToString()),maNhap,float.Parse(txtThanhToan.Text), float.Parse(txtThanhToan.Text)-tongtien,dt);
                        kiemTraSoNo();
                        dao.CapNhatQuyKho(-float.Parse(txtThanhToan.Text), dt);
                        dao.insertPhieuChi("Tùng Lâm", "Giám Đốc", "Nhập kho vật liệu mã số "+maNhap, float.Parse(txtThanhToan.Text), dt);
                        MessageBox.Show("Tạo phiếu nhập thành công!\n" + "Mã Hóa Đơn Nhập: " + maNhap);
                        cbxNCC.Enabled = true;
                        grdNhapKho.Rows.Clear();
                        lblTongTien.Text = "0 đồng";
                        txtGiaNhap.Text = db.getGiaNhap(cbxVatLieu.SelectedValue.ToString()).GiaNhap.ToString();
                        txtSoLuong.Text = "0";
                        txtThanhToan.Text = "";
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn quay về trang chủ không?","Thông báo", MessageBoxButtons.YesNo);
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

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void grdNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = grdNhapKho.SelectedRows[0].Index;
            if (selectedRow != -1)
            {
                cbxVatLieu.Text = grdNhapKho.Rows[selectedRow].Cells[1].Value.ToString();
                txtSoLuong.Text = grdNhapKho.Rows[selectedRow].Cells[3].Value.ToString();
                txtGiaNhap.Text = grdNhapKho.Rows[selectedRow].Cells[4].Value.ToString();
            }
        }
    }
}
