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
    public partial class frmAddCurrency : Office2007RibbonForm
    {
        DVTGiaBLL bll = new DVTGiaBLL();
        DVTGia dvtg;
        private decimal _id = 0;
        public frmAddCurrency()
        {
            InitializeComponent();
       
        }
        public frmAddCurrency(decimal id)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this._id = id;
            dvtg = bll.GetListById(id);
            // MessageBox.Show(id.ToString());
            lblId.Text = id.ToString();
            txtLoaiTien.Text = dvtg.Loai;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtLoaiTien.Text == "")
            {
                MessageBoxEx.Show("Bạn phải nhập vào Loại Tiền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoaiTien.Focus();
            }
            else
            {
                if (lblId.Text == "")
                {
                    DVTGia dvtg = new DVTGia(txtLoaiTien.Text);
                    bll.Insert(dvtg);
                    MessageBoxEx.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLoaiTien.Clear();
                    this.Close();
                }
                else
                {
                    decimal id = decimal.Parse(lblId.Text);
                    DVTGia dvtg = new DVTGia(id, txtLoaiTien.Text.Trim());
                    bll.Update(dvtg);
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
