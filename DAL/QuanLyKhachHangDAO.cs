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
    public class QuanLyKhachHangDAO
    {
        protected SqlConnection connection;
        public QuanLyKhachHangDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public void TaoMoiKhachHang(string maKH, string tenKH, string diachi, string sdt)
        {
            string sql = "insert into KhachHang(Ma,Ten,DiaChi,SDT) values(@maKH,@tenKH,@diachi,@sdt)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maKH", maKH));
            command.Parameters.Add(new SqlParameter("@tenKH", tenKH));
            command.Parameters.Add(new SqlParameter("@diachi", diachi));
            command.Parameters.Add(new SqlParameter("@sdt", sdt));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
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
        public KhachHang getKhachHangMoi()
        {
            try
            {
                string sql = "select top 1 * from KhachHang order by Ma desc";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang s = new KhachHang()
                    {
                        Ma = reader["Ma"].ToString(),
                        Ten = reader["Ten"].ToString(),
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
        public void TaoSoNoKH(string maSo, string maKH, string TienNo)
        {
            string sql = "insert into SoNoKhachHang(Ma,MaKH,TienNo) values(@maSo,@maKH,@TienNo)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maSo", maSo));
            command.Parameters.Add(new SqlParameter("@maKH", maKH));
            command.Parameters.Add(new SqlParameter("@TienNo", TienNo));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public string getLastMaSoNo()
        {
            try
            {
                string sql = "select top 1 Ma from SoNoKhachHang order by Ma desc";
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
            return "001";
        }
        public KhachHang getKhachHangByMaNo(string maNo)
        {
            try
            {
                string sql = "select KhachHang.Ma,KhachHang.Ten,KhachHang.DiaChi,KhachHang.SDT from SoNoKhachHang join KhachHang on SoNoKhachHang.MaKH = KhachHang.Ma where SoNoKhachHang.Ma like '%'+ @maNo +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@maNo", maNo));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang s = new KhachHang()
                    {
                        Ma = reader["Ma"].ToString(),
                        Ten = reader["Ten"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SDT = reader["SDT"].ToString(),
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

        public DataTable GetDataTTNoKHbyMaNo(string maNo)
        {
            DataTable table = new DataTable();
            string sql = "select MaPhieuXuat,(case when SoTienConLai>0 then SoTienConLai else '0' end) as [TienNo],(case when SoTienConLai<0 then -SoTienConLai else '0' end) as [TienCo],NgayTao from ThongTinNoKH where Ma like '%'+ @maNo +'%'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maNo", maNo));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
