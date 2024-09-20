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
    public partial class frmChangeProfile : Office2007RibbonForm
    {
        NguoiDung nd;
        NguoiDungBLL bll = new NguoiDungBLL();
        private string p = "";
        public frmChangeProfile()
        {
            InitializeComponent();
        }
        public frmChangeProfile(string p)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.p = p;
            bll.GetNguoiDungById(p);
            txtTaiKhoan.Text = p;
        }
       
        private bool CheckValidation()
        {
            bool f = true;
            string matKhauHienTai = txtMatKhauHienTai.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string matKhauLapLai = txtLapLaiMatKhau.Text.Trim();
            if (matKhauHienTai=="")
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu hiện tại.";
                txtMatKhauHienTai.Focus();
                f = false;
            }
            else if (matKhauMoi == "")
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu mới.";
                txtMatKhauMoi.Focus();
                f = false;
            }
            else if (matKhauLapLai != matKhauMoi)
            {
                lblMessage.Text = "Mật khẩu lặp lại chưa đúng.";
                txtLapLaiMatKhau.Focus();
                f = false;
            }
            return f;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string matKhauHienTai = txtMatKhauHienTai.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string matKhauLapLai = txtLapLaiMatKhau.Text.Trim();
            string taikhoan = txtTaiKhoan.Text.Trim();
            string kq = bll.KiemTraMatKhau(taikhoan);
            if (matKhauHienTai == kq)
            {
                if (CheckValidation())
                {
                    nd = new NguoiDung(taikhoan, matKhauMoi);
                    bll.DoiMatKhau(nd);
                    MessageBoxEx.Show("Cập nhật mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                lblMessage.Text = "Mật Khẩu Hiện tại sai";
                txtMatKhauHienTai.Focus();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
