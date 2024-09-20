using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.Entities;
using System.Data;

namespace VatLieuXaydung.DataLayer
{
    class DonViTinhDAL
    {
        DataAccessHelper db = new DataAccessHelper();



        public DonViTinh GetListById(decimal id)
        {
            DonViTinh dvt = new DonViTinh();
            List<DonViTinh> list = GetList();
            foreach (DonViTinh item in list)
            {
                if (item.Id == id)
                {
                    dvt = item;
                    break;
                }
            }
            return dvt;
        }

        public static List<DonViTinh> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select * from tblDonVitinh");
            List<DonViTinh> list = new List<DonViTinh>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new DonViTinh(item));
            }
            return list;
        }

        public DataTable LoadDVT()
        {
            DataTable dt = db.GetDataTable("select * from tbldonvitinh order by DonViTinhID desc");
            return dt;
        }

        public bool Insert(DonViTinh dvt)
        {
            string spName = "SP_InsertDonViTinh";
            string[] pNames = { "@TenDonViTinh" };
            object[] pValues = { dvt.Ten };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        public bool Delete(DonViTinh dvt)
        {
            string spName = "SP_DeleteDonViTinh";
            string[] pNames = { "@DonViTinhID" };
            object[] pValues = { dvt.Id };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        public bool Update(DonViTinh dvt)
        {
            string spName = "SP_UpdateDonViTinh";
            string[] pNames = { "@DonViTinhID", "@TenDonViTinh" };
            object[] pValues = { dvt.Id, dvt.Ten };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }
    }
}
