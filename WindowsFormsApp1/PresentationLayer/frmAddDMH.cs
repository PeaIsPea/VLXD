using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VatLieuXaydung.BusinessLayer;
using VatLieuXaydung.Entities;
using DevComponents.DotNetBar;

namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmAddDMH : Office2007RibbonForm
    {
        DanhMucHangBLL bll = new DanhMucHangBLL();
        DanhMucHang dmh;
        private decimal _id = 0;
        public frmAddDMH()
        {
            InitializeComponent();
        }
        public frmAddDMH(decimal id)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this._id = id;
            dmh = bll.GetDanhMucHangById(id);
            // MessageBox.Show(id.ToString());
            lblId.Text = id.ToString();
            txtTenHang.Text = dmh.TenHang;
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenHang.Text == "")
            {
                MessageBoxEx.Show("Bạn phải nhập vào Tên Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
            }
            else
            {
                if (lblId.Text=="")
                {
                    DanhMucHang dmh = new DanhMucHang(txtTenHang.Text);
                    bll.Insert(dmh);
                    MessageBoxEx.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenHang.Clear();
                    this.Close();
                }
                else
                {
                    decimal id = decimal.Parse(lblId.Text);
                    DanhMucHang dmh = new DanhMucHang(id, txtTenHang.Text.Trim());
                    bll.Update(dmh);
                    MessageBoxEx.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
        }
    }
}
