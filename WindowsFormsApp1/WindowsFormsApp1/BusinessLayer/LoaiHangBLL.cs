using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.Entities;
using VatLieuXaydung.DataLayer;
using System.Data;

namespace VatLieuXaydung.BusinessLayer
{
    class LoaiHangBLL
    {
        LoaiHangDAL dal = new LoaiHangDAL();
        public static List<LoaiHang> GetLoaiHangByDMH(object value)
        { return LoaiHangDAL.GetLoaiHangByDMH(value); }

        public DataTable LoadDMH(object value)
        { return dal.LoadDMH(value); }

        public DataTable LoadAll()
        { return dal.LoadAll(); }

        public bool Insert(LoaiHang lh)
        {
            return dal.InSert(lh);
        }

        public LoaiHang GetByID(decimal id)
        {
            return dal.GetByID(id);
        }

        public bool Delete(LoaiHang lh)
        {
            return dal.Delete(lh);
        }

        public bool Update(LoaiHang lh)
        {
            return dal.Update(lh);
        }
    }
}
