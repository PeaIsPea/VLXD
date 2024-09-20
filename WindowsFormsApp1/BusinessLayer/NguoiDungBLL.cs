using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatLieuXaydung.DataLayer;
using VatLieuXaydung.Entities;
using System.Data;

namespace VatLieuXaydung.BusinessLayer
{
    class NguoiDungBLL
    {
        NguoiDungDAL dal = new NguoiDungDAL();
        public string GetRole(string u) { return dal.GetRole(u);}
        public int KiemTraTen(string username)
        { return dal.KiemTraTen(username); }
        public int DangNhap(string user,string pwd)
        {
            return dal.CheckLogin(user,pwd);
        }
        public int DoiMatKhau(NguoiDung obj)
        {
            return dal.DoiMatKhau(obj);
        }
        public string KiemTraMatKhau(string u)
        { return dal.KiemTraMatKhau(u); }
       
        public static List<NguoiDung> GetList()
        { return NguoiDungDAL.GetList(); }
        public NguoiDung GetNguoiDungById(string nd) { return dal.GetNguoiDungById(nd); }

        public bool Insert(NguoiDung nd)
        {
            return dal.Insert(nd);
        }
        public bool Delete(NguoiDung nd) { return dal.Delete(nd); }

        public bool Update(NguoiDung nd)
        {
            return dal.Update(nd);
        }

        public DataTable LoadNguoiDung()
        { return dal.LoadNguoiDung(); }
    }
}
