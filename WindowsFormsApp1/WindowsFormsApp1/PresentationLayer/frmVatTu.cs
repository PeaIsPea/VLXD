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
namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmVatTu : Office2007RibbonForm
    {
        KhuVucBLL kvBLL = new KhuVucBLL();
        LoaiHangBLL lhBLL = new LoaiHangBLL();
        DanhMucHangBLL dmhBLL = new DanhMucHangBLL();
        SanPhamBLL spBLL = new SanPhamBLL();
        GiaBLL giaBLL = new GiaBLL();
        // Page
        private int mintTotalRecords = 0;
        private int mintPageSize = 0;
        private int mintPageCount = 0;
        private int mintCurrentPage = 1;

        public frmVatTu()
        {
            InitializeComponent();

            cboKhuVuc.DataSource = kvBLL.LoadKhuVuc();
            cboKhuVuc.DisplayMember = "TenKhuVuc";
            cboKhuVuc.ValueMember = "KhuVucID";

            dtpFrom.Text = DateTime.Now.ToShortDateString();
            dtpTo.Text = DateTime.Now.ToShortDateString();

            cboDMH.DataSource = dmhBLL.LoadDMH();
            cboDMH.DisplayMember = "TenHang";
            cboDMH.ValueMember = "DanhMucHangID";
            cboDMH.SelectedIndex = -1;

            this.ResizeGridview();

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {

            dgvSanPham.DataSource = spBLL.Reload();
            btnDau.Enabled = false;
            buttonItem1.Enabled = false;
            buttonItem2.Enabled = false;
            btnCuoi.Enabled = false;

            this.ResizeGridview();


        }

        private void fillGrid()
        {
            try
            {
                //For page view           
                this.mintPageSize = int.Parse(tbPageSize.Text);
                this.mintTotalRecords = spBLL.Getcount();
                this.mintPageCount = this.mintTotalRecords / this.mintPageSize;

                if (this.mintTotalRecords % this.mintPageSize > 0)
                {
                    this.mintPageCount++;
                }
                this.mintCurrentPage = 0;
                loadPage();
            }
            catch (Exception)
            {

                MessageBoxEx.Show("Số dòng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadPage()
        {

            int intSkip = 0;
            intSkip = (this.mintCurrentPage * this.mintPageSize);

            dgvSanPham.DataSource = spBLL.Paging(mintPageSize, intSkip);

            this.lblPage.Text = (this.mintCurrentPage + 1).ToString() + " / " + this.mintPageCount.ToString();

        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage = 0;

            loadPage();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (this.mintCurrentPage == this.mintPageCount)
                this.mintCurrentPage = this.mintPageCount - 1;

            this.mintCurrentPage--;
            if (this.mintCurrentPage < 1)
            {
                this.mintCurrentPage = 0;
            }
            loadPage();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage++;
            if (this.mintCurrentPage > this.mintPageCount - 1)
            {
                this.mintCurrentPage = this.mintPageCount - 1;
            }
            loadPage();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage = this.mintPageCount - 1;

            loadPage();
        }

        private void tbPageSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.fillGrid();
                btnDau.Enabled = true;
                buttonItem1.Enabled = true;
                buttonItem2.Enabled = true;
                btnCuoi.Enabled = true;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = spBLL.Reload();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DateTime from = DateTime.Parse(dtpFrom.Text);
            string tu = from.ToString("MM/dd/yyyy");
            DateTime to = DateTime.Parse(dtpTo.Text);
            string den = to.ToString("MM/dd/yyyy");
            decimal kvID = (decimal)cboKhuVuc.SelectedValue;

            dgvSanPham.DataSource = spBLL.SearchByDate(tu, den, kvID);

        }

        private void cboKhuVuc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DateTime from = DateTime.Parse(dtpFrom.Text);
            string tu = from.ToString("MM/dd/yyyy");
            DateTime to = DateTime.Parse(dtpTo.Text);
            string den = to.ToString("MM/dd/yyyy");
            decimal kvID = (decimal)cboKhuVuc.SelectedValue;

            dgvSanPham.DataSource = spBLL.SearchByDate(tu, den, kvID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (radNguon.Checked == true)
            {
                dgvSanPham.DataSource = spBLL.GetByNguonGia(txtSearch.Text);
            }
            else if (radHangSX.Checked == true)
            {
                dgvSanPham.DataSource = spBLL.GetByHangSanXuat(txtSearch.Text);
            }
            else if (radAll.Checked == true)
            {
                string chuoigoc = txtSearch.Text.Trim();
                string[] ketqua = chuoigoc.Split(' ');
                if (ketqua.Length == 1)
                {
                    txtSearch.Text = ketqua[0];
                    dgvSanPham.DataSource = spBLL.GetAll(txtSearch.Text);
                }
                else
                {
                    string chuoi1 = ketqua[0];
                    string chuoi2 = ketqua[1];
                    dgvSanPham.DataSource = spBLL.GetAll(chuoi1, chuoi2);
                    //for (int i = 0; i < ketqua.Length; i++)
                    //{
                    //    txtSearch.Text +=" "+ ketqua[i];
                    //    break;
                    //}
                }


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddVatTu frm = new frmAddVatTu();
            frm.ShowDialog();
            dgvSanPham.DataSource = spBLL.Reload();
            this.ResizeGridview();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal spID = (decimal)dgvSanPham.SelectedRows[0].Cells["clSanPhamID"].Value;
            decimal dmhID = (decimal)dgvSanPham.SelectedRows[0].Cells["clDanhMucHangID"].Value;
            string tenDMH = (string)dgvSanPham.SelectedRows[0].Cells["clTenHang"].Value;
            decimal lhID = (decimal)dgvSanPham.SelectedRows[0].Cells["clLoaiHangID"].Value;
            string tenLH = (string)dgvSanPham.SelectedRows[0].Cells["clTenLoaiHang"].Value;
            decimal kvID = (decimal)dgvSanPham.SelectedRows[0].Cells["clKhuVucID"].Value;
            string kv = (string)dgvSanPham.SelectedRows[0].Cells["clTenKhuVuc"].Value;
            decimal dvtID = (decimal)dgvSanPham.SelectedRows[0].Cells["clDonViTinhID"].Value;
            string dvt = (string)dgvSanPham.SelectedRows[0].Cells["clTenDonViTinh"].Value;

            decimal giaID = (decimal)dgvSanPham.SelectedRows[0].Cells["clGiaID"].Value;
            string nguongia = (string)dgvSanPham.SelectedRows[0].Cells["clNguonGia"].Value;
            decimal gia = (decimal)dgvSanPham.SelectedRows[0].Cells["clGia"].Value;
            decimal loaitienID = (decimal)dgvSanPham.SelectedRows[0].Cells["clDonViTinhGiaID"].Value;
            string loaitien = (string)dgvSanPham.SelectedRows[0].Cells["clLoaiTienTe"].Value;
            bool VAT = (bool)dgvSanPham.SelectedRows[0].Cells["clVAT"].Value;
            DateTime thoidiem = (DateTime)dgvSanPham.SelectedRows[0].Cells["clThoiDiem"].Value;
            frmAddVatTu frm = new frmAddVatTu(spID, tenDMH, tenLH, kv, giaID, nguongia, gia, loaitien, VAT, thoidiem, dvt, dmhID, lhID, kvID, dvtID, loaitienID);
            frm.ShowDialog();
            dgvSanPham.DataSource = spBLL.Reload();
            this.ResizeGridview();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //dgvSanPham.DataSource = spBLL.LoadSanPhamByLoaiHang(txtSearch.Text);
                if (radNguon.Checked == true)
                {
                    dgvSanPham.DataSource = spBLL.GetByNguonGia(txtSearch.Text);
                }
                else if (radHangSX.Checked == true)
                {
                    dgvSanPham.DataSource = spBLL.GetByHangSanXuat(txtSearch.Text);
                }
                else if (radAll.Checked == true)
                {
                    string chuoigoc = txtSearch.Text.Trim();
                    string[] ketqua = chuoigoc.Split(' ');
                    for (int i = 0; i < ketqua.Length; i++)
                    {
                        if (ketqua.Length == 1)
                        {
                            txtSearch.Text = ketqua[i];
                        }
                        else
                            txtSearch.Text += ketqua[i];
                    }

                    //string chuoi1 = ketqua[0];
                    //string chuoi2 = ketqua[1];
                    //dgvSanPham.DataSource = spBLL.GetAll(chuoi1,chuoi2);
                    dgvSanPham.DataSource = spBLL.GetAll(txtSearch.Text);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            decimal spID = (decimal)dgvSanPham.SelectedRows[0].Cells["clSanPhamID"].Value;
            string tenDMH = (string)dgvSanPham.SelectedRows[0].Cells["clTenHang"].Value;
            string tenLH = (string)dgvSanPham.SelectedRows[0].Cells["clTenLoaiHang"].Value;
            if (MessageBox.Show("Bạn có muốn xóa: " + tenDMH + " " + tenLH + " không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SanPham sp = spBLL.GetSanPhamByID(spID);
                
                if (spBLL.Delete(sp) && giaBLL.Delete(spID))
                {
                    MessageBoxEx.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSanPham.DataSource = spBLL.Reload();
                    this.ResizeGridview();
                }
            }
        }

        private void cboDMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object value = cboDMH.SelectedValue;
            dgvSanPham.DataSource = spBLL.GetByDMH(value);
        }

        private void dgvSanPham_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //TextBox txt = (TextBox)e.Control;
            //txt.Multiline = true;


        }

        private void ResizeGridview()
        {
            dgvSanPham.Columns["clSanPhamID"].Width = 250;
            dgvSanPham.Columns["clSanPhamID"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clTenLoaiHang"].Width = 250;
            dgvSanPham.Columns["clTenLoaiHang"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clTenHang"].Width = 250;
            dgvSanPham.Columns["clTenHang"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clHangSanXuat"].Width = 250;
            dgvSanPham.Columns["clHangSanXuat"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clModel"].Width = 250;
            dgvSanPham.Columns["clModel"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clDiemGiaoHang"].Width = 250;
            dgvSanPham.Columns["clDiemGiaoHang"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            dgvSanPham.Columns["clThongSoKhac"].Width = 250;
            dgvSanPham.Columns["clThongSoKhac"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clTenKhuVuc"].Width = 250;
            dgvSanPham.Columns["clTenKhuVuc"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clNguonGia"].Width = 250;
            dgvSanPham.Columns["clNguonGia"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clGia"].Width = 250;
            dgvSanPham.Columns["clGia"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clLoaiTienTe"].Width = 250;
            dgvSanPham.Columns["clLoaiTienTe"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clVAT"].Width = 250;
            dgvSanPham.Columns["clVAT"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clThoiDiem"].Width = 250;
            dgvSanPham.Columns["clThoiDiem"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.Columns["clTenDonViTinh"].Width = 250;
            dgvSanPham.Columns["clTenDonViTinh"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }



    }
}
