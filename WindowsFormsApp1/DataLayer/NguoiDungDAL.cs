using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.Entities;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace VatLieuXaydung.DataLayer
{
    class NguoiDungDAL
    {
        DataAccessHelper db = new DataAccessHelper();
        SqlDataReader reader;
        SqlCommand cmd;
        SqlConnection conn;
        public string GetRole(string u)
        {
            string sql = "select QuyenHan from tblNguoiDung where TaiKhoan ='" + u + "'";
            conn = db.GetConnection();
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            u = cmd.ExecuteScalar().ToString();
            return u;
        }
        public int CheckLogin(string username, string pwd)
        {
            reader = db.ExecuteReader("SELECT * FROM tblNguoidung");
            while (reader.Read())
            {

                if (reader["TaiKhoan"].ToString() == username && reader["MatKhau"].ToString() == pwd)
                {
                    return 1;
                }
            }
            return 0;
        }
        public int DoiMatKhau(NguoiDung obj)
        {
            int result = db.ExcuteNonQuery("update tblNguoiDung set MatKhau = N'" + obj.MatKhau + "' where TaiKhoan = '" + obj.TaiKhoan + "'");
            return 1;
        }
        public string GetMatKhauHienTai(string u)
        {
            string sql = "select matkhau from tblnguoidung where taikhoan = '"+u+"'";
            conn = db.GetConnection();
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            u = cmd.ExecuteScalar().ToString();
            return u;
            
        }

        public string KiemTraMatKhau(string u)
        {
            string sql = "select matkhau from tblnguoidung where taikhoan = '" + u + "'";
            conn = db.GetConnection();
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            u = cmd.ExecuteScalar().ToString();
            return u;
            
            //reader = db.ExecuteReader("select * from tblNguoiDung where MatKhau = '" + matKhauHienTai + "'");
            //while (reader.Read())
            //{
            //    if (reader["MatKhau"].ToString() == GetMatKhauHienTai(matKhauHienTai))
            //    {
            //        return 1;
            //    }
            //}
            //return 0;
          
        }
        public int KiemTraTen(string username)
        {
            string sqlTen = "select TaiKhoan from tblNguoiDung where TaiKhoan = '" + username + "'";
            reader = db.ExecuteReader(sqlTen);
            while (reader.Read())
            {
                if (reader["TaiKhoan"].ToString() == username)
                {
                    return 0;
                }
            }
            return 1;
        }
        public static List<NguoiDung> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable tbNguoiDung = db.GetDataTable("select * from tblNguoiDung");
            List<NguoiDung> list = new List<NguoiDung>();
            foreach (DataRow row in tbNguoiDung.Rows)
            {
                list.Add(new NguoiDung(row));
            }
            return list;
        }
        public NguoiDung GetNguoiDungById(string id)
        {
            NguoiDung nd = new NguoiDung();
            List<NguoiDung> list = GetList();
            foreach (NguoiDung item in list)
            {
                if (item.TaiKhoan == id)
                {
                    nd = item;
                    break;
                }
            }
            return nd;
        }

        public bool Insert(NguoiDung nd)
        {
            string spName = "SP_InsertNguoiDung";
            string[] pNames = { "@TaiKhoan", "@MatKhau", "@HoTen", "@Email", "@SoDienThoai", "@QuyenHan" };
            object[] pValues = { nd.TaiKhoan, nd.MatKhau, nd.HoTen, nd.Email, nd.SoDienThoai, nd.QuyenHan };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);

            return count > 0;
        }

        public bool Delete(NguoiDung nd)
        {
            string spName = "SP_DeleteNguoiDung";
            string[] pNames = { "@TaiKhoan" };
            object[] pValues = { nd.TaiKhoan };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);

            return count > 0;
        }

        public bool Update(NguoiDung nd)
        {
            string spName = "SP_UpdateNguoiDung";
            string[] pNames = { "@TaiKhoan", "@MatKhau", "@HoTen", "@Email", "@SoDienThoai", "@QuyenHan" };
            object[] pValues = { nd.TaiKhoan, nd.MatKhau, nd.HoTen, nd.Email, nd.SoDienThoai, nd.QuyenHan };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);

            return count > 0;
        }

        public DataTable LoadNguoiDung()
        {
            DataTable tbNguoiDung = db.GetDataTable("select taikhoan,hoten,email,sodienthoai,quyenhan from tblNguoiDung");
            return tbNguoiDung;
        }

    }
}
