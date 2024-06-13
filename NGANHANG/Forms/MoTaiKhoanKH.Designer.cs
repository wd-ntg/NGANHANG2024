namespace NGANHANG.Forms
{
    partial class MoTaiKhoanKH
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label sOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoTaiKhoanKH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKiemTraThongTin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNhapSoCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.tbChiNhanh = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbSoTK = new System.Windows.Forms.TextBox();
            this.tbSoDu = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtMACNSet = new System.Windows.Forms.TextBox();
            this.txtSOTK = new System.Windows.Forms.TextBox();
            this.CMND = new System.Windows.Forms.TextBox();
            this.numbSODU = new System.Windows.Forms.NumericUpDown();
            this.reloadTrangBtn = new DevExpress.XtraEditors.SimpleButton();
            this.phucHoiBtn = new DevExpress.XtraEditors.SimpleButton();
            this.xoaBtn = new DevExpress.XtraEditors.SimpleButton();
            this.luuBtn = new DevExpress.XtraEditors.SimpleButton();
            this.hieuChinhBtn = new DevExpress.XtraEditors.SimpleButton();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cN_NGANHANG = new NGANHANG.CN_NGANHANG();
            this.taiKhoanTableAdapter = new NGANHANG.CN_NGANHANGTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NGANHANG.CN_NGANHANGTableAdapters.TableAdapterManager();
            /*this.dS_TaiKhoanKH = new NGANHANG.DS_TaiKhoanKH();
            this.frmMoTaiKhoanKH_InfoCustomerTableAdapter = new NGANHANG.DS_TaiKhoanKHTableAdapters.frmMoTaiKhoanKH_InfoCustomerTableAdapter();*/
            this.frmMoTaiKhoanKHInfoCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTaiKhoanKHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataDS_TaiKhoanKH = new System.Windows.Forms.DataGridView();
            cMNDLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbSODU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG)).BeginInit();
            /*((System.ComponentModel.ISupportInitialize)(this.dS_TaiKhoanKH)).BeginInit();*/
            ((System.ComponentModel.ISupportInitialize)(this.frmMoTaiKhoanKHInfoCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTaiKhoanKHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDS_TaiKhoanKH)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(479, 82);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(65, 20);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(477, 47);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(114, 20);
            mACNLabel.TabIndex = 2;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODULabel.Location = new System.Drawing.Point(20, 79);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(57, 20);
            sODULabel.TabIndex = 6;
            sODULabel.Text = "Số dư:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(20, 43);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(106, 20);
            sOTKLabel.TabIndex = 4;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKiemTraThongTin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbNhapSoCMND);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnKiemTraThongTin
            // 
            this.btnKiemTraThongTin.Location = new System.Drawing.Point(451, 12);
            this.btnKiemTraThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.btnKiemTraThongTin.Name = "btnKiemTraThongTin";
            this.btnKiemTraThongTin.Size = new System.Drawing.Size(88, 28);
            this.btnKiemTraThongTin.TabIndex = 2;
            this.btnKiemTraThongTin.Text = "Kiểm tra";
            this.btnKiemTraThongTin.UseVisualStyleBackColor = true;
            this.btnKiemTraThongTin.Click += new System.EventHandler(this.btnKiemTraThongTin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số CMND:";
            // 
            // tbNhapSoCMND
            // 
            this.tbNhapSoCMND.Location = new System.Drawing.Point(247, 15);
            this.tbNhapSoCMND.Margin = new System.Windows.Forms.Padding(4);
            this.tbNhapSoCMND.Name = "tbNhapSoCMND";
            this.tbNhapSoCMND.Size = new System.Drawing.Size(177, 23);
            this.tbNhapSoCMND.TabIndex = 0;
            this.tbNhapSoCMND.TextChanged += new System.EventHandler(this.tbNhapSoCMND_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thông tin KH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số tài khoản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(779, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số dư:";
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(107, 41);
            this.tbCMND.Margin = new System.Windows.Forms.Padding(4);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(162, 23);
            this.tbCMND.TabIndex = 8;
            // 
            // tbHo
            // 
            this.tbHo.Location = new System.Drawing.Point(107, 100);
            this.tbHo.Margin = new System.Windows.Forms.Padding(4);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(162, 23);
            this.tbHo.TabIndex = 9;
            // 
            // tbChiNhanh
            // 
            this.tbChiNhanh.Location = new System.Drawing.Point(460, 41);
            this.tbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.tbChiNhanh.Name = "tbChiNhanh";
            this.tbChiNhanh.Size = new System.Drawing.Size(162, 23);
            this.tbChiNhanh.TabIndex = 10;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(460, 100);
            this.tbTen.Margin = new System.Windows.Forms.Padding(4);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(162, 23);
            this.tbTen.TabIndex = 11;
            // 
            // tbSoTK
            // 
            this.tbSoTK.Location = new System.Drawing.Point(832, 41);
            this.tbSoTK.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoTK.Name = "tbSoTK";
            this.tbSoTK.Size = new System.Drawing.Size(162, 23);
            this.tbSoTK.TabIndex = 11;
            // 
            // tbSoDu
            // 
            this.tbSoDu.Location = new System.Drawing.Point(832, 103);
            this.tbSoDu.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoDu.Name = "tbSoDu";
            this.tbSoDu.Size = new System.Drawing.Size(162, 23);
            this.tbSoDu.TabIndex = 12;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(107, 164);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(162, 23);
            this.tbSDT.TabIndex = 13;
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.Location = new System.Drawing.Point(460, 160);
            this.rtbDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(162, 52);
            this.rtbDiaChi.TabIndex = 14;
            this.rtbDiaChi.Text = "";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(879, 187);
            this.btnTaoTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(92, 26);
            this.btnTaoTK.TabIndex = 15;
            this.btnTaoTK.Text = "Xác nhận";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(747, 187);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 26);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataDS_TaiKhoanKH);
            this.groupBox1.Controls.Add(this.pnlThongTinTaiKhoan);
            this.groupBox1.Controls.Add(this.reloadTrangBtn);
            this.groupBox1.Controls.Add(this.phucHoiBtn);
            this.groupBox1.Controls.Add(this.xoaBtn);
            this.groupBox1.Controls.Add(this.luuBtn);
            this.groupBox1.Controls.Add(this.hieuChinhBtn);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnTaoTK);
            this.groupBox1.Controls.Add(this.rtbDiaChi);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.tbSoDu);
            this.groupBox1.Controls.Add(this.tbSoTK);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.tbChiNhanh);
            this.groupBox1.Controls.Add(this.tbHo);
            this.groupBox1.Controls.Add(this.tbCMND);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1050, 633);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // pnlThongTinTaiKhoan
            // 
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtMACNSet);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtSOTK);
            this.pnlThongTinTaiKhoan.Controls.Add(sOTKLabel);
            this.pnlThongTinTaiKhoan.Controls.Add(sODULabel);
            this.pnlThongTinTaiKhoan.Controls.Add(mACNLabel);
            this.pnlThongTinTaiKhoan.Controls.Add(this.CMND);
            this.pnlThongTinTaiKhoan.Controls.Add(this.numbSODU);
            this.pnlThongTinTaiKhoan.Controls.Add(cMNDLabel);
            this.pnlThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlThongTinTaiKhoan.Location = new System.Drawing.Point(66, 451);
            this.pnlThongTinTaiKhoan.Name = "pnlThongTinTaiKhoan";
            this.pnlThongTinTaiKhoan.Size = new System.Drawing.Size(928, 128);
            this.pnlThongTinTaiKhoan.TabIndex = 24;
            this.pnlThongTinTaiKhoan.TabStop = false;
            this.pnlThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // txtMACNSet
            // 
            this.txtMACNSet.Location = new System.Drawing.Point(663, 40);
            this.txtMACNSet.Name = "txtMACNSet";
            this.txtMACNSet.ReadOnly = true;
            this.txtMACNSet.Size = new System.Drawing.Size(245, 30);
            this.txtMACNSet.TabIndex = 17;
            // 
            // txtSOTK
            // 
            this.txtSOTK.Location = new System.Drawing.Point(204, 40);
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Size = new System.Drawing.Size(243, 30);
            this.txtSOTK.TabIndex = 16;
            // 
            // CMND
            // 
            this.CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMND.Location = new System.Drawing.Point(663, 79);
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Size = new System.Drawing.Size(245, 27);
            this.CMND.TabIndex = 14;
            // 
            // numbSODU
            // 
            this.numbSODU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbSODU.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numbSODU.Location = new System.Drawing.Point(205, 77);
            this.numbSODU.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numbSODU.Name = "numbSODU";
            this.numbSODU.Size = new System.Drawing.Size(243, 27);
            this.numbSODU.TabIndex = 13;
            this.numbSODU.ThousandsSeparator = true;
            // 
            // reloadTrangBtn
            // 
            this.reloadTrangBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("reloadTrangBtn.ImageOptions.Image")));
            this.reloadTrangBtn.Location = new System.Drawing.Point(75, 375);
            this.reloadTrangBtn.Name = "reloadTrangBtn";
            this.reloadTrangBtn.Size = new System.Drawing.Size(117, 29);
            this.reloadTrangBtn.TabIndex = 22;
            this.reloadTrangBtn.Text = "Tải lại trang";
            this.reloadTrangBtn.Click += new System.EventHandler(this.reloadTrangBtn_Click);
            // 
            // phucHoiBtn
            // 
            this.phucHoiBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("phucHoiBtn.ImageOptions.Image")));
            this.phucHoiBtn.Location = new System.Drawing.Point(75, 316);
            this.phucHoiBtn.Name = "phucHoiBtn";
            this.phucHoiBtn.Size = new System.Drawing.Size(117, 29);
            this.phucHoiBtn.TabIndex = 21;
            this.phucHoiBtn.Text = "Phục hồi";
            this.phucHoiBtn.Click += new System.EventHandler(this.phucHoiBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xoaBtn.ImageOptions.Image")));
            this.xoaBtn.Location = new System.Drawing.Point(231, 316);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(105, 29);
            this.xoaBtn.TabIndex = 20;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // luuBtn
            // 
            this.luuBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("luuBtn.ImageOptions.Image")));
            this.luuBtn.Location = new System.Drawing.Point(231, 266);
            this.luuBtn.Name = "luuBtn";
            this.luuBtn.Size = new System.Drawing.Size(105, 29);
            this.luuBtn.TabIndex = 19;
            this.luuBtn.Text = "Lưu";
            this.luuBtn.Click += new System.EventHandler(this.luuBtn_Click);
            // 
            // hieuChinhBtn
            // 
            this.hieuChinhBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("hieuChinhBtn.ImageOptions.Image")));
            this.hieuChinhBtn.Location = new System.Drawing.Point(75, 266);
            this.hieuChinhBtn.Name = "hieuChinhBtn";
            this.hieuChinhBtn.Size = new System.Drawing.Size(117, 29);
            this.hieuChinhBtn.TabIndex = 18;
            this.hieuChinhBtn.Text = "Hiệu chỉnh";
            this.hieuChinhBtn.Click += new System.EventHandler(this.hieuChinhBtn_Click);
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.cN_NGANHANG;
            // 
            // cN_NGANHANG
            // 
            this.cN_NGANHANG.DataSetName = "CN_NGANHANG";
            this.cN_NGANHANG.EnforceConstraints = false;
            this.cN_NGANHANG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.CN_NGANHANGTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_TaiKhoanKH
            // 
            /*this.dS_TaiKhoanKH.DataSetName = "DS_TaiKhoanKH";
            this.dS_TaiKhoanKH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;*/
            // 
            // frmMoTaiKhoanKH_InfoCustomerTableAdapter
            // 
            /*this.frmMoTaiKhoanKH_InfoCustomerTableAdapter.ClearBeforeFill = true;*/
            // 
            // dSTaiKhoanKHBindingSource1
            // 
           /* this.dSTaiKhoanKHBindingSource1.DataSource = this.dS_TaiKhoanKH;*/
            this.dSTaiKhoanKHBindingSource1.Position = 0;
            // 
            // dataDS_TaiKhoanKH
            // 
            this.dataDS_TaiKhoanKH.AllowUserToAddRows = false;
            this.dataDS_TaiKhoanKH.AllowUserToDeleteRows = false;
            this.dataDS_TaiKhoanKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDS_TaiKhoanKH.Location = new System.Drawing.Point(460, 266);
            this.dataDS_TaiKhoanKH.Name = "dataDS_TaiKhoanKH";
            this.dataDS_TaiKhoanKH.ReadOnly = true;
            this.dataDS_TaiKhoanKH.RowHeadersWidth = 51;
            this.dataDS_TaiKhoanKH.RowTemplate.Height = 24;
            this.dataDS_TaiKhoanKH.Size = new System.Drawing.Size(534, 150);
            this.dataDS_TaiKhoanKH.TabIndex = 25;
            this.dataDS_TaiKhoanKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MoTaiKhoanKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MoTaiKhoanKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoTaiKhoanKH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoTaiKhoanKH_FormClosed);
            this.Load += new System.EventHandler(this.MoTaiKhoanKH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlThongTinTaiKhoan.ResumeLayout(false);
            this.pnlThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbSODU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cN_NGANHANG)).EndInit();
            /*((System.ComponentModel.ISupportInitialize)(this.dS_TaiKhoanKH)).EndInit();*/
            ((System.ComponentModel.ISupportInitialize)(this.frmMoTaiKhoanKHInfoCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTaiKhoanKHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDS_TaiKhoanKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKiemTraThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNhapSoCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.TextBox tbChiNhanh;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbSoTK;
        private System.Windows.Forms.TextBox tbSoDu;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.RichTextBox rtbDiaChi;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private CN_NGANHANG cN_NGANHANG;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private CN_NGANHANGTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private CN_NGANHANGTableAdapters.TableAdapterManager tableAdapterManager;
       /* private DS_TaiKhoanKH dS_TaiKhoanKH;
        private DS_TaiKhoanKHTableAdapters.frmMoTaiKhoanKH_InfoCustomerTableAdapter frmMoTaiKhoanKH_InfoCustomerTableAdapter;*/
        private DevExpress.XtraEditors.SimpleButton hieuChinhBtn;
        private DevExpress.XtraEditors.SimpleButton reloadTrangBtn;
        private DevExpress.XtraEditors.SimpleButton phucHoiBtn;
        private DevExpress.XtraEditors.SimpleButton xoaBtn;
        private DevExpress.XtraEditors.SimpleButton luuBtn;
        private System.Windows.Forms.BindingSource dSTaiKhoanKHBindingSource1;
        private System.Windows.Forms.BindingSource frmMoTaiKhoanKHInfoCustomerBindingSource;
        private System.Windows.Forms.GroupBox pnlThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtMACNSet;
        private System.Windows.Forms.TextBox txtSOTK;
        private System.Windows.Forms.TextBox CMND;
        private System.Windows.Forms.NumericUpDown numbSODU;
        private System.Windows.Forms.DataGridView dataDS_TaiKhoanKH;
    }
}