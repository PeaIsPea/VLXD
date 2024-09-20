using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.Entities;
using VatLieuXaydung.DataLayer;
using System.Data;

namespace VatLieuXaydung.BusinessLayer
{
    class DVTGiaBLL
    {
        DVTGiaDAL dal = new DVTGiaDAL();


        public bool Insert(DVTGia dvtGia)
        {
            return dal.Insert(dvtGia);
        }

        public DVTGia GetListById(decimal id)
        {
            return dal.GetListById(id);
        }

        public bool Update(DVTGia dvtGia)
        {
            return dal.Update(dvtGia);
        }

        public bool Delete(DVTGia dvtGia)
        {
            return dal.Delete(dvtGia);
        }

        public DataTable LoadDVTGia() { return dal.LoadDVTGia(); }
    }
}
