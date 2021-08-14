using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class QuanLyCongNoDAO
    {
        protected SqlConnection connection;
        public QuanLyCongNoDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public DataTable GetDataNoNCC()
        {
            DataTable table = new DataTable();
            string sql = "select SoNoNCC.Ma, NhaCungCap.Ten,(case when SoNoNCC.TienNo>0 then SoNoNCC.TienNo else '0' end) as [TienNo], (case when SoNoNCC.TienNo<0 then -SoNoNCC.TienNo else '0' end) as [TienCo] from SoNoNCC join NhaCungCap on SoNoNCC.MaNCC = NhaCungCap.Ma";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataNoNCCbyTen(string tenNCC)
        {
            DataTable table = new DataTable();
            string sql = "select SoNoNCC.Ma, NhaCungCap.Ten,(case when SoNoNCC.TienNo>0 then SoNoNCC.TienNo else '0' end) as [TienNo], (case when SoNoNCC.TienNo<0 then -SoNoNCC.TienNo else '0' end) as [TienCo] from SoNoNCC join NhaCungCap on SoNoNCC.MaNCC = NhaCungCap.Ma where NhaCungCap.Ten like N'%'+ @tenNCC +'%' ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@tenNCC", tenNCC));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataNoKH()
        {
            DataTable table = new DataTable();
            string sql = "select SoNoKhachHang.Ma, KhachHang.Ten,(case when SoNoKhachHang.TienNo>0 then SoNoKhachHang.TienNo else '0' end) as [TienNo], (case when SoNoKhachHang.TienNo<0 then -SoNoKhachHang.TienNo else '0' end) as [TienCo] from SoNoKhachHang join KhachHang on SoNoKhachHang.MaKH=KhachHang.Ma";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataNoKHbyTen(string tenKH)
        {
            DataTable table = new DataTable();
            string sql = "select SoNoKhachHang.Ma, KhachHang.Ten,(case when SoNoKhachHang.TienNo>0 then SoNoKhachHang.TienNo else '0' end) as [TienNo], (case when SoNoKhachHang.TienNo<0 then -SoNoKhachHang.TienNo else '0' end) as [TienCo] from SoNoKhachHang join KhachHang on SoNoKhachHang.MaKH=KhachHang.Ma where KhachHang.Ten like N'%'+ @tenKH +'%'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@tenKH", tenKH));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public float tinhTongNoNCC()
        {
            try
            {
                string sql = "select sum(case when TienNo>0 then TienNo else '0' end) from SoNoNCC";
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
        public float tinhTongCoNCC()
        {
            try
            {
                string sql = "select sum(case when TienNo<0 then -TienNo else '0' end) from SoNoNCC";
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
        public float tinhTongNoKH()
        {
            try
            {
                string sql = "select sum(case when SoNoKhachHang.TienNo>0 then SoNoKhachHang.TienNo else '0' end) from SoNoKhachHang";
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
        public float tinhTongCoKH()
        {
            try
            {
                string sql = "select sum(case when SoNoKhachHang.TienNo<0 then -SoNoKhachHang.TienNo else '0' end) from SoNoKhachHang";
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
        public float noKHbyMaNo(string maNo)
        {
            try
            {
                string sql = "select TienNo from SoNoKhachHang where Ma like  @maNo";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@maNo", maNo));
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
        public void UpdateTienNoKhachHang(string maNo,string maKH,float tienNo)
        {
            string sql = "UPDATE [SoNoKhachHang] SET [MaKH] = @maKH ,[TienNo] = @tienNo  WHERE [Ma] = @maNo";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maKH", maKH));
            command.Parameters.Add(new SqlParameter("@tienNo", tienNo));
            command.Parameters.Add(new SqlParameter("@maNo", maNo));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public float noNCCbyMaNo(string maNo)
        {
            try
            {
                string sql = "select TienNo from SoNoNCC where Ma like @maNo";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@maNo", maNo));
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
        public void UpdateTienNoNCC(string maNo, string maNCC, float tienNo)
        {
            string sql = "UPDATE [SoNoNCC] SET [MaNCC] = @maNCC ,[TienNo] = @tienNo  WHERE [Ma] = @maNo";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maNCC", maNCC));
            command.Parameters.Add(new SqlParameter("@tienNo", tienNo));
            command.Parameters.Add(new SqlParameter("@maNo", maNo));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
