using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace VatLieuXaydung.PresentationLayer
{
    public partial class frmHome : Office2007RibbonForm
    {
        //private string username;

        public frmHome()
        {
            InitializeComponent();
        }

        public frmHome(string username)
        {
            InitializeComponent();
            lblMessage.Text = "Chào: ";
            lblTaiKhoan.Text = username;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = new System.Windows.Forms.DialogResult();
            result = MessageBoxEx.Show("Bạn có chắc chắn muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Danh Sách Người Dùng"))
            {
                TabItem t = tabControl1.CreateTab("Danh Sách Người Dùng");
                //frmQuanTriNguoiDung frm = new frmQuanTriNguoiDung();
                frmUserManagement frm = new frmUserManagement();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmChangeProfile frm = new frmChangeProfile(lblTaiKhoan.Text);
            frm.ShowDialog();
            //if (!CheckOpenTabs("Đổi Mật Khẩu"))
            //{
            //    TabItem t = tabControl1.CreateTab("Đổi Mật Khẩu");
            //    frmChangeProfile frm = new frmChangeProfile(lblTaiKhoan.Text);
            //    frm.TopLevel = false;
            //    frm.Dock = DockStyle.Fill;
            //    frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //    t.AttachedControl.Controls.Add(frm);
            //    frm.Show();
            //    tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            //}
            //else
            //    tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        public bool CheckOpenTabs(string name)
        {
            for (int i = 0; i < tabControl1.Tabs.Count; i++)
            {
                if (tabControl1.Tabs[i].Text==name)
                {
                    tabControl1.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }

        private void btnDanhMucHang_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Danh Mục Hàng"))
            {
                TabItem t = tabControl1.CreateTab("Danh Mục Hàng");
                frmCategory frm = new frmCategory();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Loại Hàng"))
            {
                TabItem t = tabControl1.CreateTab("Loại Hàng");
                frmSubCategory frm = new frmSubCategory();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void btnDonViTinh_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Đơn Vị Tính"))
            {
                TabItem t = tabControl1.CreateTab("Đơn Vị Tính");
                frmUnit frm = new frmUnit();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Khu Vực"))
            {
                TabItem t = tabControl1.CreateTab("Khu Vực");
                frmArea frm = new frmArea();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void btnTienTe_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Loại Tiền"))
            {
                TabItem t = tabControl1.CreateTab("Loại Tiền");
                frmCurrency frm = new frmCurrency();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Vật Tư"))
            {
                TabItem t = tabControl1.CreateTab("Vật Tư");
                frmVatTu frm = new frmVatTu();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }
    }
}
