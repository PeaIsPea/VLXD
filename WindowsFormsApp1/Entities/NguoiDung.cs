using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace VatLieuXaydung.Entities
{
    class NguoiDung
    {
        private string _taiKhoan;
        private string _matKhau;
        private string _hoTen;
        private string _email;
        private string _soDienThoai;
        private string _quyenHan;


        public string QuyenHan
        {
            get { return _quyenHan; }
            set { _quyenHan = value; }
        }

        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        public string TaiKhoan
        {
            get { return _taiKhoan; }
            set { _taiKhoan = value; }
        }

        public NguoiDung() { }
        public NguoiDung(string taiKhoan, string matKhau, string hoTen, string email, string soDienThoai, string quyenHan)
        {
            this._taiKhoan = taiKhoan;
            this._matKhau = matKhau;
            this._hoTen = hoTen;
            this._email = email;
            this._soDienThoai = soDienThoai;
            this._quyenHan = quyenHan;
        }
        public NguoiDung(string matKhau, string hoTen, string email, string soDienThoai, string quyenHan)
        {

            this._matKhau = matKhau;
            this._hoTen = hoTen;
            this._email = email;
            this._soDienThoai = soDienThoai;
            this._quyenHan = quyenHan;
        }
        public NguoiDung(string taiKhoan, string matKhau)
        {
            this._taiKhoan = taiKhoan;
            this._matKhau = matKhau;
        }
        public NguoiDung(DataRow row)
        {
            // TODO: Complete member initialization
            this._taiKhoan = row["TaiKhoan"].ToString();
            this._matKhau = row["MatKhau"].ToString();
            this._hoTen = row["HoTen"].ToString();
            this._email = row["Email"].ToString();
            this._soDienThoai = row["SoDienThoai"].ToString();
            this._quyenHan = row["QuyenHan"].ToString();

        }
    }
}
