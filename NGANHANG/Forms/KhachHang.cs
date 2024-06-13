using DevExpress.XtraEditors;
using NGANHANG.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace NGANHANG.Forms
{
    public partial class KhachHang : DevExpress.XtraEditors.XtraForm
    {
        private string CMNDKhachHangTruoc = "";
        private bool themKhachHang = false;
        private bool moTaiKhoanKH = false;

        private string gioiTinh = "";
        public KhachHang()
        {
            InitializeComponent();
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cN_NGANHANG);

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

            try
            {

                this.khachHangTableAdapter.Connection.ConnectionString = Program.connectionstring;
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectionstring;

                this.khachHangTableAdapter.Fill(this.cN_NGANHANG.KhachHang);
                this.taiKhoanTableAdapter.Fill(this.cN_NGANHANG.TaiKhoan);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                btnSua.Enabled = btnMoTaiKhoan.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLuu.Enabled = false;
                MessageBox.Show("Bạn chỉ xem được danh sách khách hàng và không thể chỉnh sửa ở form này");
            }
            cbChiNhanh.DataSource = Program.ChiNhanhbds;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            btnPhucHoi.Enabled = true;
            btnSua.Enabled = btnMoTaiKhoan.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLuu.Enabled = false;
            maChiNhanh.Enabled = SDTKhachHang.Enabled = gioiTinhNam.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = hoKhachHang.Enabled = tenKhachHang.Enabled = ngayCapCMND.Enabled = CMNDKhachHang.Enabled = diaChiKH.Enabled = false;
            if (Program.mGroup.Trim() == "CHINHANH")
            {
                cbChiNhanh.Enabled = false;
                btnSua.Enabled = btnMoTaiKhoan.Enabled = btnXoa.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnLuu.Enabled = true;
            }
            gbTaoTaiKhoanKH.Visible = false;

            //Nếu không có thông tin gì về khách hàng
            try
            {
                string phai = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["PHAI"].ToString().Trim();
                gioiTinhNam.Checked = true;

                gioiTinh = "Nam";

                if (phai == "Nữ")
                {
                    gioiTinhNu.Checked = true;
                    gioiTinh = "Nữ";
                }
            }
            catch (System.IndexOutOfRangeException ex) { }


        }

        bool kiemTraSo(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = false;
            btnThem.Enabled = false;
            diaChiKH.Enabled = hoKhachHang.Enabled = CMNDKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = ngayCapCMND.Enabled = true;
            btnMoTaiKhoan.Enabled = false;
            gridView2.AddNewRow();
            maChiNhanh.Text = ((DataRowView)khachHangBindingSource[0])["MACN"].ToString();
            khachHangGridControl.Enabled = false;
            themKhachHang = true;
            gioiTinhNam.Checked = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CMNDKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập sô chứng minh khách hàng", "", MessageBoxButtons.OK);
                CMNDKhachHang.Focus();
                return;
            }
            else if (!kiemTraSo(CMNDKhachHang.Text.Trim()))
            {
                MessageBox.Show("Định dạng CMND chưa phù hợp! Vui lòng nhập lại", "", MessageBoxButtons.OK);
                CMNDKhachHang.Focus();
                return;
            }
            else if (CMNDKhachHang.Text.Length > 10)
            {
                MessageBox.Show("Số CMND chứa tối đa là 10 số");
                CMNDKhachHang.Focus();
                return;
            }
            else if (hoKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ khách hàng", "", MessageBoxButtons.OK);
                hoKhachHang.Focus();
                return;
            }
            else if (hoKhachHang.Text.Length > 50)
            {
                MessageBox.Show("Họ khách hàng chứa tối đa là 50 kí tự");
                hoKhachHang.Focus();
                return;
            }
            else if (tenKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "", MessageBoxButtons.OK);
                tenKhachHang.Focus();
                return;
            }
            else if (tenKhachHang.Text.Length > 10)
            {
                MessageBox.Show("Tên khách hàng chứa tối đa 10 kí tự");
                tenKhachHang.Focus();
                return;
            }
            else if (diaChiKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "", MessageBoxButtons.OK);
                diaChiKH.Focus();
                return;
            }
            else if (diaChiKH.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ khách hàng chứa tối đa 100 kí tự");
                diaChiKH.Focus();
                return;
            }
            else if (SDTKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng", "", MessageBoxButtons.OK);
                SDTKhachHang.Focus();
                return;
            }
            else if (!kiemTraSo(SDTKhachHang.Text))
            {
                MessageBox.Show("Định dạng số điện thoại chưa phù hợp! Vui lòng nhập lại", "", MessageBoxButtons.OK);
                SDTKhachHang.Focus();
                return;
            }
            else if (SDTKhachHang.Text.Length > 15)
            {
                MessageBox.Show("Số điện thoại chứa tối đa là 15 số");
                SDTKhachHang.Focus();
                return;
            }

            else
            {
                string cmndkh = CMNDKhachHang.Text;

                // MessageBox.Show(KT_KhachHang.KiemTraSoCMND(CMNDKhachHang.Text).ToString());
                if ((!cmndkh.Equals(CMNDKhachHangTruoc) && (CMNDKhachHangTruoc != "")) || (themKhachHang == true))
                {
                    //MessageBox.Show("hello " + CMNDKhachHangTruoc);

                    if (KT_KhachHang.KiemTraSoCMND(CMNDKhachHang.Text) == 0)
                    {

                        ((DataRowView)khachHangBindingSource[khachHangBindingSource.Count - 1])["PHAI"] = "Nam";

                        gioiTinh = "Nam";

                        if (gioiTinhNu.Checked == true)
                        {
                            ((DataRowView)khachHangBindingSource[khachHangBindingSource.Count - 1])["PHAI"] = "Nữ";

                            gioiTinh = "Nữ";
                        }
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                        maChiNhanh.Enabled = diaChiKH.Enabled = hoKhachHang.Enabled = CMNDKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = ngayCapCMND.Enabled = false;
                        khachHangBindingSource.EndEdit();
                        khachHangBindingSource.ResetCurrentItem();

                        KT_KhachHang.TaoKhachHang(CMNDKhachHang.Text, hoKhachHang.Text, tenKhachHang.Text, diaChiKH.Text, gioiTinh, ngayCapCMND.Text, SDTKhachHang.Text, maChiNhanh.Text);

                        this.khachHangTableAdapter.Connection.ConnectionString = Program.connectionstring;
                        /*this.khachHangTableAdapter.Update(this.cN_NGANHANG);*/
                        khachHangGridControl.Enabled = true;
                        themKhachHang = false;
                        btnMoTaiKhoan.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Số CMND đã tồn tại! Vui lòng nhập lại");
                    }
                }
                else
                {
                    // MessageBox.Show(CMNDKhachHangTruoc);
                    ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["PHAI"] = "Nam";
                    if (gioiTinhNu.Checked == true)
                    {
                        ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["PHAI"] = "Nữ";
                    }
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                    maChiNhanh.Enabled = diaChiKH.Enabled = hoKhachHang.Enabled = CMNDKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = ngayCapCMND.Enabled = false;
                    khachHangBindingSource.EndEdit();
                    khachHangBindingSource.ResetCurrentItem();

                    KT_KhachHang.TaoKhachHang(CMNDKhachHang.Text, hoKhachHang.Text, tenKhachHang.Text, diaChiKH.Text, gioiTinh, ngayCapCMND.Text, SDTKhachHang.Text, maChiNhanh.Text);

                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connectionstring;
                    /*this.khachHangTableAdapter.Update(this.cN_NGANHANG);*/
                    khachHangGridControl.Enabled = true;
                    btnMoTaiKhoan.Enabled = true;
                }

            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CMNDKhachHangTruoc = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["CMND"].ToString();
            btnMoTaiKhoan.Enabled = false;
            khachHangGridControl.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = false;
            btnSua.Enabled = false;
            CMNDKhachHang.Enabled = false;
            diaChiKH.Enabled = hoKhachHang.Enabled = SDTKhachHang.Enabled = tenKhachHang.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = ngayCapCMND.Enabled = true;


        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int cmnd = int.Parse(((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["CMND"].ToString());
            // MessageBox.Show(cmnd.ToString());

            String tmpCMDN = tbCMND.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin khách hàng", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (KT_KhachHang.KiemTraGiaoDichKhachHang(tbCMND.Text) == 0)
                {


                    gridView2.DeleteSelectedRows();

                    khachHangBindingSource.EndEdit();

                    khachHangBindingSource.ResetCurrentItem();

                    /*KT_KhachHang.XoaKhachHangNonGiaoDich(tbCMND.Text);*/

                    MessageBox.Show("Xoá thành công khánh hàng có CMND " + tmpCMDN, "", MessageBoxButtons.OK);

                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connectionstring;
                    this.khachHangTableAdapter.Update(this.cN_NGANHANG);
                    khachHangGridControl.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không thể xóa khách hàng vì khách hàng đã tồn tại tài khoản");
                    return;
                }
            }
        }

        private void gioiTinhNam_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinhNu.Checked = !gioiTinhNam.Checked;
        }

        private void gioiTinhNu_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinhNam.Checked = !gioiTinhNu.Checked;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private int KiemTraViTri_CMND(string SoCMND)
        {
            int i = 0;
            string cmnd = "";
            for (i = 0; i < taiKhoanBindingSource.Count; i++)
            {
                cmnd = ((DataRowView)taiKhoanBindingSource[i])["CMND"].ToString().Trim();
                if (SoCMND.Trim().Equals(cmnd)) return i;
            }

            return -1;
        }

        private void TaoTaiKhoan(object sender, EventArgs e)
        {
            moTaiKhoanKH = true;
            ThemTaiKhoanKhachHang(moTaiKhoanKH);
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connectionstring;
            this.khachHangTableAdapter.Fill(this.cN_NGANHANG.KhachHang);
            khachHangGridControl.Enabled = true;
            if (Program.mGroup.Trim() == "CHINHANH")
            {
                diaChiKH.Enabled = hoKhachHang.Enabled = tenKhachHang.Enabled = SDTKhachHang.Enabled = CMNDKhachHang.Enabled = gioiTinhNu.Enabled = gioiTinhNam.Enabled = ngayCapCMND.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = true;
                btnMoTaiKhoan.Enabled = true;
                gbTaoTaiKhoanKH.Visible = false;
                themKhachHang = false;
                moTaiKhoanKH = false;
            }



        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.TenServer = cbChiNhanh.SelectedValue.ToString();

            if (cbChiNhanh.SelectedIndex != 0)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.loginDN;
                Program.password = Program.passwordDN;
            }
            bool rs = db_connect.KTDangNhap(Program.mlogin, Program.password);
            if (!rs)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                try
                {
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connectionstring;
                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectionstring;

                    this.khachHangTableAdapter.Fill(this.cN_NGANHANG.KhachHang);
                    this.taiKhoanTableAdapter.Fill(this.cN_NGANHANG.TaiKhoan);
                    btnSua.Enabled = btnMoTaiKhoan.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLuu.Enabled = false;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    btnSua.Enabled = btnMoTaiKhoan.Enabled = btnXoa.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnLuu.Enabled = false;
                }
            }
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            ThemTaiKhoanKhachHang(moTaiKhoanKH);
        }

        private void ThemTaiKhoanKhachHang(bool moTaiKhoanKH)
        {
            if (moTaiKhoanKH == true)
            {

                //Kiểm tra số chứng minh trong bảng tài khoản
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectionstring;

                this.taiKhoanTableAdapter.Fill(this.cN_NGANHANG.TaiKhoan);

                int vt_taikhoan = KiemTraViTri_CMND(CMNDKhachHang.Text.Trim());

                //MessageBox.Show( CMNDKhachHang.Text + " " + this.taiKhoanTableAdapter.Connection.ConnectionString);

                if (vt_taikhoan != -1)
                {
                    tbCMND.Enabled = tbSoDu.Enabled = tbSoTaiKhoan.Enabled = false;
                    gbTaoTaiKhoanKH.ResetText();
                    gbTaoTaiKhoanKH.Text = "Khách hàng đã có tài khoản";
                    btnTaoTK.ResetText();
                    btnTaoTK.Text = "Duyệt";
                    gbTaoTaiKhoanKH.Visible = true;
                    tbSoTaiKhoan.Text = ((DataRowView)taiKhoanBindingSource[vt_taikhoan])["SOTK"].ToString().Trim();
                    tbSoDu.Text = ((DataRowView)taiKhoanBindingSource[vt_taikhoan])["SODU"].ToString().Trim();

                }
                else
                {
                    tbSoDu.Enabled = tbSoTaiKhoan.Enabled = true;
                    gbTaoTaiKhoanKH.ResetText();
                    gbTaoTaiKhoanKH.Text = "Khách hàng chưa có tài khoản";
                    btnTaoTK.ResetText();
                    btnTaoTK.Text = "Tạo TK";
                    tbSoTaiKhoan.Text = "";
                    tbSoDu.Text = "100000";
                    gbTaoTaiKhoanKH.Visible = true;

                }
            }
        }

        private void btnMoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = false;

            MoTaiKhoanKH moTaiKhoan = new MoTaiKhoanKH(maChiNhanh.Text);
            moTaiKhoan.Owner = this;
            moTaiKhoan.Show();

        }

        private void btnHuyTaoTK_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = true;
            moTaiKhoanKH = false;
            gbTaoTaiKhoanKH.Visible = false;
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            int vt_taikhoan = KiemTraViTri_CMND(CMNDKhachHang.Text.Trim());
            if (vt_taikhoan != -1)
            {
                MessageBox.Show("Khách hàng đã tồn tại tài khoản");

            }
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = true;
                //MessageBox.Show("Bạn có thể tạo tài khoản khách hàng");
                if (tbSoTaiKhoan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số tài khoản");
                    tbSoTaiKhoan.Focus();
                    return;
                }
                if (tbSoTaiKhoan.Text.Length > 9)
                {
                    MessageBox.Show("Số tài khoản tối đa là 9 số");
                    tbSoTaiKhoan.Focus();
                    return;
                }
                else if (tbSoDu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số dư! Số dư tối thiểu là 100000 VND");
                    tbSoDu.Focus();
                    return;
                }
                else if (!kiemTraSo(tbSoDu.Text))
                {
                    MessageBox.Show("Số dư phải định dạng số");
                    tbSoDu.Focus();
                    return;
                }
                else if (KT_TaiKhoanKH.KiemTraSoTaiKhoan(tbSoTaiKhoan.Text) == 1)
                {
                    MessageBox.Show("Số tài khoản bị trùng! Vui lòng nhập lại");
                    tbSoTaiKhoan.Focus();
                    return;
                }
                else
                {

                    taiKhoanBindingSource.AddNew();
                    ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["SOTK"] = tbSoTaiKhoan.Text;
                    ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["CMND"] = tbCMND.Text;
                    ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["SODU"] = tbSoDu.Text;
                    ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["MACN"] = maChiNhanh.Text;

                    taiKhoanBindingSource.EndEdit();
                    taiKhoanBindingSource.ResetCurrentItem();

                    if (this.taiKhoanTableAdapter.Update(this.cN_NGANHANG) == 1)
                    {
                        MessageBox.Show("Tạo tài khoản khách hàng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản khách hàng không thành công");
                        return;
                    }
                    gbTaoTaiKhoanKH.ResetText();
                    gbTaoTaiKhoanKH.Text = "Khách hàng đã có tài khoản";
                    btnTaoTK.ResetText();
                    btnTaoTK.Text = "Duyệt";
                }
            }
        }

        private void gridView2_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //if (e.MenuType == GridMenuType.Row)
            //{
            //    int vt_taikhoan = KiemTraViTri_CMND(CMNDKhachHang.Text.Trim());
            //    if (vt_taikhoan == -1)
            //    {
            //        DXMenuItem btnMoTaiKhoanKH = new DXMenuItem();
            //        btnMoTaiKhoanKH.Caption = "Tạo tài khoản";

            //        btnMoTaiKhoanKH.Click += new EventHandler(TaoTaiKhoan);
            //        e.Menu.Items.Add(btnMoTaiKhoanKH);

            //    }
            //    else
            //    {
            //        DXMenuItem btnTaoTaiKhoan = new DXMenuItem();
            //        btnTaoTaiKhoan.Caption = "Thông tin tài khoản";

            //        btnTaoTaiKhoan.Click += new EventHandler(TaoTaiKhoan);
            //        e.Menu.Items.Add(btnTaoTaiKhoan);

            //        DXMenuItem btnChuyenTien = new DXMenuItem();
            //        btnChuyenTien.Caption = "Chuyển tiền";
            //        e.Menu.Items.Add(btnChuyenTien);

            //        DXMenuItem btnGuiTien = new DXMenuItem();
            //        btnGuiTien.Caption = "Gửi tiền";
            //        e.Menu.Items.Add(btnGuiTien);

            //        DXMenuItem btnRutTien = new DXMenuItem();
            //        btnRutTien.Caption = "Rút tiền";
            //        e.Menu.Items.Add(btnRutTien);
            //    }

            //}
        }

        private void khachHangGridControl_Click(object sender, EventArgs e)
        {
            string phai = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["PHAI"].ToString().Trim();
            gioiTinhNam.Checked = true;
            if (phai == "Nữ")
            {
                gioiTinhNu.Checked = true;
            }
        }
    }
}