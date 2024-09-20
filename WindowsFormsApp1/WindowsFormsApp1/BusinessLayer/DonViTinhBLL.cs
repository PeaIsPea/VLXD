using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.DataLayer;
using VatLieuXaydung.Entities;
using System.Data;

namespace VatLieuXaydung.BusinessLayer
{
    class DonViTinhBLL
    {
        DonViTinhDAL dal = new DonViTinhDAL();

        public DataTable LoadDVT()
        {
            return dal.LoadDVT();
        }

        public bool Insert(DonViTinh dvt)
        {
            return dal.Insert(dvt);
        }

        public DonViTinh GetListById(decimal id)
        {
            return dal.GetListById(id);
        }

        public bool Delete(DonViTinh dvt)
        {
            return dal.Delete(dvt);
        }

        public bool Update(DonViTinh dvt)
        {
            return dal.Update(dvt);
        }
    }
}
