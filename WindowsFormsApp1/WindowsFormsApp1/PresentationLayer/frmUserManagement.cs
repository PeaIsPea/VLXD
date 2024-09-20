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
    public partial class frmUserManagement : Office2007RibbonForm
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungBLL bll = new NguoiDungBLL();
        public frmUserManagement()
        {
            InitializeComponent(); 
            LoadNguoiDung();
        }
        private void LoadNguoiDung()
        {
            grvNguoiDung.DataSource = bll.LoadNguoiDung();

        }

       
 

        

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string taikhoan = (string)grvNguoiDung.SelectedRows[0].Cells["clTaiKhoan"].Value;

            if (taikhoan != null)
            {
                nd = bll.GetNguoiDungById(taikhoan);
                if (MessageBoxEx.Show("Bạn có chắc chắn muốn xóa người dùng: " + nd.HoTen + " không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.Delete(nd);
                    LoadNguoiDung();
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmThemNguoiDung frm = new frmThemNguoiDung();
            frm.ShowDialog();
            LoadNguoiDung();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            frmThemNguoiDung frm = new frmThemNguoiDung((string)grvNguoiDung.SelectedRows[0].Cells["clTaiKhoan"].Value);
            frm.ShowDialog();
            LoadNguoiDung();
        }

      

    }
}
