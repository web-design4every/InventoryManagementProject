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
    public partial class QuanLyQuyKho : Form
    {
        QuanLyQuyKhoDAO db = new QuanLyQuyKhoDAO();
        DateTime dt = DateTime.Now;
        public QuanLyQuyKho()
        {
            InitializeComponent();
            loadQuyTien();
            loadPhieuThu();
            loadPhieuChi();
            Time();
        }
        public void loadQuyTien()
        {
            lblQuyKho.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", db.GetQuyKho().quyTien) + " đồng";
        }
        public void Time()
        {
            lblTime.Text = dt.ToString("HH:mm dd/MM/yyyy");
        }
        public void loadPhieuThu()
        {
            grdPhieuThu.DataSource = db.GetDataPhieuThu();
        }
        public void loadPhieuChi()
        {
            grdPhieuChi.DataSource = db.GetDataPhieuChi();
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

        private void btnTaoPT_Click(object sender, EventArgs e)
        {
            QuanLyPhieuThu qlpt = new QuanLyPhieuThu(1,"");
            qlpt.ShowDialog();
            loadQuyTien();
            loadPhieuThu();
            loadPhieuChi();
        }

        private void btnTaoPC_Click(object sender, EventArgs e)
        {
            QuanLyPhieuChi qlpc = new QuanLyPhieuChi(1,"");
            qlpc.ShowDialog();
            loadQuyTien();
            loadPhieuThu();
            loadPhieuChi();
        }

        private void grdPhieuThu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            QuanLyPhieuThu qlpt = new QuanLyPhieuThu(0, grdPhieuThu.Rows[grdPhieuThu.SelectedRows[0].Index].Cells[0].Value.ToString());
            qlpt.ShowDialog();
            loadQuyTien();
            loadPhieuThu();
            loadPhieuChi();
        }

        private void grdPhieuChi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            QuanLyPhieuChi qlpc = new QuanLyPhieuChi(0, grdPhieuChi.Rows[grdPhieuChi.SelectedRows[0].Index].Cells[0].Value.ToString());
            qlpc.ShowDialog();
            loadQuyTien();
            loadPhieuThu();
            loadPhieuChi();
        }
    }
}
