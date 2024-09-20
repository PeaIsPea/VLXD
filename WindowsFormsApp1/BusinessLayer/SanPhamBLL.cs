using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.DataLayer;
using VatLieuXaydung.Entities;
using System.Data;

namespace VatLieuXaydung.BusinessLayer
{
    class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public static List<SanPham> GetList()
        {
            return SanPhamDAL.GetList();
        }

        public int Getcount() { return dal.GetCount(); }

        public DataTable Paging(int pageSize, int intSkip)
        {
            return dal.Paging(pageSize, intSkip);
        }

        public DataTable Reload()
        {
            return dal.Reload();
        }
        public DataTable LoadSanPhamByLoaiHang(string keyword)
        { return dal.LoadSanPhamByLoaiHang(keyword); }

        public bool Insert(SanPham sp)
        {
            return dal.Insert(sp);
        }
        public bool Delete(SanPham sp) { return dal.Delete(sp); }

        public bool Update(SanPham sp)
        {
            return dal.Update(sp);
        }

        public SanPham GetSanPhamByID(decimal id)
        {
            return dal.GetSanPhamByID(id);
        }

        public DataTable SearchByDate(string from, string to, decimal kvID)
        {
            return dal.SearchByDate(from, to, kvID);
        }

        public DataTable GetByNguonGia(string p)
        {
            return dal.GetByNguonGia(p);
        }

        public DataTable GetByHangSanXuat(string p)
        {
            return dal.GetByHangSanXuat(p);
        }

        public DataTable GetAll(string chuoi1,string chuoi2)
        {
            return dal.GetAll(chuoi1,chuoi2);
        }
        public DataTable GetAll(string u)
        {
            return dal.GetAll(u);
        }

        public DataTable GetByDMH(object value)
        {
            return dal.GetByDMH(value);
        }
    }
}
