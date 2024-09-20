using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VatLieuXaydung.Entities
{
    class DVTGia
    {
        private decimal _id;
        private string _loai;     
              

        public DVTGia(string loai)
        {
            // TODO: Complete member initialization
            this._loai = loai;
        }

        public DVTGia(decimal id, string loai)
        {
            // TODO: Complete member initialization
            this._id = id;
            this._loai = loai;
            
        }

        public DVTGia()
        {
            // TODO: Complete member initialization
        }

        public DVTGia(System.Data.DataRow item)
        {
            // TODO: Complete member initialization
            this._id = decimal.Parse(item["DonViTinhGiaID"].ToString());
            this._loai = item["LoaiTienTe"].ToString();
        }

        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }

        public decimal Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
