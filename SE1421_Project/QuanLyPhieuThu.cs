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
    public partial class QuanLyPhieuThu : Form
    {
        QuanLyQuyKhoDAO dao = new QuanLyQuyKhoDAO();
        DateTime dt = DateTime.Now;
        private int id;
        private string ma;
        public QuanLyPhieuThu(int id, string ma)
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
                string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", dao.GetPhieuThu(ma).tien);
                txtNguoiNop.Text = dao.GetPhieuThu(ma).nguoiNop.ToString();
                txtDiaChi.Text = dao.GetPhieuThu(ma).diaChi.ToString();
                txtTien.Text = tien+" đồng";
                rtLyDo.Text = dao.GetPhieuThu(ma).lyDo.ToString();
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtNguoiNop.Text.Equals("")||txtDiaChi.Text.Equals("")||txtTien.Text.Equals("")||rtLyDo.Text.Equals(""))
            {
                MessageBox.Show("Cần nhập đủ thông tin để tạo phiếu thu");
            }
            else
            {
                dao.CapNhatQuyKho(float.Parse(txtTien.Text),dt);
                dao.insertPhieuThu(txtNguoiNop.Text,txtDiaChi.Text,rtLyDo.Text, float.Parse(txtTien.Text),dt);
                MessageBox.Show("Tạo Phiếu Thu thành công!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToPdf(@"D:\PhieuThu" + ma + ".pdf", "Phiếu Thu");
                MessageBox.Show("In phiếu thu thành công!");
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
            prgdate.Add(new Chunk("Ngày " + dao.GetPhieuThu(ma).ngay.ToString("dd") + " Tháng " + dao.GetPhieuThu(ma).ngay.ToString("MM") + " Năm " + dao.GetPhieuThu(ma).ngay.ToString("yyyy"), fntDate));
            prgdate.Add(new Chunk("\nSố :" + ma, fntDate));
            document.Add(prgdate);
            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Information
            Paragraph prgAuthor = new Paragraph();
            Font fntAuthor = new Font(Vn_Helvetica, 12, iTextSharp.text.Font.NORMAL);
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.Add(new Chunk("Họ tên người nộp tiền :" + txtNguoiNop.Text, fntAuthor));
            prgAuthor.Add(new Chunk("\nĐịa chỉ :" + txtDiaChi.Text, fntAuthor));
            prgAuthor.Add(new Chunk("\nLý do thu :" + rtLyDo.Text, fntAuthor));
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
