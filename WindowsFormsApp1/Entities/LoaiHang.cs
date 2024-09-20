using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VatLieuXaydung.Entities
{
    class LoaiHang
    {
        private decimal _loaiHangID;

        public decimal LoaiHangID
        {
            get { return _loaiHangID; }
            set { _loaiHangID = value; }
        }

        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        private decimal _dmhID;
     
        

        public LoaiHang(System.Data.DataRow item)
        {
            // TODO: Complete member initialization
            this._loaiHangID = decimal.Parse(item["LoaiHangID"].ToString());
            this._ten=item["TenLoaiHang"].ToString();
            this._dmhID = decimal.Parse(item["DanhMucHangID"].ToString());
        }

        public LoaiHang(string ten, decimal dmhID)
        {
            // TODO: Complete member initialization
            this._ten = ten;
            this._dmhID = dmhID;
        }

        public LoaiHang()
        {
            // TODO: Complete member initialization
        }

        public LoaiHang(decimal id,string ten, decimal dmhID)
        {
            // TODO: Complete member initialization
            this._loaiHangID = id;
            this._ten = ten;
            this._dmhID = dmhID;
        }

        public decimal DmhID
        {
            get { return _dmhID; }
            set { _dmhID = value; }
        }
    }
}
