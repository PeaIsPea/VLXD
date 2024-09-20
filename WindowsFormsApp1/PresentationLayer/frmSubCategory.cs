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
    public partial class frmSubCategory : Office2007RibbonForm
    {
        DanhMucHangBLL dmhBLL = new DanhMucHangBLL();
        LoaiHangBLL bll = new LoaiHangBLL();
        public frmSubCategory()
        {
            InitializeComponent();
            cboDMH.DataSource = dmhBLL.LoadDMH();
            cboDMH.DisplayMember = "TenHang";
            cboDMH.ValueMember = "DanhMucHangID";
            cboDMH.SelectedIndex = -1;

            dgvLoaiHang.DataSource = bll.LoadAll();
        }

        private void cboDMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Hiển thị danh sách Loại Hàng tương ứng
            object value = cboDMH.SelectedValue;

            //dgvLoaiHang.DataSource = LoaiHangBLL.GetLoaiHangByDMH(value);
            dgvLoaiHang.DataSource = bll.LoadDMH(value);
        }
         
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvLoaiHang.DataSource = bll.LoadAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgvLoaiHang.SelectedRows[0].Cells["clLoaiHangID"].Value;
            string name = (string)dgvLoaiHang.SelectedRows[0].Cells["clTenLoaiHang"].Value;
            if (MessageBoxEx.Show("Bạn có muốn xóa: " + name + " không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoaiHang lh = bll.GetByID(id);
                if (bll.Delete(lh))
                {
                    MessageBoxEx.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLoaiHang.DataSource = bll.LoadAll();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddSubCategory frm = new frmAddSubCategory();
            frm.ShowDialog();
            dgvLoaiHang.DataSource = bll.LoadAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmAddSubCategory frm = new frmAddSubCategory((decimal)dgvLoaiHang.SelectedRows[0].Cells["clLoaiHangID"].Value,(decimal)dgvLoaiHang.SelectedRows[0].Cells["clDMH"].Value, (string)dgvLoaiHang.SelectedRows[0].Cells["clTenDMH"].Value);
            frm.ShowDialog();
            dgvLoaiHang.DataSource = bll.LoadAll();
        }
    }
}
