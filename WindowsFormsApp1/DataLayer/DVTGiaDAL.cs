using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.Entities;
using System.Data;

namespace VatLieuXaydung.DataLayer
{
    class DVTGiaDAL
    {
        DataAccessHelper db = new DataAccessHelper();

        public DVTGia GetListById(decimal id)
        {
            DVTGia kv = new DVTGia();
            List<DVTGia> list = GetList();
            foreach (DVTGia item in list)
            {
                if (item.Id == id)
                {
                    kv = item;
                }
            }
            return kv;
        }

        public static List<DVTGia> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select * from tblDonViTinhGia");
            List<DVTGia> list = new List<DVTGia>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new DVTGia(item));
            }
            return list;
        }

        public DataTable LoadDVTGia()
        {
            DataTable dt = db.GetDataTable("select * from tbldonvitinhgia order by DonViTinhGiaID desc");
            return dt;
        }


        public bool Insert(DVTGia dvtGia)
        {
            string spName = "SP_InsertDVTGia";
            string[] pNames = { "@LoaiTienTe" };
            object[] pValues = { dvtGia.Loai };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        public bool Update(DVTGia dvtGia)
        {
            string spName = "SP_UpdateDVTGia";
            string[] pNames = { "@DonViTinhGiaID", "@LoaiTienTe" };
            object[] pValues = {dvtGia.Id, dvtGia.Loai };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        public bool Delete(DVTGia dvtGia)
        {
            string spName = "SP_DeleteDVTGia";
            string[] pNames = { "@DonViTinhGiaID" };
            object[] pValues = { dvtGia.Id };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }
    }
}
