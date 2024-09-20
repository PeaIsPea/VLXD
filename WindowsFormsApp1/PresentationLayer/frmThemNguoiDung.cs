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
using System.Text.RegularExpressions;

namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmThemNguoiDung : Office2007RibbonForm
    {
        NguoiDung nd;
        NguoiDungBLL bll = new NguoiDungBLL();
        private string _u = "";
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }
        public frmThemNguoiDung(string u)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this._u = u;
            nd = bll.GetNguoiDungById(u);

            txtTaiKhoan.Text = u;
            txtMatKhau.Text = nd.MatKhau;
            txtHoTen.Text = nd.HoTen;
            txtEmail.Text = nd.Email;
            txtSoDienThoai.Text = nd.SoDienThoai;
            txtQuyenHan.Text = nd.QuyenHan;
            
            txtTaiKhoan.ReadOnly = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string hoten = txtHoTen.Text;
            string email = txtEmail.Text;
            string phone = txtSoDienThoai.Text;
            string quyenhan = txtQuyenHan.Text;

            if (_u == "")
            {
                nd = new NguoiDung(taikhoan, matkhau, hoten, email, phone, quyenhan);
                if (CheckValidation())
                {
                    try
                    {
                        bll.Insert(nd);
                        MessageBoxEx.Show("Thêm mới thành công!");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        lblMessage.Text = "Người dùng đã tồn tại.";
                        txtTaiKhoan.Focus();
                    }
                }

            }
            else
            {
                nd = new NguoiDung(taikhoan, matkhau, hoten, email, phone, quyenhan);
                if (CheckValidation())
                {
                    bll.Update(nd);
                    MessageBoxEx.Show("Cập nhật thành công!");
                    this.Close();
                }
            }
        }
        private bool CheckValidation()
        {
            bool flag = true;
            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string patternEmail = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            Regex regex = new Regex(patternEmail);
            string phone = txtSoDienThoai.Text.Trim();
            if (tk == "")
            {
                lblMessage.Text = "Bạn phải nhập vào Tài Khoản.";
                flag = false;
                txtTaiKhoan.Focus();
            }
            else if (mk == "")
            {
                lblMessage.Text = "Bạn phải nhập vào Mật Khẩu.";
                flag = false;
                txtMatKhau.Focus();
            }
            else if (!regex.IsMatch(email))
            {
                lblMessage.Text = "Email không hợp lệ.";
                flag = false;
                txtEmail.Focus();
            }
            return flag;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
