using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VatLieuXaydung.Entities
{
    class KhuVuc
    {
        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private decimal _id;
        
        
        

        public KhuVuc(string ten)
        {
            // TODO: Complete member initialization
            this._ten = ten;
        }

        public KhuVuc(System.Data.DataRow item)
        {
            // TODO: Complete member initialization
            this._id = decimal.Parse(item["KhuVucID"].ToString());
            this._ten=item["TenKhuVuc"].ToString();
        }

        public KhuVuc()
        {
            // TODO: Complete member initialization
        }

        public KhuVuc(decimal id, string ten)
        {
            // TODO: Complete member initialization
            this._id = id;
            this._ten = ten;
        }

        public decimal Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
