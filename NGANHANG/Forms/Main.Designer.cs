namespace NGANHANG.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiKhoanNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaoDich = new DevExpress.XtraBars.BarButtonItem();
            this.btnGDChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.quanLiTaiKhoan = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnTaoLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeGiaoDich = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKGiaoDich = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PHANMANH = new NGANHANG.DS_PHANMANH();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new NGANHANG.DS_PHANMANHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbQuyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PHANMANH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 431);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(910, 24);
            this.ribbonStatusBar.Visible = false;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnNhanVien,
            this.btnKhachHang,
            this.btnTaiKhoanNV,
            this.btnGiaoDich,
            this.btnGDChuyenTien,
            this.btnQLTaiKhoan,
            this.btnThongKeGiaoDich,
            this.btnTKGiaoDich,
            this.btnLogOut,
            this.btnTaiKhoan,
            this.btnThongKe,
            this.barButtonItem1,
            this.btnLOut,
            this.btnTaoLogin});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 74;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(910, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 1;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.LargeWidth = 100;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Id = 2;
            this.btnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.Image")));
            this.btnKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.LargeImage")));
            this.btnKhachHang.LargeWidth = 100;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnTaiKhoanNV
            // 
            this.btnTaiKhoanNV.Caption = "Tài khoản";
            this.btnTaiKhoanNV.Id = 17;
            this.btnTaiKhoanNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoanNV.ImageOptions.Image")));
            this.btnTaiKhoanNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoanNV.ImageOptions.LargeImage")));
            this.btnTaiKhoanNV.LargeWidth = 100;
            this.btnTaiKhoanNV.Name = "btnTaiKhoanNV";
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.Caption = "Giao dịch";
            this.btnGiaoDich.Id = 22;
            this.btnGiaoDich.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoDich.ImageOptions.Image")));
            this.btnGiaoDich.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiaoDich.ImageOptions.LargeImage")));
            this.btnGiaoDich.LargeWidth = 100;
            this.btnGiaoDich.Name = "btnGiaoDich";
            toolTipItem2.Text = "\r\n";
            superToolTip2.Items.Add(toolTipItem2);
            this.btnGiaoDich.SuperTip = superToolTip2;
            this.btnGiaoDich.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaoDich_ItemClick);
            // 
            // btnGDChuyenTien
            // 
            this.btnGDChuyenTien.Caption = "Chuyển tiền";
            this.btnGDChuyenTien.Id = 25;
            this.btnGDChuyenTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGDChuyenTien.ImageOptions.Image")));
            this.btnGDChuyenTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGDChuyenTien.ImageOptions.LargeImage")));
            this.btnGDChuyenTien.LargeWidth = 100;
            this.btnGDChuyenTien.Name = "btnGDChuyenTien";
            this.btnGDChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGDChuyenTien_ItemClick);
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.ActAsDropDown = true;
            this.btnQLTaiKhoan.AllowAllUp = true;
            this.btnQLTaiKhoan.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnQLTaiKhoan.Caption = "Quản lí tài khoản";
            this.btnQLTaiKhoan.CausesValidation = true;
            this.btnQLTaiKhoan.CloseRadialMenuOnItemClick = true;
            this.btnQLTaiKhoan.DropDownControl = this.quanLiTaiKhoan;
            this.btnQLTaiKhoan.Id = 35;
            this.btnQLTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLTaiKhoan.ImageOptions.LargeImage")));
            this.btnQLTaiKhoan.LargeWidth = 100;
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            // 
            // quanLiTaiKhoan
            // 
            this.quanLiTaiKhoan.ItemLinks.Add(this.btnTaoLogin);
            this.quanLiTaiKhoan.ItemLinks.Add(this.btnLOut);
            this.quanLiTaiKhoan.Name = "quanLiTaiKhoan";
            this.quanLiTaiKhoan.Ribbon = this.ribbon;
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Caption = "Tạo Login";
            this.btnTaoLogin.Id = 72;
            this.btnTaoLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoLogin.ImageOptions.Image")));
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoLogin_ItemClick);
            // 
            // btnLOut
            // 
            this.btnLOut.Caption = "Đăng xuất";
            this.btnLOut.Id = 71;
            this.btnLOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLOut.ImageOptions.Image")));
            this.btnLOut.LargeWidth = -20;
            this.btnLOut.Name = "btnLOut";
            this.btnLOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThongKeGiaoDich
            // 
            this.btnThongKeGiaoDich.Caption = "Giao dịch";
            this.btnThongKeGiaoDich.Id = 56;
            this.btnThongKeGiaoDich.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKeGiaoDich.ImageOptions.Image")));
            this.btnThongKeGiaoDich.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongKeGiaoDich.ImageOptions.LargeImage")));
            this.btnThongKeGiaoDich.LargeWidth = 100;
            this.btnThongKeGiaoDich.Name = "btnThongKeGiaoDich";
            // 
            // btnTKGiaoDich
            // 
            this.btnTKGiaoDich.Id = 69;
            this.btnTKGiaoDich.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKGiaoDich.ImageOptions.Image")));
            this.btnTKGiaoDich.Name = "btnTKGiaoDich";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 65;
            this.btnLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.Image")));
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnTaiKhoan.AllowAllUp = true;
            this.btnTaiKhoan.Caption = "Tài khoản";
            this.btnTaiKhoan.CloseRadialMenuOnItemClick = true;
            this.btnTaiKhoan.Id = 66;
            this.btnTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.ImageOptions.Image")));
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnTaiKhoan.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnTaiKhoan.SmallWithTextWidth = 20;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Caption = "Thống kê";
            this.btnThongKe.Id = 68;
            this.btnThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.ImageOptions.Image")));
            this.btnThongKe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongKe.ImageOptions.LargeImage")));
            this.btnThongKe.LargeWidth = 100;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKe_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 70;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup11,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lí ngân hàng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản trị";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.AllowTextClipping = false;
            this.ribbonPageGroup11.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup11.ItemLinks.Add(this.btnGiaoDich);
            this.ribbonPageGroup11.ItemLinks.Add(this.btnGDChuyenTien);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "Giao dịch khách hàng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThongKe);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thống kê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQLTaiKhoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Tài khoản";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            // 
            // v_DS_PHANMANHBindingSource1
            // 
            this.v_DS_PHANMANHBindingSource1.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource1.DataSource = this.dS_PHANMANH;
            // 
            // dS_PHANMANH
            // 
            this.dS_PHANMANH.DataSetName = "DS_PHANMANH";
            this.dS_PHANMANH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // rbTaiKhoan
            // 
            this.rbTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.rbTaiKhoan.Name = "rbTaiKhoan";
            this.rbTaiKhoan.Text = "Tài khoản";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbMaNV,
            this.HoTen,
            this.tbQuyen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(910, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(82, 17);
            this.tbMaNV.Text = "Mã nhân viên:";
            // 
            // HoTen
            // 
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(47, 17);
            this.HoTen.Text = "Họ Tên:";
            // 
            // tbQuyen
            // 
            this.tbQuyen.Name = "tbQuyen";
            this.tbQuyen.Size = new System.Drawing.Size(44, 17);
            this.tbQuyen.Text = "Nhóm:";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Location = new System.Drawing.Point(0, 0);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(250, 130);
            this.popupControlContainer1.TabIndex = 0;
            this.popupControlContainer1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 455);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PHANMANH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        //private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_PHANMANH dS_PHANMANH;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource1;
        private DS_PHANMANHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnTaiKhoanNV;
        private DevExpress.XtraBars.BarButtonItem btnGiaoDich;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnGDChuyenTien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnQLTaiKhoan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tbMaNV;
        private System.Windows.Forms.ToolStripStatusLabel tbQuyen;
        private System.Windows.Forms.ToolStripStatusLabel HoTen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnThongKeGiaoDich;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraBars.BarButtonItem btnTKGiaoDich;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnThongKe;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.PopupMenu quanLiTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnLOut;
        private DevExpress.XtraBars.BarButtonItem btnTaoLogin;
    }
}