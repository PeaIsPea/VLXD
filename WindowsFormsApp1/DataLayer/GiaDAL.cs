using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using VatLieuXaydung.Entities;

namespace VatLieuXaydung.DataLayer
{
    class GiaDAL
    {
        DataAccessHelper db = new DataAccessHelper();
        public DataTable LoadAll()
        {
            DataAccessHelper db = new DataAccessHelper();

            string sql = "select G.GiaID,	G.SanPhamID,DMH.DanhMucHangID,DMH.TenHang,LH.LoaiHangID,LH.TenLoaiHang,	G.NguonGia,G.Gia,	G.DonViTinhGiaID,DVTG.LoaiTienTe,	G.VAT,G.ThoiDiem from tblGia G,  tblDonViTinhGia DVTG, tblDanhMucHang DMH, tblLoaiHang LH, tblSanPham SP where  		DVTG.DonViTinhGiaID = G.DonViTinhGiaID and		DMH.DanhMucHangID = LH.DanhMucHangID and		LH.LoaiHangID = SP.LoaiHangID and		SP.SanPhamID = G.SanPhamID order by G.GiaID desc";
            DataTable dt = db.GetDataTable(sql);
            return dt;
        }

        public bool Insert(Gia g)
        {
            string spName = "SP_InsertGia";

            int dem = db.ExecuteScalar("SELECT MAX(SanPhamID) FROM tblSanPham");
            g.SpID = dem + 1;
            string[] pNames = { "@NguonGia", "@Gia", "@ThoiDiem", "@SanPhamID", "@DonViTinhGiaID", "@VAT" };

            object[] pValues = { g.NguonGia, g.Gia1, g.Thoidiem, g.SpID, g.DvtGiaID, g.VAT1 };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);

            return count > 0;
        }

        public bool Delete(decimal IdSp)
        {
            string spName = "SP_DeleteGia";
            string[] pNames = { "@SanPhamID" };
            object[] pValues = { IdSp };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);

            return count > 0;
        }

        public bool Update(Gia g)
        {
            string spName = "SP_UpdateGia";
            string[] pNames = { "@GiaID", "@NguonGia", "@Gia", "@ThoiDiem", "@SanPhamID", "@DonViTinhGiaID", "@VAT" };

            object[] pValues = { g.GiaID, g.NguonGia, g.Gia1, g.Thoidiem, g.SpID, g.DvtGiaID, g.VAT1 };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);

            return count > 0;
        }

        public static List<Gia> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select * from tblgia");
            List<Gia> list = new List<Gia>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Gia(item));
            }
            return list;
        }

        public  Gia GetByID(decimal id)
        {
            Gia g = new Gia();
            List<Gia> list = GetList();
            foreach (Gia item in list)
            {
                if (item.GiaID==id)
                {
                    g = item;
                    break;
                }
            }
            return g;
        }


    }
}
