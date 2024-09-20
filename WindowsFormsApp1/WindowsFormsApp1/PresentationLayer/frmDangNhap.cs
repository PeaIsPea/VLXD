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
    public partial class frmDangNhap : Office2007RibbonForm
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungBLL bll = new NguoiDungBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtTaiKhoan.Text;
                string pwd = txtMatKhau.Text;
                string role = bll.GetRole(username);
                int result = bll.DangNhap(username, pwd);
                if (result == 1)
                {
                    lblMessage.Text = "";
                    frmHome home = new frmHome(username);
                  //  frmMain main = new frmMain(username);
                    if (role.Trim() == "Khach")
                    {
                        MessageBoxEx.Show("Bạn đăng nhập quyền:" + role, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Bạn đăng nhập quyền:" + role, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // home.DisableQuanTriNguoiDung();
                       // home.DisableQuanLy();
                       // home.DisableNhapLieu();
                        home.Show();
                        this.Hide();
                    }
                    else if (role.Trim() == "NhapLieu")
                    {
                        MessageBoxEx.Show("Bạn đăng nhập quyền:" + role, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      //  main.DisableQuanLy();
                       // main.DisableQuanTriNguoiDung();
                        home.Show();
                        this.Hide();
                    }
                    else if (role.Trim() == "Admin")
                    {
                        MessageBoxEx.Show("Bạn đăng nhập quyền:" + role, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBoxEx.Show("Người dùng: " + username + " không có quyền truy cập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    lblMessage.Text = "Sai Tài Khoản hoặc Mật Khẩu.";
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    txtTaiKhoan.Focus();
                }
            }
            catch (Exception)
            {
                lblMessage.Text = "Sai Tài Khoản hoặc Mật Khẩu.";
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                  try
            {
                string username = txtTaiKhoan.Text;
                string pwd = txtMatKhau.Text;
                string role = bll.GetRole(username);
                int result = bll.DangNhap(username, pwd);
                if (result == 1)
                {
                    lblMessage.Text = "";
                    frmHome home = new frmHome(username);
                    //  frmMain main = new frmMain(username);
                    if (role.Trim() == "Khach")
                    {
                        MessageBoxEx.Show("Bạn đăng nhập quyền:" + role, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Bạn đăng nhập quyền:" + role, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // home.DisableQuanTriNguoiDung();
                        // home.DisableQuanLy();
                        // home.DisableNhapLieu();
                        home.Show();
                        this.Hide();
                    }
                    else if (role.Trim() == "NhapLieu")
                    {
                        MessageBoxEx.Show("Bạn đăng nhập quyền:" + role, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  main.DisableQuanLy();
                        // main.DisableQuanTriNguoiDung();
                        home.Show();
                        this.Hide();
                    }
                    else if (role.Trim() == "Admin")
                    {
                        MessageBoxEx.Show("Bạn đăng nhập quyền:" + role, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBoxEx.Show("Người dùng: " + username + " không có quyền truy cập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    lblMessage.Text = "Sai Tài Khoản hoặc Mật Khẩu.";
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    txtTaiKhoan.Focus();
                }
            }
            catch (Exception)
            {
                lblMessage.Text = "Sai Tài Khoản hoặc Mật Khẩu.";
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }
            }
        }

       

        

        
         
    }
}
