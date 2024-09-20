using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using VatLieuXaydung.Entities;
using VatLieuXaydung.BusinessLayer;
namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmAddSubCategory : Office2007RibbonForm
    {
        LoaiHang lh;
        DanhMucHangBLL bllDMH = new DanhMucHangBLL();
        LoaiHangBLL bllLoaiHang = new LoaiHangBLL();
        private decimal p;
        private decimal idDMH;
        private string dmhID;
        public frmAddSubCategory()
        {
            InitializeComponent();
            cboDMH.DataSource = bllDMH.LoadDMH();
            cboDMH.DisplayMember = "TenHang";
            cboDMH.ValueMember = "DanhMucHangID";
        }
        public frmAddSubCategory(decimal p,decimal idDMH, string dmhID)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.p = p;
            this.idDMH = idDMH;
            this.dmhID = dmhID;
            lh = bllLoaiHang.GetByID(p);
            lblLoaiHangID.Text = p.ToString();
            txtTenLoaiHang.Text = lh.Ten;
            cboDMH.Text = dmhID;        
            
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiHang.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập vào Loại hàng.";
                txtTenLoaiHang.Focus();
            }
            else
            {
                if (lblLoaiHangID.Text == "")
                {
                    try
                    {
                        LoaiHang lh = new LoaiHang(txtTenLoaiHang.Text, (decimal)cboDMH.SelectedValue);
                        if (bllLoaiHang.Insert(lh))
                        {
                            MessageBoxEx.Show("Thêm mới thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Danh Mục Hàng không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    try
                    {

                        //LoaiHang lh = new LoaiHang(p, txtTenLoaiHang.Text, (decimal)cboDMH.SelectedValue);
                        LoaiHang lh = new LoaiHang(p, txtTenLoaiHang.Text, idDMH);
                        if (bllLoaiHang.Update(lh))
                        {
                            MessageBoxEx.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBoxEx.Show("Bạn hãy Làm mới Danh Mục Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cboDMH.DataSource = bllDMH.LoadDMH();
            cboDMH.DisplayMember = "TenHang";
            cboDMH.ValueMember = "DanhMucHangID";
        }
    }
}
