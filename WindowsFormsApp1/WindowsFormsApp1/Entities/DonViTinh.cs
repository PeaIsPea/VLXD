using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VatLieuXaydung.Entities
{
    class DonViTinh
    {
        private decimal _id;
        private string _ten;
        
        

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        public decimal Id
        {
            get { return _id; }
            set { _id = value; }
        }
        

        public DonViTinh(string ten)
        {
            // TODO: Complete member initialization
            this._ten = ten;
        }

        public DonViTinh(System.Data.DataRow item)
        {
            // TODO: Complete member initialization
            this._id = decimal.Parse(item["DonViTinhID"].ToString());
            this._ten = item["TenDonViTinh"].ToString();
        }

        public DonViTinh()
        {
            // TODO: Complete member initialization
        }

        public DonViTinh(decimal id, string ten)
        {
            // TODO: Complete member initialization
            this._id = id;
            this._ten = ten;
        }

    }
}
