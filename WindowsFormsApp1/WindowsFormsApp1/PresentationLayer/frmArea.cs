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
    public partial class frmArea : Office2007RibbonForm
    {
        KhuVucBLL bll = new KhuVucBLL();
        public frmArea()
        {
            InitializeComponent();
            dgKhuVuc.DataSource = bll.LoadKhuVuc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgKhuVuc.SelectedRows[0].Cells[0].Value;
            string name = (string)dgKhuVuc.SelectedRows[0].Cells[1].Value;

            KhuVuc kv = bll.GetListById(id);
            if (MessageBoxEx.Show("Bạn có chắc muốn xóa: " + name + " không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bll.Delete(kv))
                {
                    dgKhuVuc.DataSource = bll.LoadKhuVuc();
                }
                else
                    MessageBoxEx.Show("Có lỗi xảy ra", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddArea frm = new frmAddArea();
            frm.ShowDialog();
            dgKhuVuc.DataSource = bll.LoadKhuVuc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgKhuVuc.SelectedRows[0].Cells[0].Value;
            frmAddArea frm = new frmAddArea(id);
            frm.ShowDialog();
            dgKhuVuc.DataSource = bll.LoadKhuVuc();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgKhuVuc.DataSource = bll.LoadKhuVuc();
        }
    }
}
