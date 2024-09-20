using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.DataLayer;
using VatLieuXaydung.Entities;
using System.Data;

namespace VatLieuXaydung.BusinessLayer
{
    class KhuVucBLL
    {
        KhuVucDAL dal = new KhuVucDAL();

        public DataTable LoadKhuVuc() { return dal.LoadKhuVuc(); }      

        public KhuVuc GetListById(decimal id)
        {
            return dal.GetListById(id);
        }

        //Thực thi gọi phương thức có sử dụng thủ tục

        public bool Insert(KhuVuc kv)
        {
            return dal.Insert(kv);
        }

        public bool Update(KhuVuc kv)
        {
            return dal.Update(kv);
        }

        public bool Delete(KhuVuc kv)
        {
            return dal.Delete(kv);
        }

        public bool GetAll() { return dal.GetAll(); }
    }
}
