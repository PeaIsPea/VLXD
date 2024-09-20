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
    public partial class frmAddArea : Office2007RibbonForm
    {
        KhuVucBLL bll = new KhuVucBLL();
        KhuVuc kv;
        private decimal _id = 0;
        public frmAddArea()
        {
            InitializeComponent();
        }
        public frmAddArea(decimal id)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this._id = id;
            kv = bll.GetListById(id);
            // MessageBox.Show(id.ToString());
            lblId.Text = id.ToString();
            txtKhuVuc.Text = kv.Ten;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtKhuVuc.Text == "")
            {
                MessageBoxEx.Show("Bạn phải nhập vào Khu Vực", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhuVuc.Focus();
            }
            else
            {
                if (lblId.Text == "")
                {
                    KhuVuc kv = new KhuVuc(txtKhuVuc.Text);
                    bll.Insert(kv);
                    MessageBoxEx.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKhuVuc.Clear();
                    this.Close();
                }
                else
                {
                    decimal id = decimal.Parse(lblId.Text);
                    KhuVuc kv = new KhuVuc(id, txtKhuVuc.Text.Trim());
                    bll.Update(kv);
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
