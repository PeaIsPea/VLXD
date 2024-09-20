using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VatLieuXaydung.Entities
{
    class SanPham
    {
        private decimal _sanPhamID;
        private decimal _khucVucID;
        private decimal _donViTinhID;
        private decimal _loaiHangID;
        private string _hangSanXuat;
        private string _model;
        private string _diemGiaoHang;
        private string _thongSoKhac;

        public SanPham(decimal spID,decimal kvid, decimal dvtid, decimal lhid, string hsx, string model, string diemgiaohang, string thongso)
        {
            this._sanPhamID = spID;
            this._khucVucID = kvid;
            this._donViTinhID = dvtid;
            this._loaiHangID = lhid;
            this._hangSanXuat = hsx;
            this._model = model;
            this._diemGiaoHang = diemgiaohang;
            this._thongSoKhac = thongso;
        }

        public SanPham(decimal kvid,decimal dvtid,decimal lhid,string hsx,string model,string diemgiaohang,string thongso)
        {
            this._khucVucID = kvid;
            this._donViTinhID = dvtid;
            this._loaiHangID = lhid;
            this._hangSanXuat = hsx;
            this._model = model;
            this._diemGiaoHang = diemgiaohang;
            this._thongSoKhac = thongso;
            //this._sanPhamID = spID;
        }

        public SanPham(System.Data.DataRow item)
        {

            this._sanPhamID = decimal.Parse(item["SanPhamID"].ToString());
            this._khucVucID = decimal.Parse(item["KhuVucID"].ToString());
            this._donViTinhID = decimal.Parse(item["DonViTinhID"].ToString());
            this._loaiHangID = decimal.Parse(item["LoaiHangID"].ToString());
            this._hangSanXuat = item["HangSanXuat"].ToString();
            this._model = item["Model"].ToString();
            this._diemGiaoHang = item["DiemGiaoHang"].ToString();
            this._thongSoKhac = item["ThongSoKhac"].ToString();

        }

        public SanPham()
        {
            // TODO: Complete member initialization
        }

        public string ThongSoKhac
        {
            get { return _thongSoKhac; }
            set { _thongSoKhac = value; }
        }

        public string DiemGiaoHang
        {
            get { return _diemGiaoHang; }
            set { _diemGiaoHang = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string HangSanXuat
        {
            get { return _hangSanXuat; }
            set { _hangSanXuat = value; }
        }

        public decimal LoaiHangID
        {
            get { return _loaiHangID; }
            set { _loaiHangID = value; }
        }

        public decimal DonViTinhID
        {
            get { return _donViTinhID; }
            set { _donViTinhID = value; }
        }

        public decimal KhucVucID
        {
            get { return _khucVucID; }
            set { _khucVucID = value; }
        }
        public decimal SanPhamID
        {
            get { return _sanPhamID; }
            set { _sanPhamID = value; }
        }
    }
}
