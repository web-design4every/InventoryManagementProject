using DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1421_Project
{
    public partial class QuanLyPhieuChi : Form
    {
        QuanLyQuyKhoDAO dao = new QuanLyQuyKhoDAO();
        DateTime dt = DateTime.Now;
        private int id;
        private string ma;
        public QuanLyPhieuChi(int id, string ma)
        {
            InitializeComponent();
            this.id = id;
            this.ma = ma;
            if (id == 0)
            {
                btnTao.Enabled = false;
                btnIn.Enabled = true;
            }
            else if (id == 1)
            {
                btnTao.Enabled = true;
                btnIn.Enabled = false;
            }
            if (id == 0)
            {
                string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", dao.GetPhieuChi(ma).soTien);
                txtNguoiChi.Text = dao.GetPhieuChi(ma).nguoiNop.ToString();
                txtDiaChi.Text = dao.GetPhieuChi(ma).diaChi.ToString();
                txtTien.Text = tien + " đồng";
                rtLyDo.Text = dao.GetPhieuChi(ma).lyDo.ToString();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtNguoiChi.Text.Equals("") || txtDiaChi.Text.Equals("") || txtTien.Text.Equals("") || rtLyDo.Text.Equals(""))
            {
                MessageBox.Show("Cần nhập đủ thông tin để tạo phiếu chi");
            }
            else
            {
                dao.CapNhatQuyKho(-float.Parse(txtTien.Text), dt);
                dao.insertPhieuChi(txtNguoiChi.Text, txtDiaChi.Text, rtLyDo.Text, float.Parse(txtTien.Text), dt);
                MessageBox.Show("Tạo Phiếu Chi thành công!!!");
            }
        }

        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToPdf(@"D:\PhieuChi" + ma + ".pdf", "Phiếu Chi");
                MessageBox.Show("In phiếu chi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        void ExportToPdf(String strPdfPath, string strHeader)
        {
            iTextSharp.text.pdf.BaseFont Vn_Helvetica = iTextSharp.text.pdf.BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", "Identity-H", iTextSharp.text.pdf.BaseFont.EMBEDDED);
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            Font fntHead = new Font(Vn_Helvetica, 20, 1, Color.BLACK);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Date and infor
            Paragraph prgdate = new Paragraph();
            Font fntDate = new Font(Vn_Helvetica, 10, iTextSharp.text.Font.NORMAL);
            prgdate.Alignment = Element.ALIGN_CENTER;
            prgdate.Add(new Chunk("Ngày " + dao.GetPhieuChi(ma).ngay.ToString("dd")+" Tháng "+ dao.GetPhieuChi(ma).ngay.ToString("MM")+" Năm "+ dao.GetPhieuChi(ma).ngay.ToString("yyyy"), fntDate));
            prgdate.Add(new Chunk("\nSố :" + ma, fntDate));
            document.Add(prgdate);
            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Information
            Paragraph prgAuthor = new Paragraph();
            Font fntAuthor = new Font(Vn_Helvetica, 12, iTextSharp.text.Font.NORMAL);
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.Add(new Chunk("Họ tên người nhận tiền :" + txtNguoiChi.Text, fntAuthor));
            prgAuthor.Add(new Chunk("\nĐịa chỉ :" + txtDiaChi.Text, fntAuthor));
            prgAuthor.Add(new Chunk("\nLý do chi :" + rtLyDo.Text, fntAuthor));
            prgAuthor.Add(new Chunk("\nSố tiền :" + txtTien.Text, fntAuthor));
            document.Add(prgAuthor);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
