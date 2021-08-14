using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class PhieuNhapXuatDAO
    {
        protected SqlConnection connection;
        public PhieuNhapXuatDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public DataTable GetDataPhieuNhap()
        {
            DataTable table = new DataTable();
            string sql = "select p.Ma, n.Ten, sum(t.TongTien) as [TongTien], p.NgayTao from PhieuNhap p join ThongTinPhieuNhap t on p.Ma = t.MaNhap join NhaCungCap n on t.MaNCC = n.Ma group by p.Ma,n.Ten,p.NgayTao  order by p.Ma";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataPhieuXuat()
        {
            DataTable table = new DataTable();
            string sql = "select p.Ma, n.Ten, sum(t.TongTien) as [TongTien], p.NgayTao from PhieuXuat p join ThongTinPhieuXuat t on p.Ma = t.MaXuat join KhachHang n on t.MaKH = n.Ma group by p.Ma,n.Ten,p.NgayTao  order by p.Ma";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataPhieuNhapBy(int so,string str)
        {
            DataTable table = new DataTable();
            string sql = "select p.Ma, n.Ten, sum(t.TongTien) as [TongTien], p.NgayTao from PhieuNhap p join ThongTinPhieuNhap t on p.Ma = t.MaNhap join NhaCungCap n on t.MaNCC = n.Ma ";
            if (so == 1)
            {
                sql += "where p.Ma like '%'+ @str +'%' group by p.Ma,n.Ten,p.NgayTao order by p.Ma";
            }
            else if (so == 2)
            {
                sql += "where n.Ten like N'%'+ @str +'%' group by p.Ma,n.Ten,p.NgayTao order by p.Ma";
            }
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@str", str));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable GetDataPhieuXuatBy(int so, string str)
        {
            DataTable table = new DataTable();
            string sql = "select p.Ma, n.Ten, sum(t.TongTien) as [TongTien], p.NgayTao from PhieuXuat p join ThongTinPhieuXuat t on p.Ma = t.MaXuat join KhachHang n on t.MaKH = n.Ma ";
            if (so == 1)
            {
                sql += "where p.Ma like '%'+ @str +'%' group by p.Ma,n.Ten,p.NgayTao order by p.Ma";
            }
            else if (so == 2)
            {
                sql += "where n.Ten like N'%'+ @str +'%' group by p.Ma,n.Ten,p.NgayTao order by p.Ma";
            }
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@str", str));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataChiTietPNbyMaNhap(string maNhap)
        {
            DataTable table = new DataTable();
            string sql = "select v.MaSo as [MaVatLieu], v.TenVatLieu, d.TenDVT as [DonViTinh], t.SL,t.DonGiaNhap,t.TongTien from ThongTinPhieuNhap t join VatLieu v on t.MaVatLieu = v.MaSo join DonViTinh d on v.MaDVT = d.Ma where t.MaNhap like '%'+ @maNhap +'%'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maNhap", maNhap));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataChiTietPNbyMaXuat(string maXuat)
        {
            DataTable table = new DataTable();
            string sql = "select v.MaSo as [MaVatLieu], v.TenVatLieu, d.TenDVT as [DonViTinh], t.SL,t.DonGiaXuat,t.TongTien from ThongTinPhieuXuat t join VatLieu v on t.MaVatLieu = v.MaSo join DonViTinh d on v.MaDVT = d.Ma where t.MaXuat like '%'+ @maXuat +'%'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maXuat", maXuat));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
