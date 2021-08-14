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
    public class QuanLyNhapKhoDAO
    {
        protected SqlConnection connection;
        public QuanLyNhapKhoDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public List<NhaCungCap> listSupplier()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            try
            {
                string sql = "select * from NhaCungCap";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhaCungCap s = new NhaCungCap()
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
        public List<VatLieu> listVatLieubyNCC(string maNCC)
        {
            List<VatLieu> list = new List<VatLieu>();
            try
            {
                string sql = "select * from VatLieu where MaNCC = @ma";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@ma", maNCC));
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
        public DonViTinh getTenDVT(string maVL)
        {
            try
            {
                string sql = "select DonViTinh.TenDVT, DonViTinh.Ma from VatLieu join DonViTinh on VatLieu.MaDVT = DonViTinh.Ma where VatLieu.MaSo = @ma";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@ma", maVL));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DonViTinh s = new DonViTinh()
                    {
                        Ten = reader["TenDVT"].ToString(),
                        Ma = Convert.ToInt32(reader["Ma"].ToString()),
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
        public void TaoPhieuNhap(PhieuNhap entity)
        {
            string sql = "insert into PhieuNhap(Ma,NgayTao) values(@ma,@ngay)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@ma", entity.Ma));
            command.Parameters.Add(new SqlParameter("@ngay", entity.NgayTao));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public string getLastMaNhap()
        {
            try
            {
                string sql = "select top 1 Ma from PhieuNhap order by Ma desc";
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
        public void TaoThongTinPhieuNhap(string maNhap, string maVL, string maNCC, int sl, float donGia, float TongTien)
        {
            string sql = "insert into ThongTinPhieuNhap(MaNhap,MaVatLieu,MaNCC,SL,DonGiaNhap,TongTien) values (@manhap,@mavl,@mancc,@sl,@dongia,@tongtien)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@manhap", maNhap));
            command.Parameters.Add(new SqlParameter("@mavl", maVL));
            command.Parameters.Add(new SqlParameter("@mancc", maNCC));
            command.Parameters.Add(new SqlParameter("@sl", sl));
            command.Parameters.Add(new SqlParameter("@dongia", donGia));
            command.Parameters.Add(new SqlParameter("@tongtien", TongTien));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public NhaCungCap getMaNCC(string tenNCC)
        {
            try
            {
                string sql = "select Ma from NhaCungCap where Ten like N'%'+ @ten +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@ten", tenNCC));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhaCungCap s = new NhaCungCap()
                    {
                        Ma = reader["Ma"].ToString(),
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
        public VatLieu getGiaNhap(string maVL)
        {
            try
            {
                string sql = "select GiaNhap from VatLieu where MaSo like '%'+ @mavl +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@mavl", maVL));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    VatLieu s = new VatLieu()
                    {
                        GiaNhap = float.Parse(reader["GiaNhap"].ToString()),
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
        public void TaoThongTinNoNCC(string maNo, string maNhap, float tienTT, float tienCL, DateTime ngayTao)
        {
            string sql = "insert into ThongTinNoNCC(MaPhieuNhap,Ma,SoTienThanhToan,SoTienConLai,NgayTao) values(@maNhap,@maNo,@tienTT,@tienCL,@ngayTao)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maNhap", maNhap));
            command.Parameters.Add(new SqlParameter("@maNo", maNo));
            command.Parameters.Add(new SqlParameter("@tienTT", tienTT));
            command.Parameters.Add(new SqlParameter("@tienCL", tienCL));
            command.Parameters.Add(new SqlParameter("@ngayTao", ngayTao));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public string getMaSoNoNCC(string maNCC)
        {
            try
            {
                string sql = "select Ma from SoNoNCC where MaNCC like '%'+ @maNCC +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@maNCC", maNCC));
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
        public float getSoNoNCC(string maNCC)
        {
            try
            {
                string sql = "select TienNo from SoNoNCC where MaNCC like '%'+ @maNCC +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.Parameters.Add(new SqlParameter("@maNCC", maNCC));
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
            return 0;
        }
    }
}
