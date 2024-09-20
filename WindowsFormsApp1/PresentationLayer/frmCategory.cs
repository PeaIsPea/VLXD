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
    public partial class frmCategory : Office2007RibbonForm
    {

        private int mintTotalRecords = 0;
        private int mintPageSize = 0;
        private int mintPageCount = 0;
        private int mintCurrentPage = 1;

        DanhMucHangBLL bll = new DanhMucHangBLL();
        public frmCategory()
        {
            InitializeComponent();            
        }



        private void frmCategory_Load(object sender, EventArgs e)
        {
            //this.fillGrid();            
            dgDanhMucHang.DataSource = DanhMucHangBLL.GetList();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.fillGrid();
           
        }
        private void fillGrid()
        {
            try
            {
                //For page view           
                this.mintPageSize = int.Parse(tbPageSize.Text);
                this.mintTotalRecords = bll.Getcount();
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

                MessageBox.Show("Số dòng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadPage()
        {

            int intSkip = 0;
            intSkip = (this.mintCurrentPage * this.mintPageSize);

            dgDanhMucHang.DataSource = bll.Paging(mintPageSize, intSkip);

            this.lblPage.Text = (this.mintCurrentPage + 1).ToString() + " / " + this.mintPageCount.ToString();

        }

       

        private void btnDau_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage = 0;

            loadPage();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage = this.mintPageCount - 1;

            loadPage();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage = 0;

            loadPage();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.mintCurrentPage = this.mintPageCount - 1;

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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgDanhMucHang.DataSource = DanhMucHangBLL.GetDanhMucHangByName(txtSearch.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgDanhMucHang.DataSource = DanhMucHangBLL.GetDanhMucHangByName(txtSearch.Text);
        }

        private void tbPageSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.fillGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgDanhMucHang.DataSource = DanhMucHangBLL.GetList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddDMH frm = new frmAddDMH();
            frm.ShowDialog();
            frmCategory_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgDanhMucHang.SelectedRows[0].Cells["clDanhMucHangID"].Value;
            frmAddDMH frm = new frmAddDMH(id);

            //DanhMucHang dmh = new DanhMucHang(id, txtTenHang.Text.Trim());
            //bll.Update(dmh);
            //MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
            frm.ShowDialog();
            frmCategory_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgDanhMucHang.SelectedRows[0].Cells["clDanhMucHangID"].Value;
            string name = (string)dgDanhMucHang.SelectedRows[0].Cells["clTenHang"].Value;

            DanhMucHang dmh = bll.GetDanhMucHangById(id);

            if (MessageBoxEx.Show("Bạn có chắc muốn xóa: " + name + " không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bll.Delete(dmh))
                {
                    frmCategory_Load(sender, e);
                }
                else
                    MessageBoxEx.Show("Có lỗi xảy ra", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
 
    }
}
