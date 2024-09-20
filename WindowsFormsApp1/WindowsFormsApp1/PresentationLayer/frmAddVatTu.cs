using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using VatLieuXaydung.BusinessLayer;
using VatLieuXaydung.Entities;
using System.Text.RegularExpressions;

namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmAddVatTu : Office2007RibbonForm
    {
        Gia g = new Gia();
        SanPham sp = new SanPham();
        DonViTinhBLL dvtBLL = new DonViTinhBLL();
        KhuVucBLL kvBLL = new KhuVucBLL();
        SanPhamBLL spBLL = new SanPhamBLL();
        DanhMucHangBLL dmhBLL = new DanhMucHangBLL();
        LoaiHangBLL lhBLL = new LoaiHangBLL();
        GiaBLL giaBLL = new GiaBLL();
        DVTGiaBLL dvtgBLL = new DVTGiaBLL();
        private decimal id;
        private string tenDMH;
        private string tenLH;
        private string kv;
        private string dvt;
        private string nguongia;
        private decimal giaID;
        private decimal gia;
        private string loaitien;
        private bool VAT;
        private decimal dmhID;
        private decimal lhID;
        private decimal kvID;
        private decimal dvtID;
        private decimal loaitienID;
        DateTime thoidiem;

        public frmAddVatTu()
        {
            InitializeComponent();

            cboDMH.DataSource = dmhBLL.LoadDMH();
            cboDMH.DisplayMember = "TenHang";
            cboDMH.ValueMember = "DanhMucHangID";
            cboDMH.SelectedIndex = -1;

            cboKV.DataSource = kvBLL.LoadKhuVuc();
            cboKV.DisplayMember = "TenKhuVuc";
            cboKV.ValueMember = "KhuVucID";
            cboKV.SelectedIndex = -1;

            cboDVT.DataSource = dvtBLL.LoadDVT();
            cboDVT.DisplayMember = "TenDonViTinh";
            cboDVT.ValueMember = "DonViTinhID";
            cboDVT.SelectedIndex = -1;

            cboLoaiTien.DataSource = dvtgBLL.LoadDVTGia();
            cboLoaiTien.DisplayMember = "LoaiTienTe";
            cboLoaiTien.ValueMember = "DonViTinhGiaID";
            cboLoaiTien.SelectedIndex = -1;

            dtpThoiDiem.Text = DateTime.Now.ToShortDateString();

            dgvGiaSanPham.Visible = false;
        }

        public frmAddVatTu(decimal id, string dmh, string lh, string kv, decimal giaID, string nguongia, decimal gia, string loaitien, bool VAT, DateTime thoidiem, string dvt, decimal dmhID, decimal lhID, decimal kvID, decimal dvtID, decimal loaitienID)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            dgvGiaSanPham.Visible = false;
            this.id = id;
            this.tenDMH = dmh;
            this.tenLH = lh;
            this.kv = kv;
            this.dvt = dvt;
            this.giaID = giaID;
            this.nguongia = nguongia;
            this.gia = gia;
            this.loaitien = loaitien;
            this.VAT = VAT;
            this.thoidiem = thoidiem;

            this.dmhID = dmhID;
            this.lhID = lhID;
            this.kvID = kvID;
            this.dvtID = dvtID;
            this.loaitienID = loaitienID;

            sp = spBLL.GetSanPhamByID(id);
            lblSPID.Text = id.ToString();
            cboDMH.Text = dmh;
            cboLH.Text = lh;
            cboKV.Text = kv;
            cboDVT.Text = dvt;
            txtHSX.Text = sp.HangSanXuat;
            txtModel.Text = sp.Model;
            txtDGH.Text = sp.DiemGiaoHang;
            txtTSK.Text = sp.ThongSoKhac;

            g = giaBLL.GetByID(giaID);
            lblGiaID.Text = giaID.ToString();
            txtNguon.Text = nguongia;
            txtGia.Text = gia.ToString();
            cboLoaiTien.Text = loaitien;
            chkVAT.Checked = VAT;
            dtpThoiDiem.Text = thoidiem.ToShortDateString();

            btnReset.Visible = false;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboLH.DataSource = lhBLL.LoadDMH(cboDMH.SelectedValue);
            cboLH.DisplayMember = "TenLoaiHang";
            cboLH.ValueMember = "LoaiHangID";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string giaPattern = "^[0-9]+$";
            //Regex regex = new Regex(giaPattern);
            //if (cboDMH.SelectedIndex == -1)
            //{
            //    lblMessage.Text = "Bạn chưa chọn Danh Mục Hàng.";
            //}
            //else if (cboKV.SelectedIndex == -1)
            //{
            //    lblMessage.Text = "Bạn chưa chọn Khu Vực.";
            //}
            //else if (cboDVT.SelectedIndex == -1)
            //{
            //    lblMessage.Text = "Bạn chưa chọn Đơn Vị Tính.";
            //}
            //else if (txtNguon.Text == "")
            //{
            //    lblMessage.Text = "Bạn chưa nhập Nguồn Giá.";
            //    txtNguon.Focus();
            //}
            //else if (txtGia.Text == "")
            //{
            //    lblMessage.Text = "Bạn chưa nhập Giá.";
            //    txtGia.Focus();
            //}

            //else if (!regex.IsMatch(txtGia.Text))
            //{
            //    lblMessage.Text = "Giá không hợp lệ.";
            //    txtGia.Focus();
            //}
            //else if (cboLoaiTien.SelectedIndex == -1)
            //{
            //    lblMessage.Text = "Bạn chưa chọn Loại tiền.";
            //}
            //else
            //{ }
            //Lưu sản phẩm mới
            if (lblSPID.Text == "")
            {
                string giaPattern = "^[0-9]+$";
                Regex regex = new Regex(giaPattern);
                if (cboDMH.SelectedIndex == -1)
                {
                    lblMessage.Text = "Bạn chưa chọn Danh Mục Hàng.";
                }
                else if (cboKV.SelectedIndex == -1)
                {
                    lblMessage.Text = "Bạn chưa chọn Khu Vực.";
                }
                else if (cboDVT.SelectedIndex == -1)
                {
                    lblMessage.Text = "Bạn chưa chọn Đơn Vị Tính.";
                }
                else if (txtNguon.Text == "")
                {
                    lblMessage.Text = "Bạn chưa nhập Nguồn Giá.";
                    txtNguon.Focus();
                }
                else if (txtGia.Text == "")
                {
                    lblMessage.Text = "Bạn chưa nhập Giá.";
                    txtGia.Focus();
                }

                else if (!regex.IsMatch(txtGia.Text))
                {
                    lblMessage.Text = "Giá không hợp lệ.";
                    txtGia.Focus();
                }
                else if (cboLoaiTien.SelectedIndex == -1)
                {
                    lblMessage.Text = "Bạn chưa chọn Loại tiền.";
                }
                else
                {

                    lblMessage.Text = "";
                    SanPham sp = new SanPham((decimal)cboKV.SelectedValue, (decimal)cboDVT.SelectedValue, (decimal)cboLH.SelectedValue, txtHSX.Text, txtModel.Text, txtDGH.Text, txtTSK.Text);
                    bool check = false;
                    if (chkVAT.Checked)
                        check = true;
                    else
                        check = false;
                    decimal gia = decimal.Parse(txtGia.Text);
                    DateTime thoidiem1 = DateTime.Parse(dtpThoiDiem.Text);
                 
                    bool co = spBLL.Insert(sp);
                    Gia g = new Gia(txtNguon.Text, gia, thoidiem1, (decimal)cboLoaiTien.SelectedValue, check);
                  
                    if (co && giaBLL.Insert(g))
                    {
                        MessageBoxEx.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvGiaSanPham.Visible = true;
                        dgvGiaSanPham.DataSource = giaBLL.LoadAll();

                    }
                }
            }
            //cập nhật sản phẩm
            else
            {

                lblMessage.Text = "";
                bool check = false;
                if (chkVAT.Checked) check = true;
                else check = false;
                //SanPham sp = new SanPham(id, (decimal)cboKV.SelectedValue, (decimal)cboDVT.SelectedValue, (decimal)cboLH.SelectedValue, txtHSX.Text, txtModel.Text, txtDGH.Text, txtTSK.Text);
                SanPham sp = new SanPham(id, kvID, dvtID, lhID, txtHSX.Text, txtModel.Text, txtDGH.Text, txtTSK.Text);
                //Gia g = new Gia(decimal.Parse(lblGiaID.Text), txtNguon.Text, decimal.Parse(txtGia.Text), DateTime.Parse(dtpThoiDiem.Text), decimal.Parse(lblSPID.Text), (decimal)cboLoaiTien.SelectedValue, check);
                Gia g = new Gia(decimal.Parse(lblGiaID.Text), txtNguon.Text, decimal.Parse(txtGia.Text), DateTime.Parse(dtpThoiDiem.Text), decimal.Parse(lblSPID.Text), loaitienID, check);
                spBLL.Update(sp);
                giaBLL.Update(g);
                MessageBoxEx.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvGiaSanPham.Visible = true;
                dgvGiaSanPham.DataSource = giaBLL.LoadAll();
            }



        }

        private void frmAddVatTu_Load(object sender, EventArgs e)
        {

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            cboDMH.Text = "";
            cboLH.Text = "";
            cboKV.Text = "";
            cboDVT.Text = "";
            cboDMH.SelectedIndex = -1;
            cboLH.SelectedIndex = -1;
            cboKV.SelectedIndex = -1;
            cboDVT.SelectedIndex = -1;
            lblMessage.Text = "";
            txtDGH.Text = "";
            txtHSX.Text = "";
            txtModel.Text = "";
            txtTSK.Text = "";

            txtNguon.Text = "";
            txtGia.Text = "";
            dtpThoiDiem.Text = "";
            cboLoaiTien.SelectedIndex = -1;
            cboLoaiTien.Text = "";

            cboDMH.DataSource = dmhBLL.LoadDMH();
            cboDMH.DisplayMember = "TenHang";
            cboDMH.ValueMember = "DanhMucHangID";
            cboDMH.SelectedIndex = -1;

            cboKV.DataSource = kvBLL.LoadKhuVuc();
            cboKV.DisplayMember = "TenKhuVuc";
            cboKV.ValueMember = "KhuVucID";
            cboKV.SelectedIndex = -1;

            cboDVT.DataSource = dvtBLL.LoadDVT();
            cboDVT.DisplayMember = "TenDonViTinh";
            cboDVT.ValueMember = "DonViTinhID";
            cboDVT.SelectedIndex = -1;

            cboLoaiTien.DataSource = dvtgBLL.LoadDVTGia();
            cboLoaiTien.DisplayMember = "LoaiTienTe";
            cboLoaiTien.ValueMember = "DonViTinhGiaID";
            cboLoaiTien.SelectedIndex = -1;

        }

        //private void dgvGiaSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        txtNguon.Text = Convert.ToString(dgvGiaSanPham.CurrentRow.Cells["clNguonGia"].Value);
        //    }

        //}
    }
}
