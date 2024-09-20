using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VatLieuXaydung.Entities
{
    class Gia
    {
        private decimal giaID;
        private string nguonGia;
        private decimal gia;
        private DateTime thoidiem;
        private decimal spID;
        private decimal dvtGiaID;
        private bool VAT;
        

        public bool VAT1
        {
            get { return VAT; }
            set { VAT = value; }
        }

        public decimal DvtGiaID
        {
            get { return dvtGiaID; }
            set { dvtGiaID = value; }
        }

        

        public decimal SpID
        {
            get { return spID; }
            set { spID = value; }
        }

        public DateTime Thoidiem
        {
            get { return thoidiem; }
            set { thoidiem = value; }
        }

        public decimal Gia1
        {
            get { return gia; }
            set { gia = value; }
        }

        public string NguonGia
        {
            get { return nguonGia; }
            set { nguonGia = value; }
        }

        public decimal GiaID
        {
            get { return giaID; }
            set { giaID = value; }
        }

        public Gia(string nguongia, decimal gia, DateTime thoidiem, decimal dvtgID, bool vat)
        {
            this.nguonGia = nguongia;
            this.gia = gia;
            this.thoidiem = thoidiem;
            this.dvtGiaID = dvtgID;
            this.VAT = vat;
        }

        public Gia(decimal giaID,string nguongia, decimal gia, DateTime thoidiem,decimal spID, decimal dvtgID, bool vat)
        {
            this.giaID = giaID;
            this.nguonGia = nguongia;
            this.gia = gia;
            this.thoidiem = thoidiem;
            this.spID = spID;
            this.dvtGiaID = dvtgID;
            this.VAT = vat;
        }
        public Gia()
        {
            // TODO: Complete member initialization
        }

        public Gia(System.Data.DataRow item)
        {
            // TODO: Complete member initialization
            this.giaID = decimal.Parse(item["GiaID"].ToString());
            this.nguonGia=item["NguonGia"].ToString();
            this.gia = decimal.Parse(item["Gia"].ToString());
            this.thoidiem = DateTime.Parse(item["ThoiDiem"].ToString());
            this.spID = decimal.Parse(item["SanPhamID"].ToString());
            this.dvtGiaID = decimal.Parse(item["DonViTinhGiaID"].ToString());
            this.VAT = bool.Parse(item["VAT"].ToString());
        }
    }
}
