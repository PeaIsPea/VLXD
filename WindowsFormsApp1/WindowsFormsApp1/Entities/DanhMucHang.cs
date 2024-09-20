using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VatLieuXaydung.Entities
{
    class DanhMucHang
    {
        private decimal _danhMucHangID;
        private string _tenHang;


        public DanhMucHang(System.Data.DataRow item)
        {
            // TODO: Complete member initialization
            this._danhMucHangID = decimal.Parse(item["DanhMucHangID"].ToString());
            this._tenHang = item["TenHang"].ToString();
        }

        public DanhMucHang()
        {
            // TODO: Complete member initialization
        }

        public DanhMucHang(string tenhang)
        {
            // TODO: Complete member initialization
            this._tenHang = tenhang;
        }

        public DanhMucHang(decimal id, string tenHang)
        {
            this._danhMucHangID = id;
            this._tenHang = tenHang;
        }

        public string TenHang
        {
            get { return _tenHang; }
            set { _tenHang = value; }
        }

        public decimal DanhMucHangID
        {
            get { return _danhMucHangID; }
            set { _danhMucHangID = value; }
        }
    }
}
