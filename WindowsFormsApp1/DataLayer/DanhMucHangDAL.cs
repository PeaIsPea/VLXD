using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.Entities;
using System.Data;
using System.Data.SqlClient;

namespace VatLieuXaydung.DataLayer
{
    class DanhMucHangDAL
    {
        DataAccessHelper db = new DataAccessHelper();
        public static List<DanhMucHang> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select * from tblDanhMucHang order by danhmuchangid desc");
            List<DanhMucHang> list = new List<DanhMucHang>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new DanhMucHang(item));
            }
            return list;
        }

        public DataTable LoadDMH()
        {
            DataTable dt = db.GetDataTable("Select * from tblDanhMucHang");
            return dt;
        }

        public int GetCount()
        {
            string sql = "SELECT Rows FROM SYSINDEXES WHERE Id = OBJECT_ID('tblDanhMucHang') AND IndId < 2";
            int count = 0;
            DataAccessHelper db = new DataAccessHelper();
            SqlConnection con = db.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            count = (int)cmd.ExecuteScalar();
           
            return count;
            
        }

          

        public static  List<DanhMucHang> GetDanhMucHangByName(string keyword)
        {
            DataAccessHelper db = new DataAccessHelper();
            string sql = "select * from tblDanhMucHang where TenHang like '%"+keyword+"%'";
            DataTable dt = db.GetDataTable(sql);
            List<DanhMucHang> list = new List<DanhMucHang>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new DanhMucHang(item));
            }
            return list;
        }

        public DataTable Paging(int pageSize, int intSkip)
        {
            DataAccessHelper db = new DataAccessHelper();
            string sql = "SELECT TOP " + pageSize +
               " * FROM tblDanhMucHang WHERE DanhMucHangID NOT IN " +
               "(SELECT TOP " + intSkip + " DanhMucHangID FROM tblDanhMucHang)";

            DataTable dt = db.GetDataTable(sql);
            return dt;

        }
        //public static List<DanhMucHang> Paging(int pageSize, int intSkip)
        //{
        //    DataAccessHelper db = new DataAccessHelper();
        //    string sql = "SELECT TOP " + pageSize +
        //       " * FROM tblDanhMucHang WHERE DanhMucHangID NOT IN " +
        //       "(SELECT TOP " + intSkip + " DanhMucHangID FROM tblDanhMucHang)";

        //    DataTable dt = db.GetDataTable(sql);
        //    List<DanhMucHang> list = new List<DanhMucHang>();
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        list.Add(new DanhMucHang(item));
        //    }
        //    return list;
           
        //}

        public DanhMucHang GetDanhMucHangById(decimal id)
        {
            DanhMucHang dmh = new DanhMucHang();
            List<DanhMucHang> list = GetList();
            foreach (DanhMucHang item in list)
            {
                if (item.DanhMucHangID==id)
                {
                    dmh = item;
                    break;
                }
            }
            return dmh;
        }

        public bool Delete(DanhMucHang dmh)
        {
            string spName = "SP_DeleteDanhMucHang";
            string[] pNames = { "@DanhMucHangID" };
            object[] pValues = { dmh.DanhMucHangID };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        public bool Insert(DanhMucHang dmh)
        {
            string spName = "SP_InsertDanhMucHang";
            string[] pNames = { "@TenHang" };
            object[] pValues = { dmh.TenHang};

            int count = db.ExecuteStoredProcedure(spName,pNames,pValues);
            return count > 0;
        }

        public bool Update(DanhMucHang dmh)
        {
            string spName = "SP_UpdateDanhMucHang";
            string[] pNames = {"@DanhMucHangID", "@TenHang" };
            object[] pValues = {dmh.DanhMucHangID, dmh.TenHang };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }
    }
}
