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
    public partial class frmCurrency : Office2007RibbonForm
    {
        DVTGiaBLL bll = new DVTGiaBLL();
        public frmCurrency()
        {
            InitializeComponent();
            dgDVTGia.DataSource = bll.LoadDVTGia();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAddCurrency frm = new frmAddCurrency();
            frm.ShowDialog();
            dgDVTGia.DataSource = bll.LoadDVTGia();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgDVTGia.SelectedRows[0].Cells[0].Value;
            frmAddCurrency frm = new frmAddCurrency(id);
 
            frm.ShowDialog();
            dgDVTGia.DataSource = bll.LoadDVTGia();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            decimal id = (decimal)dgDVTGia.SelectedRows[0].Cells[0].Value;
            string name = (string)dgDVTGia.SelectedRows[0].Cells[1].Value;

            DVTGia dvtg = bll.GetListById(id);
            if (MessageBoxEx.Show("Bạn có chắc muốn xóa: " + name + " không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bll.Delete(dvtg))
                {
                    dgDVTGia.DataSource = bll.LoadDVTGia();
                }
                else
                    MessageBoxEx.Show("Có lỗi xảy ra", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
