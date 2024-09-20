using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace VatLieuXaydung.DataLayer
{
    class DataAccessHelper
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(Properties.Settings.Default.VatLieuDBConnectionString.ToString());
        }
        public int ExcuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            return cmd.ExecuteNonQuery();
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public int ExecuteScalar(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object reader =(object) cmd.ExecuteScalar();
            return int.Parse(reader.ToString());
        }
        public DataTable GetDataTable(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public object GetValue(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteScalar();
        }

        public int ExecuteStoredProcedure(string spName, string[] pNames, object[] pValues)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            //Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, conn);
            //Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            //Khai báo tham số SqlParameter
            SqlParameter p;
            //Khởi tạo danh sách các tham số với các giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);

                cmd.Parameters.Add(p);
            }
            //return 0;
            return cmd.ExecuteNonQuery();
        }

    }
}
