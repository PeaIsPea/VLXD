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
    public partial class frmAddUnit : Office2007RibbonForm
    {
        DonViTinh dvt;
        DonViTinhBLL dvtBLL = new DonViTinhBLL();
        private decimal _id = 0;
        public frmAddUnit()
        {
            InitializeComponent();
        }
        public frmAddUnit(decimal id)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this._id = id;
            dvt = dvtBLL.GetListById(id);
            // MessageBox.Show(id.ToString());
            lblId.Text = id.ToString();
            txtDVT.Text = dvt.Ten;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDVT.Text == "")
            {
                MessageBoxEx.Show("Bạn phải nhập vào Đơn vị tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDVT.Focus();
            }
            else
            {
                if (lblId.Text == "")
                {
                    DonViTinh dvt = new DonViTinh(txtDVT.Text);
                    dvtBLL.Insert(dvt);
                    MessageBoxEx.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDVT.Clear();
                    this.Close();
                }
                else
                {
                    decimal id = decimal.Parse(lblId.Text);
                    DonViTinh dvt = new DonViTinh(id, txtDVT.Text.Trim());
                    dvtBLL.Update(dvt);
                    MessageBoxEx.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
