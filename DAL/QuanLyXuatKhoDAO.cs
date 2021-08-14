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
    public class QuanLyXuatKhoDAO
    {
        protected SqlConnection connection;
        public QuanLyXuatKhoDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public List<KhachHang> danhSachKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            try
            {
                string sql = "select * from KhachHang";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang s = new KhachHang()
                    {
                        Ten = reader["Ten"].ToString(),
                        Ma = reader["Ma"].ToString(),
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
        public VatLieu getGiaXuat(string maVL)
        {
            try
            {
                string sql = "select GiaXuat from VatLieu where MaSo like '%'+ @mavl +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@mavl", maVL));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    VatLieu s = new VatLieu()
                    {
                        GiaXuat = float.Parse(reader["GiaXuat"].ToString()),
                    };
                    return s;
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
            return null;
        }
        public string getLastMaXuat()
        {
            try
            {
                string sql = "select top 1 Ma from PhieuXuat order by Ma desc";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string Ma = reader["Ma"].ToString();
                    return Ma;
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
            return "0000";
        }
        public void TaoPhieuXuat(PhieuXuat entity)
        {
            string sql = "insert into PhieuXuat(Ma,NgayTao) values(@ma,@ngay)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@ma", entity.MaXuat));
            command.Parameters.Add(new SqlParameter("@ngay", entity.NgayTao));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void TaoThongTinPhieuXuat(string maXuat, string maVL, string maKH, int sl, float donGia, float TongTien)
        {
            string sql = "insert into ThongTinPhieuXuat(MaXuat,MaVatLieu,MaKH,SL,DonGiaXuat,TongTien) values (@maXuat,@mavl,@maKH,@sl,@dongia,@tongtien)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maXuat", maXuat));
            command.Parameters.Add(new SqlParameter("@mavl", maVL));
            command.Parameters.Add(new SqlParameter("@maKH", maKH));
            command.Parameters.Add(new SqlParameter("@sl", sl));
            command.Parameters.Add(new SqlParameter("@dongia", donGia));
            command.Parameters.Add(new SqlParameter("@tongtien", TongTien));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void TaoThongTinNoKH(string maNo, string maXuat, float tienTT, float tienCL, DateTime ngayTao)
        {
            string sql = "insert into ThongTinNoKH(MaPhieuXuat,Ma,SoTienThanhToan,SoTienConLai,NgayTao) values(@maXuat,@maNo,@tienTT,@tienCL,@ngayTao)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maXuat", maXuat));
            command.Parameters.Add(new SqlParameter("@maNo", maNo));
            command.Parameters.Add(new SqlParameter("@tienTT", tienTT));
            command.Parameters.Add(new SqlParameter("@tienCL", tienCL));
            command.Parameters.Add(new SqlParameter("@ngayTao", ngayTao));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public string getMaSoNoKH(string maKH)
        {
            try
            {
                string sql = "select Ma from SoNoKhachHang where MaKH like '%'+ @maKH +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@maKH", maKH));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string Ma = reader["Ma"].ToString();
                    return Ma;
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
            return "001";
        }
        public float getSoNoKH(string maKH)
        {
            try
            {
                string sql = "select TienNo from SoNoKhachHang where MaKH like '%'+ @maKH +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@maKH", maKH));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    float tien = float.Parse(reader["TienNo"].ToString());
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
            return 1;
        }
        public int getSLTonbyMaVL(string maVL)
        {
            try
            {
                string sql = "select SLTon from VatLieu where MaSo like '%'+ @maVL +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@maVL", maVL));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int slTon = Convert.ToInt32(reader["SLTon"].ToString());
                    return slTon;
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
        public string getLastMaKH()
        {
            try
            {
                string sql = "select top 1 Ma from KhachHang order by Ma desc";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string Ma = reader["Ma"].ToString();
                    return Ma;
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
            return "00";
        }
    }
}
