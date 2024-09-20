using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.Entities;
using System.Data;
using System.Data.SqlClient;

namespace VatLieuXaydung.DataLayer
{
    class SanPhamDAL
    {
        DataAccessHelper db = new DataAccessHelper();
        public static List<SanPham> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select * from tblSanPham");
            List<SanPham> list = new List<SanPham>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new SanPham(item));
            }
            return list;
        }

        public DataTable Paging(int pageSize, int intSkip)
        {
           
            string sqlPaging = "select top " + pageSize + " sp.sanphamid,sp.loaihangid,lh.tenloaihang,lh.danhmuchangid,dmh.tenhang,sp.hangsanxuat,sp.model,sp.diemgiaohang,sp.thongsokhac,sp.khuvucid,kv.tenkhuvuc,g.nguongia,g.gia,g.thoidiem,g.donvitinhgiaid,dvtg.loaitiente,g.vat,sp.donvitinhid,dvt.tendonvitinh,g.giaid	from tblSanPham sp, tblkhuvuc kv, tbldonvitinh dvt, tblloaihang lh,tbldanhmuchang dmh,tblgia g,tbldonvitinhgia dvtg            where                kv.khuvucid = sp.khuvucid and dvt.donvitinhid = sp.donvitinhid and	lh.loaihangid = sp.loaihangid and	dmh.danhmuchangid = lh.danhmuchangid  and sp.sanphamid = g.sanphamid and g.donvitinhgiaid = dvtg.donvitinhgiaid and                sp.SanPhamID not in (select top " + intSkip + " sp1.SanPhamID from tblSanPham sp1)";
            DataTable dt = db.GetDataTable(sqlPaging);
            return dt;

        }

        public int GetCount()
        {
            string sql = "SELECT Rows FROM SYSINDEXES WHERE Id = OBJECT_ID('tblGia') AND IndId < 2";
            int count = 0;
            DataAccessHelper db = new DataAccessHelper();
            SqlConnection con = db.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            count = (int)cmd.ExecuteScalar();
            return count;

        }

        public DataTable Reload()
        {
            string sql = "select     sp.sanphamid,sp.loaihangid,lh.tenloaihang,lh.danhmuchangid,dmh.tenhang,sp.hangsanxuat,sp.model,sp.diemgiaohang,sp.thongsokhac,sp.khuvucid,kv.tenkhuvuc,g.nguongia,g.gia,g.thoidiem,g.donvitinhgiaid,dvtg.loaitiente,g.vat,sp.donvitinhid,dvt.tendonvitinh,g.giaid	from tblSanPham sp, tblkhuvuc kv, tbldonvitinh dvt, tblloaihang lh,tbldanhmuchang dmh,tblgia g,tbldonvitinhgia dvtg            where                kv.khuvucid = sp.khuvucid and dvt.donvitinhid = sp.donvitinhid and	lh.loaihangid = sp.loaihangid and	dmh.danhmuchangid = lh.danhmuchangid  and sp.sanphamid = g.sanphamid and g.donvitinhgiaid = dvtg.donvitinhgiaid order by sanphamid desc";
            DataTable dt = db.GetDataTable(sql);
            return dt;
        }

        public DataTable LoadSanPhamByLoaiHang(string keyword)
        {
            string sql = "select  sp.sanphamid,		sp.loaihangid,lh.tenloaihang,		lh.danhmuchangid,dmh.tenhang,		sp.hangsanxuat,sp.model,sp.diemgiaohang,sp.thongsokhac,		sp.khuvucid,kv.tenkhuvuc,		sp.donvitinhid,dvt.tendonvitinh		from tblSanPham sp, tblkhuvuc kv, tbldonvitinh dvt, tblloaihang lh,tbldanhmuchang dmh where kv.khuvucid = sp.khuvucid and		dvt.donvitinhid = sp.donvitinhid and		lh.loaihangid = sp.loaihangid and		dmh.danhmuchangid = lh.danhmuchangid and 		dmh.tenhang like '%" + keyword + "%' 		";
            DataTable dt = db.GetDataTable(sql);
            return dt;
        }

        public bool Insert(SanPham sp)
        {
            string spName = "SP_InsertSanPham";
            string[] pNames = { "@KhuVucID", "@DonViTinhID", "@LoaiHangID", "@HangSanXuat", "@Model", "@DiemGiaoHang", "@ThongSoKhac", "@SanPhamID" };
            object[] pValues = { sp.KhucVucID, sp.DonViTinhID, sp.LoaiHangID, sp.HangSanXuat, sp.Model, sp.DiemGiaoHang, sp.ThongSoKhac,sp.SanPhamID };

            //string spName = "SP_InsertSanPham";
            //string[] pNames = { "@KhuVucID", "@DonViTinhID", "@LoaiHangID", "@HangSanXuat", "@Model", "@DiemGiaoHang", "@ThongSoKhac", "@NguonGia", "@Gia", "@ThoiDiem", "@SanPhamID", "@DonViTinhGiaID", "@VAT" };
            //object[] pValues = { sp.KhucVucID, sp.DonViTinhID, sp.LoaiHangID, sp.HangSanXuat, sp.Model, sp.DiemGiaoHang, sp.ThongSoKhac, g.NguonGia, g.Gia1, g.Thoidiem, g.SpID, g.DvtGiaID, g.VAT1 };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);

            return count > 0;
        }

        public bool Update(SanPham sp)
        {
            string spName = "SP_UpdateSanPham";
            string[] pNames = { "@SanPhamID", "@KhuVucID", "@DonViTinhID", "@LoaiHangID", "@HangSanXuat", "@Model", "@DiemGiaoHang", "@ThongSoKhac" };
            object[] pValues = { sp.SanPhamID, sp.KhucVucID, sp.DonViTinhID, sp.LoaiHangID, sp.HangSanXuat, sp.Model, sp.DiemGiaoHang, sp.ThongSoKhac };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        public bool Delete(SanPham sp)
        {
            string spName = "SP_DeleteSanPham";
            string[] pNames = { "@SanPhamID" };
            object[] pValues = { sp.SanPhamID };

            int count = db.ExecuteStoredProcedure(spName, pNames, pValues);
            return count > 0;
        }

        public SanPham GetSanPhamByID(decimal id)
        {
            SanPham sp = new SanPham();
            List<SanPham> list = GetList();
            foreach (SanPham item in list)
            {
                if (item.SanPhamID == id)
                {
                    sp = item;
                    break;
                }
            }
            return sp;
        }

        public DataTable SearchByDate(string from, string to, decimal kvID)
        {
            string sql = "select     sp.sanphamid,sp.loaihangid,lh.tenloaihang,lh.danhmuchangid,dmh.tenhang,sp.hangsanxuat,sp.model,sp.diemgiaohang,sp.thongsokhac,sp.khuvucid,kv.tenkhuvuc,g.nguongia,g.gia,g.thoidiem,g.donvitinhgiaid,dvtg.loaitiente,g.vat,sp.donvitinhid,dvt.tendonvitinh,g.giaid	from tblSanPham sp, tblkhuvuc kv, tbldonvitinh dvt, tblloaihang lh,tbldanhmuchang dmh,tblgia g,tbldonvitinhgia dvtg            where                kv.khuvucid = sp.khuvucid and dvt.donvitinhid = sp.donvitinhid and	lh.loaihangid = sp.loaihangid and	dmh.danhmuchangid = lh.danhmuchangid  and sp.sanphamid = g.sanphamid and g.donvitinhgiaid = dvtg.donvitinhgiaid and g.thoidiem between '" + from + "' and '" + to + "'and kv.khuvucid = " + kvID + " order by sanphamid desc";
            DataTable dt = db.GetDataTable(sql);
            return dt;
        }

        public DataTable GetByNguonGia(string p)
        {
            string sql = "select  sp.sanphamid,sp.loaihangid,lh.tenloaihang,lh.danhmuchangid,dmh.tenhang,sp.hangsanxuat,sp.model,sp.diemgiaohang,sp.thongsokhac,sp.khuvucid,kv.tenkhuvuc,g.nguongia,g.gia,g.thoidiem,g.donvitinhgiaid,dvtg.loaitiente,g.vat,sp.donvitinhid,dvt.tendonvitinh,g.giaid	from tblSanPham sp, tblkhuvuc kv, tbldonvitinh dvt, tblloaihang lh,tbldanhmuchang dmh,tblgia g,tbldonvitinhgia dvtg where                kv.khuvucid = sp.khuvucid and  dvt.donvitinhid = sp.donvitinhid and	lh.loaihangid = sp.loaihangid and	dmh.danhmuchangid = lh.danhmuchangid  and sp.sanphamid = g.sanphamid and g.donvitinhgiaid = dvtg.donvitinhgiaid and		g.nguongia like '%" + p + "%' order by sp.sanphamid desc";
            DataTable dt = db.GetDataTable(sql);
            return dt;
        }

        public DataTable GetByHangSanXuat(string p)
        {
            string sql = "select  sp.sanphamid,sp.loaihangid,lh.tenloaihang,lh.danhmuchangid,dmh.tenhang,sp.hangsanxuat,sp.model,sp.diemgiaohang,sp.thongsokhac,sp.khuvucid,kv.tenkhuvuc,g.nguongia,g.gia,g.thoidiem,g.donvitinhgiaid,dvtg.loaitiente,g.vat,sp.donvitinhid,dvt.tendonvitinh,g.giaid	from tblSanPham sp, tblkhuvuc kv, tbldonvitinh dvt, tblloaihang lh,tbldanhmuchang dmh,tblgia g,tbldonvitinhgia dvtg where                kv.khuvucid = sp.khuvucid and  dvt.donvitinhid = sp.donvitinhid and	lh.loaihangid = sp.loaihangid and	dmh.danhmuchangid = lh.danhmuchangid  and sp.sanphamid = g.sanphamid and g.donvitinhgiaid = dvtg.donvitinhgiaid and		sp.hangsanxuat like '%" + p + "%' order by sp.sanphamid desc";
            DataTable dt = db.GetDataTable(sql);
            return dt;
        }

        public DataTable GetAll(string chuoi1, string chuoi2)
        {
            string sql1 = "select  sp.sanphamid,sp.loaihangid,lh.tenloaihang,lh.danhmuchangid,dmh.tenhang,sp.hangsanxuat,sp.model,sp.diemgiaohang,sp.thongsokhac,sp.khuvucid,kv.tenkhuvuc,g.nguongia,g.gia,g.thoidiem,g.donvitinhgiaid,dvtg.loaitiente,g.vat,sp.donvitinhid,dvt.tendonvitinh,g.giaid	from tblSanPham sp, tblkhuvuc kv, tbldonvitinh dvt, tblloaihang lh,tbldanhmuchang dmh,tblgia g,tbldonvitinhgia dvtg where                kv.khuvucid = sp.khuvucid and dvt.donvitinhid = sp.donvitinhid and	lh.loaihangid = sp.loaihangid and	dmh.danhmuchangid = lh.danhmuchangid  and sp.sanphamid = g.sanphamid and g.donvitinhgiaid = dvtg.donvitinhgiaid and	g.nguongia like '%" + chuoi1 + "%' and	sp.hangsanxuat like '%" + chuoi2 + "%' order by sp.sanphamid desc";

            DataTable dt = db.GetDataTable(sql1);
            return dt;
        }

        public DataTable GetAll(string u)
        {
            string sql1 = "select  sp.sanphamid,sp.loaihangid,lh.tenloaihang,lh.danhmuchangid,dmh.tenhang,sp.hangsanxuat,sp.model,sp.diemgiaohang,sp.thongsokhac,sp.khuvucid,kv.tenkhuvuc,g.nguongia,g.gia,g.thoidiem,g.donvitinhgiaid,dvtg.loaitiente,g.vat,sp.donvitinhid,dvt.tendonvitinh,g.giaid	from tblSanPham sp, tblkhuvuc kv, tbldonvitinh dvt, tblloaihang lh,tbldanhmuchang dmh,tblgia g,tbldonvitinhgia dvtg where                kv.khuvucid = sp.khuvucid and dvt.donvitinhid = sp.donvitinhid and	lh.loaihangid = sp.loaihangid and	dmh.danhmuchangid = lh.danhmuchangid  and sp.sanphamid = g.sanphamid and g.donvitinhgiaid = dvtg.donvitinhgiaid and	g.nguongia like '%" + u + "%' and	sp.hangsanxuat like '%" + u + "%' order by sp.sanphamid desc";

            DataTable dt = db.GetDataTable(sql1);
            return dt;
        }

        public DataTable GetByDMH(object value)
        {
            string sql = "select     sp.sanphamid,sp.loaihangid,lh.tenloaihang,lh.danhmuchangid,dmh.tenhang,sp.hangsanxuat,sp.model,sp.diemgiaohang,sp.thongsokhac,sp.khuvucid,kv.tenkhuvuc,g.nguongia,g.gia,g.thoidiem,g.donvitinhgiaid,dvtg.loaitiente,g.vat,sp.donvitinhid,dvt.tendonvitinh,g.giaid	from tblSanPham sp, tblkhuvuc kv, tbldonvitinh dvt, tblloaihang lh,tbldanhmuchang dmh,tblgia g,tbldonvitinhgia dvtg            where                kv.khuvucid = sp.khuvucid and dvt.donvitinhid = sp.donvitinhid and	lh.loaihangid = sp.loaihangid and	dmh.danhmuchangid = lh.danhmuchangid  and sp.sanphamid = g.sanphamid and g.donvitinhgiaid = dvtg.donvitinhgiaid and dmh.danhmuchangid = '"+value+"'";
            DataTable dt = db.GetDataTable(sql);
            return dt;
        }
    }
}
