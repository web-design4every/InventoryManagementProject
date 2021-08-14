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
    public class DangNhapDAO
    {
        protected SqlConnection connection;
        public DangNhapDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public List<TaiKhoan> getTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            try
            {
                string sql = "select TaiKhoan, MatKhau, SDT from TaiKhoan";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TaiKhoan s = new TaiKhoan()
                    {
                        taiKhoan = reader["TaiKhoan"].ToString(),
                        matKhau = reader["MatKhau"].ToString(),
                        sdt = reader["SDT"].ToString(),
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

    }
}
