using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class QuanLyTonKhoDAO
    {
        protected SqlConnection connection;
        public QuanLyTonKhoDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public List<VatLieu> listVatLieu()
        {
            List<VatLieu> list = new List<VatLieu>();
            try
            {
                string sql = "select * from VatLieu";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    VatLieu s = new VatLieu()
                    {
                        MaSo = reader["MaSo"].ToString(),
                        MaNCC = reader["MaNCC"].ToString(),
                        TenVatLieu = reader["TenVatLieu"].ToString(),
                        DVT = Convert.ToInt32(reader["MaDVT"].ToString()),
                        SLTon = Convert.ToInt32(reader["SLTon"].ToString()),
                        GiaXuat = float.Parse(reader["GiaXuat"].ToString()),
                        GiaNhap = float.Parse(reader["GiaNhap"].ToString()),
                    };
                    list.Add(s);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
            return list;
        }

        public DataTable GetDataToTable()
        {
            DataTable table = new DataTable();
            string sql = "select VatLieu.MaSo, VatLieu.TenVatLieu, NhaCungCap.Ten, DonViTinh.TenDVT, VatLieu.SLTon, VatLieu.GiaNhap, VatLieu.GiaXuat from VatLieu join DonViTinh on VatLieu.MaDVT = DonViTinh.Ma join NhaCungCap on VatLieu.MaNCC = NhaCungCap.Ma";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public void UpdateVatLieu(float giaNhap, float giaXuat, string maVL)
        {
            string sql = "UPDATE VatLieu SET GiaNhap = @giaNhap, GiaXuat=@giaXuat where MaSo like '%'+ @mavl +'%'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@giaNhap", giaNhap));
            command.Parameters.Add(new SqlParameter("@giaXuat", giaXuat));
            command.Parameters.Add(new SqlParameter("@mavl", maVL));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public float tinhTongNhapKho()
        {
            try
            {
                string sql = "select sum(VatLieu.SLTon*VatLieu.GiaNhap) from VatLieu";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    float tien = float.Parse(reader[0].ToString());
                    return tien;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
            return 0;
        }
        public DataTable GetDataToTableByMaVL(string maVL)
        {
            DataTable table = new DataTable();
            string sql = "select VatLieu.MaSo, VatLieu.TenVatLieu, NhaCungCap.Ten, DonViTinh.TenDVT, VatLieu.SLTon, VatLieu.GiaNhap, VatLieu.GiaXuat from VatLieu join DonViTinh on VatLieu.MaDVT = DonViTinh.Ma join NhaCungCap on VatLieu.MaNCC = NhaCungCap.Ma where MaSo like '%'+ @mavl +'%'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@mavl", maVL));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataToTableByTenVL(string tenVL)
        {
            DataTable table = new DataTable();
            string sql = "select VatLieu.MaSo, VatLieu.TenVatLieu, NhaCungCap.Ten, DonViTinh.TenDVT, VatLieu.SLTon, VatLieu.GiaNhap, VatLieu.GiaXuat from VatLieu join DonViTinh on VatLieu.MaDVT = DonViTinh.Ma join NhaCungCap on VatLieu.MaNCC = NhaCungCap.Ma where TenVatLieu like '%'+ @tenVL +'%'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@tenVL", tenVL));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataToTableByNCC(string tenNCC)
        {
            DataTable table = new DataTable();
            string sql = "select VatLieu.MaSo, VatLieu.TenVatLieu, NhaCungCap.Ten, DonViTinh.TenDVT, VatLieu.SLTon, VatLieu.GiaNhap, VatLieu.GiaXuat from VatLieu join DonViTinh on VatLieu.MaDVT = DonViTinh.Ma join NhaCungCap on VatLieu.MaNCC = NhaCungCap.Ma where NhaCungCap.Ten like '%'+ @tenNCC +'%'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@tenNCC", tenNCC));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataChiTietVatLieu(string maVL)
        {
            DataTable table = new DataTable();
            string sql = "select pn.NgayTao,pn.Ma as [MaNhap],'-' as [MaXuat],N'Nhập kho bán hàng' as" +
                " [DienGiai],tn.SL as [SLNhap],'-' as [SLXuat] from VatLieu v join ThongTinPhieuNhap tn " +
                "on v.MaSo=tn.MaVatLieu join PhieuNhap pn on tn.MaNhap=pn.Ma where v.MaSo=@maVL" +
                " union select px.NgayTao,'-' as [MaNhap], px.Ma as [MaXuat],N'Xuất kho bán hàng' " +
                "as [DienGiai],'-' as [SLNhap],tx.SL as [SLXuat] from VatLieu v join ThongTinPhieuXuat tx " +
                "on v.MaSo=tx.MaVatLieu  join PhieuXuat px on tx.MaXuat=px.Ma where v.MaSo=@maVL";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maVL", maVL));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
