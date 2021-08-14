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
    public partial class ThongTinChiTietPhieuXuat : Form
    {
        private string maXuat;
        private string tenKH;
        private string tongTien;
        private string ngayTao;
        PhieuNhapXuatDAO dao = new PhieuNhapXuatDAO();
        public ThongTinChiTietPhieuXuat(string maXuat, string tenKH, string tongTien, string ngayTao)
        {
            InitializeComponent();
            this.maXuat = maXuat;
            this.tenKH = tenKH;
            this.tongTien = tongTien;
            this.ngayTao = ngayTao;
            loadThongTinPX();
            loadChiTietPX();
        }
        public void loadThongTinPX()
        {
            string tien = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(tongTien));
            txtMaPX.Text = maXuat;
            txtKH.Text = tenKH;
            txtTongTien.Text = tien + " đồng";
            txtNgayTao.Text = ngayTao;
        }
        public void loadChiTietPX()
        {
            grdChiTietPX.DataSource = dao.GetDataChiTietPNbyMaXuat(maXuat);
        }
        private void btnInPN_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtbl = dao.GetDataChiTietPNbyMaXuat(maXuat);
                ExportDataTableToPdf(dtbl, @"D:\PhieuXuat" + maXuat + ".pdf", "Phiếu Xuất Kho");
                //System.Diagnostics.Process.Start(@"D:\PhieuXuat" + maXuat + ".pdf");
                //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                MessageBox.Show("In phiếu xuất thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            iTextSharp.text.pdf.BaseFont Vn_Helvetica = iTextSharp.text.pdf.BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", "Identity-H", iTextSharp.text.pdf.BaseFont.EMBEDDED);
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            iTextSharp.text.Font fntHead = new Font(Vn_Helvetica, 20, 1, Color.BLACK);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Date and infor
            Paragraph prgdate = new Paragraph();
            Font fntDate = new Font(Vn_Helvetica, 10, iTextSharp.text.Font.NORMAL);
            prgdate.Alignment = Element.ALIGN_CENTER;
            prgdate.Add(new Chunk("Số : " + maXuat, fntDate));
            prgdate.Add(new Chunk("\nNgày " + Convert.ToDateTime(ngayTao).ToString("dd") + " Tháng " + Convert.ToDateTime(ngayTao).ToString("MM") + " Năm " + Convert.ToDateTime(ngayTao).ToString("yyyy"), fntDate));
            document.Add(prgdate);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Information
            Paragraph prgAuthor = new Paragraph();
            Font fntAuthor = new Font(Vn_Helvetica, 12, iTextSharp.text.Font.NORMAL);
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.Add(new Chunk("Đơn vị sử dụng : " + tenKH, fntAuthor));
            prgAuthor.Add(new Chunk("\nLý do xuất : Bán", fntAuthor));
            prgAuthor.Add(new Chunk("\nKho xuất : Kho hàng hóa", fntAuthor));
            document.Add(prgAuthor);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header

            Font fntColumnHeader = new Font(Vn_Helvetica, 10, 1, Color.WHITE);
            Font fntColumn = new Font(Vn_Helvetica, 10, 1, Color.BLACK);
            table.DefaultCell.Phrase = new Phrase() { Font = fntColumnHeader };
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dtblTable.Rows[i][j].ToString(), fntColumn));
                }
            }

            document.Add(table);

            Paragraph prgMoney = new Paragraph();
            Font fntMoney = new Font(Vn_Helvetica, 13, 1, Color.BLACK);
            prgMoney.Alignment = Element.ALIGN_LEFT;
            prgMoney.Add(new Chunk("\nTổng Tiền : " + tongTien+" đồng", fntMoney));
            document.Add(prgMoney);

            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
