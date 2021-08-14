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
    public class QuanLyQuyKhoDAO
    {
        protected SqlConnection connection;
        public QuanLyQuyKhoDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ToString());
        }
        public QuyKho GetQuyKho()
        {
            try
            {
                string sql = "select top 1 * from QuyKho order by Ngay desc";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    QuyKho s = new QuyKho()
                    {
                        maSo = Convert.ToInt32(reader["MaSo"].ToString()),
                        quyTien = float.Parse(reader["QuyTien"].ToString()),
                        ngay = Convert.ToDateTime(reader["Ngay"].ToString()),
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
        public DataTable GetDataPhieuThu()
        {
            DataTable table = new DataTable();
            string sql = "select MaThu,NguoiNop,DiaChi,LyDo,SoTien,Ngay from PhieuThu";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataPhieuChi()
        {
            DataTable table = new DataTable();
            string sql = "select MaChi,NguoiNhan,DiaChi,LyDo,SoTien,Ngay from PhieuChi";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public void CapNhatQuyKho(float tien, DateTime ngay)
        {
            int maSo = GetQuyKho().maSo + 1;
            float tongTien = GetQuyKho().quyTien + tien;
            string sql = "insert into QuyKho(MaSo,QuyTien,Ngay) values(@maSo,@tien,@ngay)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maSo", maSo));
            command.Parameters.Add(new SqlParameter("@tien", tongTien));
            command.Parameters.Add(new SqlParameter("@ngay", ngay));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void insertPhieuThu(string nguoiNop,string diaChi,string lyDO,float tien, DateTime ngay)
        {
            int maSo = GetQuyKho().maSo;
            string maThu = (int.Parse(GetLastMaThu()) + 1).ToString("D3");
            string sql = "insert into PhieuThu(MaThu,MaQuy,NguoiNop,DiaChi,LyDo,SoTien,Ngay) values (@maThu,@maSo,@nguoiNop,@diaChi,@lyDO,@tien,@ngay)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maThu", maThu));
            command.Parameters.Add(new SqlParameter("@maSo", maSo));
            command.Parameters.Add(new SqlParameter("@nguoiNop", nguoiNop));
            command.Parameters.Add(new SqlParameter("@diaChi", diaChi));
            command.Parameters.Add(new SqlParameter("@lyDO", lyDO));
            command.Parameters.Add(new SqlParameter("@tien", tien));
            command.Parameters.Add(new SqlParameter("@ngay", ngay));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void insertPhieuChi(string nguoiNhan, string diaChi, string lyDO, float tien, DateTime ngay)
        {
            int maSo = GetQuyKho().maSo;
            string maChi = (int.Parse(GetLastMaChi()) + 1).ToString("D3");
            string sql = "insert into PhieuChi(MaChi,MaQuy,NguoiNhan,DiaChi,LyDo,SoTien,Ngay) values (@maChi,@maSo,@nguoiNhan,@diaChi,@lyDO,@tien,@ngay)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@maChi", maChi));
            command.Parameters.Add(new SqlParameter("@maSo", maSo));
            command.Parameters.Add(new SqlParameter("@nguoiNhan", nguoiNhan));
            command.Parameters.Add(new SqlParameter("@diaChi", diaChi));
            command.Parameters.Add(new SqlParameter("@lyDO", lyDO));
            command.Parameters.Add(new SqlParameter("@tien", tien));
            command.Parameters.Add(new SqlParameter("@ngay", ngay));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public string GetLastMaThu()
        {
            try
            {
                string sql = "select top 1 MaThu from PhieuThu order by MaThu desc";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string maThu = reader["MaThu"].ToString();
                    return maThu;
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
        public string GetLastMaChi()
        {
            try
            {
                string sql = "select top 1 MaChi from PhieuChi order by MaChi desc";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string maChi = reader["MaChi"].ToString();
                    return maChi;
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
        public PhieuThu GetPhieuThu(string mathu)
        {
            try
            {
                string sql = "select * from PhieuThu where MaThu=@mathu";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@mathu", mathu));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuThu s = new PhieuThu()
                    {
                        maThu = reader["MaThu"].ToString(),
                        maQuy = Convert.ToInt32(reader["MaQuy"].ToString()),
                        nguoiNop = reader["NguoiNop"].ToString(),
                        diaChi = reader["DiaChi"].ToString(),
                        lyDo = reader["LyDo"].ToString(),
                        tien = float.Parse(reader["SoTien"].ToString()),
                        ngay = Convert.ToDateTime(reader["Ngay"].ToString()),
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
        public PhieuChi GetPhieuChi(string machi)
        {
            try
            {
                string sql = "select * from PhieuChi where MaChi=@machi";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(new SqlParameter("@machi", machi));
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuChi s = new PhieuChi()
                    {
                        maThu = reader["MaChi"].ToString(),
                        maQuy = Convert.ToInt32(reader["MaQuy"].ToString()),
                        nguoiNop = reader["NguoiNhan"].ToString(),
                        diaChi = reader["DiaChi"].ToString(),
                        lyDo = reader["LyDo"].ToString(),
                        soTien = float.Parse(reader["SoTien"].ToString()),
                        ngay = Convert.ToDateTime(reader["Ngay"].ToString()),
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
    }
}
