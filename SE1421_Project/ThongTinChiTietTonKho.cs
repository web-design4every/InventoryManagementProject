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
    public partial class ThongTinChiTietTonKho : Form
    {
        private string maVL;
        private string tenVL;
        private string tenNCC;
        private string dvt;
        private string sl;
        QuanLyTonKhoDAO dao = new QuanLyTonKhoDAO();
        public ThongTinChiTietTonKho(string maVL,string tenVL,string tenNCC,string dvt,string sl)
        {
            InitializeComponent();
            this.maVL = maVL;
            this.tenVL = tenVL;
            this.tenNCC = tenNCC;
            this.dvt = dvt;
            this.sl = sl;
            loadVatLieu();
        }
        public void loadVatLieu()
        {
            DataTable data = dao.GetDataChiTietVatLieu(maVL);
            grdVatLieu.DataSource = data;
            txtTenVL.Text = tenVL;
            txtDVT.Text = dvt;
            txtNCC.Text = tenNCC;
            txtMaVL.Text = maVL;
            lblTonKho.Text = sl+" "+dvt;
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
