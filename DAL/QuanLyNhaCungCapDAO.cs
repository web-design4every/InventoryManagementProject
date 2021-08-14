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
    public class QuanLyNhaCungCapDAO
    {
        protected SqlConnection connection;
        public QuanLyNhaCungCapDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public NhaCungCap getNhaCungCapByMaNo(string maNo)
        {
            try
            {
                string sql = "select NhaCungCap.Ma,NhaCungCap.Ten,NhaCungCap.DiaChi,NhaCungCap.SDT from SoNoNCC join NhaCungCap on SoNoNCC.MaNCC = NhaCungCap.Ma where SoNoNCC.Ma like N'%'+ @maNo +'%'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@maNo", maNo));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhaCungCap s = new NhaCungCap()
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
        
        public DataTable GetDataTTNoNCCbyMaNo(string maNo)
        {
            DataTable table = new DataTable();
            string sql = "select MaPhieuNhap,(case when SoTienConLai>0 then SoTienConLai else '0' end) as [TienNo],(case when SoTienConLai<0 then -SoTienConLai else '0' end) as [TienCo],NgayTao from ThongTinNoNCC where Ma like N'%'+ @maNo +'%'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maNo", maNo));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
