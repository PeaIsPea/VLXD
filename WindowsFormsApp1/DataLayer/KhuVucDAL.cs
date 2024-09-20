using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using VatLieuXaydung.Entities;

namespace VatLieuXaydung.DataLayer
{
    class KhuVucDAL
    {
        DataAccessHelper db = new DataAccessHelper();


        public DataTable LoadKhuVuc()
        {
            DataTable dt = db.GetDataTable("select * from tblKhuVuc order by KhuVucID desc");
            return dt;
        }





        public KhuVuc GetListById(decimal id)
        {
            KhuVuc kv = new KhuVuc();
            List<KhuVuc> list = GetList();
            foreach (KhuVuc item in list)
            {
                if (item.Id == id)
                {
                    kv = item;
                }
            }
            return kv;
        }

        public static List<KhuVuc> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select * from tblKhuVuc");
            List<KhuVuc> list = new List<KhuVuc>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new KhuVuc(item));
            }
            return list;
        }

        //Thực thi bằng thủ tục
        public bool Insert(KhuVuc kv)
        {
            string spName = "SP_InsertKhuVuc"; //Tên thủ tục
            //Tên các tham số trong thủ tục
            string[] pNames = { "@Name" };
            //Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { kv.Ten };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
            //int kq = db.ExcuteNonQuery("insert into tblKhuVuc values (N'" + kv.Ten + "')");
            //if (kq > 0)
            //{
            //    return 1;
            //}
            //else return 0;
        }

        public bool Update(KhuVuc kv)
        {
            string spName = "SP_UpdateKhuVuc";
            string[] pNames = { "@ID", "@Name" };
            object[] pValues = { kv.Id, kv.Ten };
            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
            //string sql = "update tblKhuVuc set TenKhuVuc = N'" + kv.Ten + "' where KhuVucID ='" + kv.Id + "'";
            //int kq = db.ExcuteNonQuery(sql);
            //if (kq > 0)
            //{
            //    return 1;
            //}
            //else return 0;
        }

        public bool Delete(KhuVuc kv)
        {
            string spName = "SP_DeleteKhuVuc";
            string[] pNames = { "@ID" };
            object[] pValues = { kv.Id };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
            //int kq = db.ExcuteNonQuery("delete from tblKhuVuc where KhuVucID = '" + kv.Id + "'");
            //if (kq > 0)
            //{
            //    return 1;
            //}
            //else return 0;
        }

        public bool GetAll()
        {
            string spName = "SP_GetAllKhuVuc";

            int count = db.ExecuteStoredProcedure(spName,null,null);
            return count > 0;
        }
    }
}
