namespace VatLieuXaydung.PresentationLayer
{
    partial class frmChangeProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeProfile));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lblMessage = new DevComponents.DotNetBar.LabelX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.txtLapLaiMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMatKhauMoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMatKhauHienTai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.Controls.Add(this.lblMessage);
            this.panelEx1.Controls.Add(this.btnLuu);
            this.panelEx1.Controls.Add(this.txtLapLaiMatKhau);
            this.panelEx1.Controls.Add(this.txtMatKhauMoi);
            this.panelEx1.Controls.Add(this.txtMatKhauHienTai);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.txtTaiKhoan);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(4, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(501, 250);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(189, 215);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(286, 23);
            this.lblMessage.TabIndex = 22;
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(189, 182);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // txtLapLaiMatKhau
            // 
            // 
            // 
            // 
            this.txtLapLaiMatKhau.Border.Class = "TextBoxBorder";
            this.txtLapLaiMatKhau.Location = new System.Drawing.Point(311, 143);
            this.txtLapLaiMatKhau.Name = "txtLapLaiMatKhau";
            this.txtLapLaiMatKhau.PasswordChar = '|';
            this.txtLapLaiMatKhau.Size = new System.Drawing.Size(164, 20);
            this.txtLapLaiMatKhau.TabIndex = 20;
            // 
            // txtMatKhauMoi
            // 
            // 
            // 
            // 
            this.txtMatKhauMoi.Border.Class = "TextBoxBorder";
            this.txtMatKhauMoi.Location = new System.Drawing.Point(311, 105);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '|';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(164, 20);
            this.txtMatKhauMoi.TabIndex = 19;
            // 
            // txtMatKhauHienTai
            // 
            // 
            // 
            // 
            this.txtMatKhauHienTai.Border.Class = "TextBoxBorder";
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(311, 69);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.PasswordChar = '|';
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(164, 20);
            this.txtMatKhauHienTai.TabIndex = 18;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(189, 143);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(102, 23);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "Lặp lại mật khẩu:";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(189, 103);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(102, 23);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "Mật khẩu mới:";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(189, 67);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(102, 23);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "Mật khẩu hiện tại:";
            // 
            // txtTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTaiKhoan.Border.Class = "TextBoxBorder";
            this.txtTaiKhoan.Location = new System.Drawing.Point(311, 32);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(164, 20);
            this.txtTaiKhoan.TabIndex = 14;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(189, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(102, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Tài Khoản:";
            // 
            // labelX1
            // 
            this.labelX1.Image = ((System.Drawing.Image)(resources.GetObject("labelX1.Image")));
            this.labelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.labelX1.Location = new System.Drawing.Point(25, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(129, 129);
            this.labelX1.TabIndex = 12;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.Location = new System.Drawing.Point(279, 182);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 23;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmChangeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 253);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmChangeProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lblMessage;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLapLaiMatKhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhauMoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhauHienTai;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTaiKhoan;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;

    }
}