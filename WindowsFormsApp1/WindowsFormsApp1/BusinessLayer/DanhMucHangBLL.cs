using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.Entities;
using VatLieuXaydung.DataLayer;
using System.Data;

namespace VatLieuXaydung.BusinessLayer
{
    class DanhMucHangBLL
    {
        DanhMucHangDAL dal = new DanhMucHangDAL();
        public static List<DanhMucHang> GetList()
        { return DanhMucHangDAL.GetList(); }
        public int Getcount() { return dal.GetCount(); }
        public DanhMucHang GetDanhMucHangById(decimal id)
        {
            return dal.GetDanhMucHangById(id);
        }
        public bool Delete(DanhMucHang dmh) { return dal.Delete(dmh); }
        public bool Insert(DanhMucHang dmh) { return dal.Insert(dmh); }
        public static List<DanhMucHang> GetDanhMucHangByName(string keyword) { return DanhMucHangDAL.GetDanhMucHangByName(keyword); }
        //public static List<DanhMucHang> Paging(int pageSize, int intSkip)
        //{
        //    return DanhMucHangDAL.Paging(pageSize, intSkip);
        //}
        public DataTable Paging(int pageSize, int intSkip)
        {
            return dal.Paging(pageSize,intSkip);
        }

        public  bool Update(DanhMucHang dmh)
        {
            return dal.Update(dmh);
        }

        public DataTable LoadDMH()
        {
            return dal.LoadDMH();
        }
    }
}
