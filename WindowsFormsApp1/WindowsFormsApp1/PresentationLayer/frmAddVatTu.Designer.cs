namespace VatLieuXaydung.PresentationLayer
{
    partial class frmAddVatTu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddVatTu));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvGiaSanPham = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblGiaID = new DevComponents.DotNetBar.LabelX();
            this.lblSPID = new DevComponents.DotNetBar.LabelX();
            this.lblMessage = new DevComponents.DotNetBar.LabelX();
            this.chkVAT = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cboLoaiTien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtpThoiDiem = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNguon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTSK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDGH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHSX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboDVT = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboKV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboLH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboDMH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.clGiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSanPhamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDanhMucHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinhGiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiTienTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVAT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clThoiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSanPham)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpThoiDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.dgvGiaSanPham);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(4, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(944, 593);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // dgvGiaSanPham
            // 
            this.dgvGiaSanPham.AllowUserToAddRows = false;
            this.dgvGiaSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGiaID,
            this.clSanPhamID,
            this.clDanhMucHangID,
            this.clTenHang,
            this.clLoaiHangID,
            this.clTenLoaiHang,
            this.clNguonGia,
            this.clGia,
            this.clDonViTinhGiaID,
            this.clLoaiTienTe,
            this.clVAT,
            this.clThoiDiem});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaSanPham.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGiaSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvGiaSanPham.Location = new System.Drawing.Point(0, 401);
            this.dgvGiaSanPham.Name = "dgvGiaSanPham";
            this.dgvGiaSanPham.ReadOnly = true;
            this.dgvGiaSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaSanPham.Size = new System.Drawing.Size(944, 192);
            this.dgvGiaSanPham.TabIndex = 12;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblGiaID);
            this.groupPanel1.Controls.Add(this.lblSPID);
            this.groupPanel1.Controls.Add(this.lblMessage);
            this.groupPanel1.Controls.Add(this.chkVAT);
            this.groupPanel1.Controls.Add(this.cboLoaiTien);
            this.groupPanel1.Controls.Add(this.dtpThoiDiem);
            this.groupPanel1.Controls.Add(this.txtGia);
            this.groupPanel1.Controls.Add(this.txtNguon);
            this.groupPanel1.Controls.Add(this.txtTSK);
            this.groupPanel1.Controls.Add(this.txtDGH);
            this.groupPanel1.Controls.Add(this.txtModel);
            this.groupPanel1.Controls.Add(this.txtHSX);
            this.groupPanel1.Controls.Add(this.cboDVT);
            this.groupPanel1.Controls.Add(this.cboKV);
            this.groupPanel1.Controls.Add(this.cboLH);
            this.groupPanel1.Controls.Add(this.cboDMH);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.btnReset);
            this.groupPanel1.Controls.Add(this.btnLuu);
            this.groupPanel1.Controls.Add(this.labelX13);
            this.groupPanel1.Controls.Add(this.labelX12);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(944, 395);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Thông Tin Sản Phẩm";
            // 
            // lblGiaID
            // 
            this.lblGiaID.Location = new System.Drawing.Point(803, 57);
            this.lblGiaID.Name = "lblGiaID";
            this.lblGiaID.Size = new System.Drawing.Size(75, 23);
            this.lblGiaID.TabIndex = 31;
            this.lblGiaID.Visible = false;
            // 
            // lblSPID
            // 
            this.lblSPID.Location = new System.Drawing.Point(803, 16);
            this.lblSPID.Name = "lblSPID";
            this.lblSPID.Size = new System.Drawing.Size(75, 23);
            this.lblSPID.TabIndex = 30;
            this.lblSPID.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(484, 283);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(239, 23);
            this.lblMessage.TabIndex = 29;
            // 
            // chkVAT
            // 
            this.chkVAT.Location = new System.Drawing.Point(566, 192);
            this.chkVAT.Name = "chkVAT";
            this.chkVAT.Size = new System.Drawing.Size(75, 23);
            this.chkVAT.TabIndex = 28;
            // 
            // cboLoaiTien
            // 
            this.cboLoaiTien.DisplayMember = "Text";
            this.cboLoaiTien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiTien.FormattingEnabled = true;
            this.cboLoaiTien.ItemHeight = 14;
            this.cboLoaiTien.Location = new System.Drawing.Point(566, 148);
            this.cboLoaiTien.Name = "cboLoaiTien";
            this.cboLoaiTien.Size = new System.Drawing.Size(121, 20);
            this.cboLoaiTien.TabIndex = 27;
            // 
            // dtpThoiDiem
            // 
            // 
            // 
            // 
            this.dtpThoiDiem.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpThoiDiem.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpThoiDiem.ButtonDropDown.Visible = true;
            this.dtpThoiDiem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpThoiDiem.Location = new System.Drawing.Point(565, 102);
            // 
            // 
            // 
            this.dtpThoiDiem.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpThoiDiem.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpThoiDiem.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpThoiDiem.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpThoiDiem.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpThoiDiem.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpThoiDiem.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpThoiDiem.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpThoiDiem.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpThoiDiem.MonthCalendar.DisplayMonth = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.dtpThoiDiem.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpThoiDiem.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpThoiDiem.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpThoiDiem.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpThoiDiem.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpThoiDiem.MonthCalendar.TodayButtonVisible = true;
            this.dtpThoiDiem.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpThoiDiem.Name = "dtpThoiDiem";
            this.dtpThoiDiem.Size = new System.Drawing.Size(96, 20);
            this.dtpThoiDiem.TabIndex = 26;
            // 
            // txtGia
            // 
            // 
            // 
            // 
            this.txtGia.Border.Class = "TextBoxBorder";
            this.txtGia.Location = new System.Drawing.Point(566, 60);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(121, 20);
            this.txtGia.TabIndex = 25;
            // 
            // txtNguon
            // 
            // 
            // 
            // 
            this.txtNguon.Border.Class = "TextBoxBorder";
            this.txtNguon.Location = new System.Drawing.Point(566, 17);
            this.txtNguon.Name = "txtNguon";
            this.txtNguon.Size = new System.Drawing.Size(121, 20);
            this.txtNguon.TabIndex = 24;
            // 
            // txtTSK
            // 
            // 
            // 
            // 
            this.txtTSK.Border.Class = "TextBoxBorder";
            this.txtTSK.Location = new System.Drawing.Point(208, 329);
            this.txtTSK.Name = "txtTSK";
            this.txtTSK.Size = new System.Drawing.Size(163, 20);
            this.txtTSK.TabIndex = 23;
            // 
            // txtDGH
            // 
            // 
            // 
            // 
            this.txtDGH.Border.Class = "TextBoxBorder";
            this.txtDGH.Location = new System.Drawing.Point(208, 283);
            this.txtDGH.Name = "txtDGH";
            this.txtDGH.Size = new System.Drawing.Size(163, 20);
            this.txtDGH.TabIndex = 22;
            // 
            // txtModel
            // 
            // 
            // 
            // 
            this.txtModel.Border.Class = "TextBoxBorder";
            this.txtModel.Location = new System.Drawing.Point(208, 236);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(163, 20);
            this.txtModel.TabIndex = 21;
            // 
            // txtHSX
            // 
            // 
            // 
            // 
            this.txtHSX.Border.Class = "TextBoxBorder";
            this.txtHSX.Location = new System.Drawing.Point(208, 195);
            this.txtHSX.Name = "txtHSX";
            this.txtHSX.Size = new System.Drawing.Size(163, 20);
            this.txtHSX.TabIndex = 20;
            // 
            // cboDVT
            // 
            this.cboDVT.DisplayMember = "Text";
            this.cboDVT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.ItemHeight = 14;
            this.cboDVT.Location = new System.Drawing.Point(208, 145);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(163, 20);
            this.cboDVT.TabIndex = 19;
            // 
            // cboKV
            // 
            this.cboKV.DisplayMember = "Text";
            this.cboKV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKV.FormattingEnabled = true;
            this.cboKV.ItemHeight = 14;
            this.cboKV.Location = new System.Drawing.Point(208, 102);
            this.cboKV.Name = "cboKV";
            this.cboKV.Size = new System.Drawing.Size(163, 20);
            this.cboKV.TabIndex = 18;
            // 
            // cboLH
            // 
            this.cboLH.DisplayMember = "Text";
            this.cboLH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLH.FormattingEnabled = true;
            this.cboLH.ItemHeight = 14;
            this.cboLH.Location = new System.Drawing.Point(208, 60);
            this.cboLH.Name = "cboLH";
            this.cboLH.Size = new System.Drawing.Size(163, 20);
            this.cboLH.TabIndex = 17;
            // 
            // cboDMH
            // 
            this.cboDMH.DisplayMember = "Text";
            this.cboDMH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDMH.FormattingEnabled = true;
            this.cboDMH.ItemHeight = 14;
            this.cboDMH.Location = new System.Drawing.Point(208, 17);
            this.cboDMH.Name = "cboDMH";
            this.cboDMH.Size = new System.Drawing.Size(163, 20);
            this.cboDMH.TabIndex = 16;
            this.cboDMH.SelectionChangeCommitted += new System.EventHandler(this.cboDMH_SelectionChangeCommitted);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.Location = new System.Drawing.Point(566, 236);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 15;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(648, 236);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Làm Lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(484, 235);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelX13
            // 
            this.labelX13.Location = new System.Drawing.Point(484, 193);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(87, 23);
            this.labelX13.TabIndex = 12;
            this.labelX13.Text = "VAT:";
            // 
            // labelX12
            // 
            this.labelX12.Location = new System.Drawing.Point(484, 145);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(87, 23);
            this.labelX12.TabIndex = 11;
            this.labelX12.Text = "Loại Tiền:";
            // 
            // labelX11
            // 
            this.labelX11.Location = new System.Drawing.Point(484, 102);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 10;
            this.labelX11.Text = "Thời Điểm:";
            // 
            // labelX10
            // 
            this.labelX10.Location = new System.Drawing.Point(484, 60);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(87, 23);
            this.labelX10.TabIndex = 9;
            this.labelX10.Text = "Giá:";
            // 
            // labelX9
            // 
            this.labelX9.Location = new System.Drawing.Point(484, 17);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(87, 23);
            this.labelX9.TabIndex = 8;
            this.labelX9.Text = "Nguồn Giá:";
            // 
            // labelX8
            // 
            this.labelX8.Location = new System.Drawing.Point(112, 326);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(87, 23);
            this.labelX8.TabIndex = 7;
            this.labelX8.Text = "Thông Số Khác:";
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(112, 280);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 23);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "Điểm Giao Hàng:";
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(112, 236);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(87, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Model:";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(112, 193);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Hãng Sản Xuất:";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(112, 145);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(87, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Đơn Vị Tính:";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(112, 102);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Khu Vực:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(112, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Loại Hàng:";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(112, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Danh Mục Hàng:";
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // clGiaID
            // 
            this.clGiaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGiaID.DataPropertyName = "GiaID";
            this.clGiaID.HeaderText = "Mã Giá";
            this.clGiaID.Name = "clGiaID";
            this.clGiaID.ReadOnly = true;
            this.clGiaID.Visible = false;
            // 
            // clSanPhamID
            // 
            this.clSanPhamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSanPhamID.DataPropertyName = "SanPhamID";
            this.clSanPhamID.HeaderText = "SPID";
            this.clSanPhamID.Name = "clSanPhamID";
            this.clSanPhamID.ReadOnly = true;
            this.clSanPhamID.Visible = false;
            // 
            // clDanhMucHangID
            // 
            this.clDanhMucHangID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDanhMucHangID.DataPropertyName = "DanhMucHangID";
            this.clDanhMucHangID.HeaderText = "DanhMucHangID";
            this.clDanhMucHangID.Name = "clDanhMucHangID";
            this.clDanhMucHangID.ReadOnly = true;
            this.clDanhMucHangID.Visible = false;
            // 
            // clTenHang
            // 
            this.clTenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenHang.DataPropertyName = "TenHang";
            this.clTenHang.HeaderText = "Tên Hàng";
            this.clTenHang.Name = "clTenHang";
            this.clTenHang.ReadOnly = true;
            // 
            // clLoaiHangID
            // 
            this.clLoaiHangID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLoaiHangID.DataPropertyName = "LoaiHangID";
            this.clLoaiHangID.HeaderText = "LoaiHangID";
            this.clLoaiHangID.Name = "clLoaiHangID";
            this.clLoaiHangID.ReadOnly = true;
            this.clLoaiHangID.Visible = false;
            // 
            // clTenLoaiHang
            // 
            this.clTenLoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenLoaiHang.DataPropertyName = "TenLoaiHang";
            this.clTenLoaiHang.HeaderText = "Loại Hàng";
            this.clTenLoaiHang.Name = "clTenLoaiHang";
            this.clTenLoaiHang.ReadOnly = true;
            // 
            // clNguonGia
            // 
            this.clNguonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clNguonGia.DataPropertyName = "NguonGia";
            this.clNguonGia.HeaderText = "Nguồn Giá";
            this.clNguonGia.Name = "clNguonGia";
            this.clNguonGia.ReadOnly = true;
            this.clNguonGia.Width = 83;
            // 
            // clGia
            // 
            this.clGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGia.DataPropertyName = "Gia";
            this.clGia.HeaderText = "Giá";
            this.clGia.Name = "clGia";
            this.clGia.ReadOnly = true;
            // 
            // clDonViTinhGiaID
            // 
            this.clDonViTinhGiaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDonViTinhGiaID.DataPropertyName = "DonViTinhGiaID";
            this.clDonViTinhGiaID.HeaderText = "DonViTinhGiaID";
            this.clDonViTinhGiaID.Name = "clDonViTinhGiaID";
            this.clDonViTinhGiaID.ReadOnly = true;
            this.clDonViTinhGiaID.Visible = false;
            // 
            // clLoaiTienTe
            // 
            this.clLoaiTienTe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLoaiTienTe.DataPropertyName = "LoaiTienTe";
            this.clLoaiTienTe.HeaderText = "Loại Tiền";
            this.clLoaiTienTe.Name = "clLoaiTienTe";
            this.clLoaiTienTe.ReadOnly = true;
            // 
            // clVAT
            // 
            this.clVAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clVAT.DataPropertyName = "VAT";
            this.clVAT.HeaderText = "VAT";
            this.clVAT.Name = "clVAT";
            this.clVAT.ReadOnly = true;
            // 
            // clThoiDiem
            // 
            this.clThoiDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clThoiDiem.DataPropertyName = "ThoiDiem";
            this.clThoiDiem.HeaderText = "Thời Điểm";
            this.clThoiDiem.Name = "clThoiDiem";
            this.clThoiDiem.ReadOnly = true;
            // 
            // frmAddVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 596);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmAddVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddVatTu_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaSanPham)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpThoiDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvGiaSanPham;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDMH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboKV;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDVT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDGH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtModel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHSX;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTSK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNguon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGia;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpThoiDiem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLoaiTien;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkVAT;
        private DevComponents.DotNetBar.LabelX lblMessage;
        private DevComponents.DotNetBar.LabelX lblSPID;
        private DevComponents.DotNetBar.LabelX lblGiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSanPhamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDanhMucHangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiHangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinhGiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiTienTe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiDiem;
    }
}