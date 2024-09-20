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
    public partial class frmUnit : Office2007RibbonForm
    {
        DonViTinhBLL bll = new DonViTinhBLL();
        public frmUnit()
        {
            InitializeComponent();
            dgDonVitinh.DataSource = bll.LoadDVT();           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddUnit frm = new frmAddUnit();
            frm.ShowDialog();
            dgDonVitinh.DataSource = bll.LoadDVT();           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgDonVitinh.SelectedRows[0].Cells["clDonViTinhID"].Value;
            frmAddUnit frm = new frmAddUnit(id); 
            frm.ShowDialog();
            dgDonVitinh.DataSource = bll.LoadDVT();           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgDonVitinh.SelectedRows[0].Cells["clDonViTinhID"].Value;
            string name = (string)dgDonVitinh.SelectedRows[0].Cells["clTenDonVi"].Value;

            DonViTinh dvt = bll.GetListById(id);

            if (MessageBoxEx.Show("Bạn có chắc muốn xóa: " + name + " không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bll.Delete(dvt))
                {
                    dgDonVitinh.DataSource = bll.LoadDVT();        
                }
                else
                    MessageBoxEx.Show("Có lỗi xảy ra", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgDonVitinh.DataSource = bll.LoadDVT();      
        }
    }
}
