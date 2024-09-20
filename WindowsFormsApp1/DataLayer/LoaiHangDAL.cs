using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.Entities;
using System.Data;

namespace VatLieuXaydung.DataLayer
{
    class LoaiHangDAL
    {
        DataAccessHelper db = new DataAccessHelper();

        public static List<LoaiHang> GetLoaiHangByDMH(object value)
        {
            DataAccessHelper db = new DataAccessHelper();
            string sql = "select * from tblLoaiHang where DanhMucHangID ="+value+"";
            DataTable dt = db.GetDataTable(sql);
            List<LoaiHang> list = new List<LoaiHang>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new LoaiHang(item));
            }
            return list;
        }

        public DataTable LoadDMH(object value)
        {
            DataAccessHelper db = new DataAccessHelper();
            string sql = "SELECT * FROM tblLoaiHang INNER JOIN tblDanhMucHang ON tblLoaiHang.DanhMucHangID=tblDanhMucHang.DanhMucHangID where tblDanhMucHang.DanhMucHangID =" + value + "";
            //string sql = "select LoaiHangID,TenLoaiHang from tblLoaiHang where DanhMucHangID =" + value + "";
            DataTable dt = db.GetDataTable(sql);
            return dt;
        }

        public DataTable LoadAll()
        {
            DataAccessHelper db = new DataAccessHelper();
           // string sql = "select LoaiHangID,TenLoaiHang from tblLoaiHang";
            string sql = "SELECT * FROM tblLoaiHang INNER JOIN tblDanhMucHang ON tblLoaiHang.DanhMucHangID=tblDanhMucHang.DanhMucHangID order by LoaiHangID desc";
            DataTable dt = db.GetDataTable(sql);
            return dt;
        }
       
        public bool InSert(LoaiHang lh)
        {
            string spName = "SP_InsertLoaiHang";
            string[] pNames = { "@TenLoaiHang","@DanhMucHangID" };
            object[] pValues = { lh.Ten,lh.DmhID };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        public LoaiHang GetByID(decimal id)
        {
            LoaiHang lh = new LoaiHang();
            List<LoaiHang> list = GetList();
            foreach (LoaiHang item in list)
            {
                if (item.LoaiHangID==id)
                {
                    lh = item;
                    break;
                }
            }
            return lh;
        }

        private List<LoaiHang> GetList()
        {
            string sql = "select * from tblLoaiHang";
            DataTable dt = db.GetDataTable(sql);
            List<LoaiHang> list = new List<LoaiHang>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new LoaiHang(item));
            }
            return list;
        }

        public bool Delete(LoaiHang lh)
        {
            string spName = "SP_DeleteLoaiHang";
            string[] pNames = {"@LoaiHangID" };
            object[] pValues = { lh.LoaiHangID};

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        public bool Update(LoaiHang lh)
        {
            string spName = "SP_UpdateLoaiHang";
            string[] pNames = { "@LoaiHangID", "@TenLoaiHang", "@DanhMucHangID" };
            object[] pValues = { lh.LoaiHangID,lh.Ten,lh.DmhID };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        
    }
}
