using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NGANHANG.Process;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;

namespace NGANHANG.Forms
{
    public partial class NhanVien : DevExpress.XtraEditors.XtraForm
    {
        private string maNhanVienTruoc = "";
        private bool themNhanVien = false;

        public NhanVien()
        {
            InitializeComponent();
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            this.Validate();
            this.chiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cN_NGANHANG);

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;
            try
            {
                btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLuu.Enabled = btnSwitchDepartment.Enabled = false;
                this.nhanVienTableAdapter.Fill(this.cN_NGANHANG.NhanVien);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi không truy vấn được vào form");
                maChiNhanh.Enabled = diaChiNV.Enabled = hoNhanVien.Enabled = maNhanVien.Enabled = SDTNhanVien.Enabled = tenNhanVien.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = false;
                btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnLuu.Enabled = false;

            }

            cbChiNhanh.DataSource = Program.ChiNhanhbds;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            maChiNhanh.Enabled = diaChiNV.Enabled = hoNhanVien.Enabled = maNhanVien.Enabled = SDTNhanVien.Enabled = tenNhanVien.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = false;
            cbTaoTaiKhoan.Visible = false;
            gbTaoTaiKhoan.Visible = false;
            btnPhucHoi.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLuu.Enabled = btnSwitchDepartment.Enabled = false;
            if (Program.mGroup.Trim() == "CHINHANH")
            {
                btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnLuu.Enabled = btnSwitchDepartment.Enabled = true;
                cbChiNhanh.Enabled = false;
            }
            
            //Nếu không có thông tin gì về nhân viên
            try
            {
                string phai = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["PHAI"].ToString().Trim();
                gioiTinhNam.Checked = true;
                if (phai == "Nữ")
                {
                    gioiTinhNu.Checked = true;
                }
            }
            catch (System.IndexOutOfRangeException ex) { }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = false;
            gioiTinhNam.Checked = true;
            btnSua.Enabled = btnXoa.Enabled = false;
            diaChiNV.Enabled = hoNhanVien.Enabled = maNhanVien.Enabled = SDTNhanVien.Enabled = tenNhanVien.Enabled = gioiTinhNu.Enabled = gioiTinhNam.Enabled = cmnd.Enabled = true;
            btnSwitchDepartment.Enabled = false;
            gridView1.AddNewRow();
            maChiNhanh.Text = ((DataRowView)nhanVienBindingSource[0])["MACN"].ToString();
            nhanVienGridControl.Enabled = false;
            themNhanVien = true;
            cbTaoTaiKhoan.Visible = true;

        }

        bool kiemTraSDT(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (maNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "", MessageBoxButtons.OK);
                maNhanVien.Focus();
                return;
            }
            else if (maNhanVien.Text.Length > 10)
            {
                MessageBox.Show("Mã nhân viên chứa tối đa là 10 số");
                maNhanVien.Focus();
                return;
            }
            else if (hoNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ nhân viên", "", MessageBoxButtons.OK);
                hoNhanVien.Focus();
                return;
            }
            else if (hoNhanVien.Text.Length > 40)
            {
                MessageBox.Show("Họ nhân viên chứa tối đa 40 kí tự");
                hoNhanVien.Focus();
                return;
            }
            else if (tenNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "", MessageBoxButtons.OK);
                tenNhanVien.Focus();
                return;
            }
            else if (tenNhanVien.Text.Length > 10)
            {
                MessageBox.Show("Tên nhân viên chứa tối đa 10 kí tự");
                tenNhanVien.Focus();
                return;
            }
            else if (diaChiNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên", "", MessageBoxButtons.OK);
                diaChiNV.Focus();
                return;
            }
            else if (diaChiNV.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ chỉ chứa tối đa 100 kí tự");
                diaChiNV.Focus();
                return;
            }
            else if (SDTNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên", "", MessageBoxButtons.OK);
                SDTNhanVien.Focus();
                return;
            }
            else if (!kiemTraSDT(SDTNhanVien.Text))
            {
                MessageBox.Show("Định dạng số điện thoại chưa phù hợp! Vui lòng nhập lại", "", MessageBoxButtons.OK);
                SDTNhanVien.Focus();
                return;
            }
            else if (SDTNhanVien.Text.Length > 15)
            {
                MessageBox.Show("Số điện thoại chứa tối đa 15 kí tự");
                SDTNhanVien.Focus();
                return;
            }
            else
            {

                //trangThaiXoaNV.Text = "1";
                string maNV = maNhanVien.Text;
                
                //Nếu người dùng không chỉnh sửa mã nhân viên hoặc khi thêm nhân viên có mã sẽ khác với chuỗi trống khởi tạo
                if ((!maNV.Equals(maNhanVienTruoc) && (maNhanVienTruoc != "")) || (themNhanVien == true))
                {
                    if (KT_MaNhanVien.KiemTraMaNhanVien(maNhanVien.Text) == 0)
                    {
                        
                        ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Count - 1])["PHAI"] = "Nam";
                        if (gioiTinhNu.Checked == true)
                        {
                            ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Count - 1])["PHAI"] = "Nữ";
                        }

                        //Nếu người dùng click tạo login
                        if (cbTaoTaiKhoan.Checked == true)
                        {
                            //nganHang.Visible = false;
                            //chiNhanh.Visible = false;
                            if (tbTaiKhoan.Text.Trim() == "")
                            {
                                MessageBox.Show("Bạn chưa nhập tài khoản cho nhân viên", "", MessageBoxButtons.OK);
                                tbTaiKhoan.Focus();
                                return;
                            }
                            else if (tbMatKhau.Text.Trim() == "")
                            {
                                MessageBox.Show("Bạn chưa nhập mật khẩu cho nhân viên", "", MessageBoxButtons.OK);
                                tbMatKhau.Focus();
                                return;
                            }
                            else
                            {
                               
                                int checkLogin = KT_TaoLogin.KiemTraTaoLogin(tbTaiKhoan.Text.Trim(), maNhanVien.Text.Trim());

                                //string role = "NGANHANG";
                                //if (chiNhanh.Checked == true)
                                //{
                                //    role = "CHINHANH";
                                //}
                                string role = Program.mGroup.Trim();
                                if (checkLogin == 1)
                                {
                                    MessageBox.Show("Tên tài khoản bị trùng! Vui lòng nhập lại", "", MessageBoxButtons.OK);
                                    tbTaiKhoan.Focus();
                                    return;
                                }
                                else if (checkLogin == 2)
                                {
                                    MessageBox.Show("Nhân viên này đã tồn tại tài khoản", "", MessageBoxButtons.OK);
                                    return;
                                }

                                else
                                {
                                    //tạo login
                                    if (KT_TaoLogin.TaoLogin(tbTaiKhoan.Text.Trim(), tbMatKhau.Text.Trim(), maNhanVien.Text.Trim(), role) == 0)
                                    {
                                        gioiTinhNam.Text = "Nữ";
                                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                                        maChiNhanh.Enabled = diaChiNV.Enabled = hoNhanVien.Enabled = maNhanVien.Enabled = SDTNhanVien.Enabled = tenNhanVien.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = trangThaiXoaNV.Enabled = cmnd.Enabled = false;
                                        nhanVienBindingSource.EndEdit();
                                        nhanVienBindingSource.ResetCurrentItem();

                                        Guid newGuid = Guid.NewGuid();

                                        // Đặt giá trị rowguid cho bản ghi mới hoặc sửa đổi
                                        ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["rowguid"] = newGuid;

                                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;
                                        this.nhanVienTableAdapter.Update(this.cN_NGANHANG);
                                        nhanVienGridControl.Enabled = true;
                                        if (themNhanVien == true)
                                        {
                                            cbTaoTaiKhoan.Visible = false;
                                        }
                                        themNhanVien = false;
                                        gbTaoTaiKhoan.Visible = false;
                                        btnSwitchDepartment.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Đã có lỗi xảy ra khi tạo tài khoản! Vui lòng kiểm tra lại");
                                        return;
                                    }
                                }
                            }
                        }
                        else
                        {
                            gioiTinhNam.Text = "Nữ";
                            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                            maChiNhanh.Enabled = diaChiNV.Enabled = hoNhanVien.Enabled = maNhanVien.Enabled = SDTNhanVien.Enabled = tenNhanVien.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = trangThaiXoaNV.Enabled = false;
                            nhanVienBindingSource.EndEdit();
                            nhanVienBindingSource.ResetCurrentItem();


                            Guid newGuid = Guid.NewGuid();

                            // Đặt giá trị rowguid cho bản ghi mới hoặc sửa đổi
                            ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["rowguid"] = newGuid;

                            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;
                            this.nhanVienTableAdapter.Update(this.cN_NGANHANG);
                            nhanVienGridControl.Enabled = true;
                            if (themNhanVien == true)
                            {
                                cbTaoTaiKhoan.Visible = false;
                            }
                            themNhanVien = false;
                            btnSwitchDepartment.Enabled = true;
                        }


                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên bị trùng! Vui lòng nhập lại");
                    }
                }
                //Không kiểm tra mã nhân viên ví dụ khi lưu nhưng không chỉnh sửa
                else
                {
                    ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["PHAI"] = "Nam";
                    if (gioiTinhNu.Checked == true)
                    {
                        ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["PHAI"] = "Nữ";
                    }
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                    maChiNhanh.Enabled = diaChiNV.Enabled = hoNhanVien.Enabled = maNhanVien.Enabled = SDTNhanVien.Enabled = tenNhanVien.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = trangThaiXoaNV.Enabled = false;
                    nhanVienBindingSource.EndEdit();
                    nhanVienBindingSource.ResetCurrentItem();

                    Guid newGuid = Guid.NewGuid();

                    // Đặt giá trị rowguid cho bản ghi mới hoặc sửa đổi
                    ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["rowguid"] = newGuid;


                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;
                    this.nhanVienTableAdapter.Update(this.cN_NGANHANG); //
                    nhanVienGridControl.Enabled = true;
                    //=======
                    btnSwitchDepartment.Enabled = true;
                }


            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThaiXoaNV.Visible = true;
            if (trangThaiXoaNV.Text == "1")
            {
                MessageBox.Show("Nhân viên đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            trangThaiXoaNV.Visible = false;
            btnSua.Enabled = false;
            cbTaoTaiKhoan.Visible = false;
            maNhanVienTruoc = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString();
            nhanVienGridControl.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = false;
            maNhanVien.Enabled = false;
            btnSwitchDepartment.Enabled = false;
            diaChiNV.Enabled = hoNhanVien.Enabled = SDTNhanVien.Enabled = tenNhanVien.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = trangThaiXoaNV.Enabled = true;

          
        }


        private void gioiTinhNu_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinhNam.Checked = !gioiTinhNu.Checked;
        }

        private void gioiTinhNam_CheckedChanged(object sender, EventArgs e)
        {
            gioiTinhNu.Checked = !gioiTinhNam.Checked;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThaiXoaNV.Visible = true;
            if (trangThaiXoaNV.Text == "1")
            {
                MessageBox.Show("Nhân viên đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            trangThaiXoaNV.Visible = false;
            if (maNhanVien.Text.Trim() == Program.username)
            {
                MessageBox.Show("Nhân viên đang đăng nhập");
                return;
            }
            cbTaoTaiKhoan.Visible = false;
            if (KT_MaNhanVien.KiemTraTrangThaiXoa(maNhanVien.Text) == 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin nhân viên", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Xóa tài khoản login
                    // 0: Xóa được tài khoản bao gồm cả tài khoản đó nếu không tồn tại
                    if (KT_TaoLogin.XoaLogin(Program.mlogin ,maNhanVien.Text.Trim()) == 0)
                    {
                        //trangThaiXoaNV.Text = "1";

                        gridView1.DeleteSelectedRows();
                        nhanVienBindingSource.EndEdit();
                        nhanVienBindingSource.ResetCurrentItem();
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;
                        this.nhanVienTableAdapter.Update(this.cN_NGANHANG);
                        nhanVienGridControl.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại");
                        return;
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                //Set trang thai xoa ve 1
                DialogResult result = MessageBox.Show("Nhân viên này đã tồn tại giao dịch chuyển tiền \n Bạn có chắc chắn muốn xóa thông tin nhân viên", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    //Xóa tài khoản
                    if (KT_TaoLogin.XoaLogin(Program.mlogin,maNhanVien.Text.Trim()).Equals(0))
                    {

                        // gridView1.DeleteSelectedRows();
                        //trangThaiXoaNV.Enabled = true;
                        trangThaiXoaNV.Visible = true;
                        trangThaiXoaNV.Text = "1";
                        nhanVienBindingSource.EndEdit();
                        nhanVienBindingSource.ResetCurrentItem();
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;
                        this.nhanVienTableAdapter.Update(this.cN_NGANHANG);
                        nhanVienGridControl.Enabled = true;
                        //trangThaiXoaNV.Enabled = false;
                        trangThaiXoaNV.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại");
                        return;
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }



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

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;
            this.nhanVienTableAdapter.Fill(this.cN_NGANHANG.NhanVien);
            if (Program.mGroup.Trim() == "CHINHANH")
            {
                
                nhanVienGridControl.Enabled = true;
                diaChiNV.Enabled = hoNhanVien.Enabled = maNhanVien.Enabled = SDTNhanVien.Enabled = tenNhanVien.Enabled = gioiTinhNu.Enabled = gioiTinhNam.Enabled = trangThaiXoaNV.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                themNhanVien = false;
                btnSwitchDepartment.Enabled = true;
                cbTaoTaiKhoan.Visible = false;
                gbTaoTaiKhoan.Visible = false;
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;

                // TODO: This line of code loads data into the 'cN_NGANHANG.KhachHang' table. You can move, or remove it, as needed.
                try
                {
                    btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLuu.Enabled = btnSwitchDepartment.Enabled = false;
                    this.nhanVienTableAdapter.Fill(this.cN_NGANHANG.NhanVien);
                }
                catch(System.Exception ex)
                {
                    
                    MessageBox.Show("Chi nhánh này chỉ xem được thông tin khách hàng");
                    return;
                    //maChiNhanh.Enabled = diaChiNV.Enabled = hoNhanVien.Enabled = maNhanVien.Enabled = SDTNhanVien.Enabled = tenNhanVien.Enabled = gioiTinhNam.Enabled = gioiTinhNu.Enabled = trangThaiXoaNV.Enabled = false;
                    //btnSua.Enabled = btnXoa.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnLuu.Enabled = false;
                }
                


            }
        }

        private void cbTaoTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTaoTaiKhoan.Checked)
            {
                //nganHang.Checked = true;
                //lbTaiKhoan.Visible = lbMatKhau.Visible = tbTaiKhoan.Visible = tbMatKhau.Visible = nganHang.Visible = chiNhanh.Visible = true;
                gbTaoTaiKhoan.Visible = true;
            }
            else
            {
                //lbTaiKhoan.Visible = lbMatKhau.Visible = tbTaiKhoan.Visible = tbMatKhau.Visible = nganHang.Visible = chiNhanh.Visible = false;
                gbTaoTaiKhoan.Visible = false;
            }
        }

        private void nganHang_CheckedChanged(object sender, EventArgs e)
        {
            //chiNhanh.Checked = !nganHang.Checked;
        }

        private void chiNhanh_CheckedChanged(object sender, EventArgs e)
        {
            //nganHang.Checked = !chiNhanh.Checked;
        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {
            string phai = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["PHAI"].ToString().Trim();
            gioiTinhNam.Checked = true;
            if (phai == "Nữ")
            {
                gioiTinhNu.Checked = true;
            }

        }

        private void btnSwitchDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThaiXoaNV.Visible = true;
            if (trangThaiXoaNV.Text == "1")
            {
                MessageBox.Show("Nhân viên đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            trangThaiXoaNV.Visible = false;
            if (maNhanVien.Text.Trim() == Program.username)
            {
                MessageBox.Show("Nhân viên đang đăng nhập");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn chuyển thông tin nhân viên này", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //nhanVienBindingSource.EndEdit();
                ChuyenNhanVien formchuyennv = new ChuyenNhanVien(maNhanVien.Text.Trim(),maChiNhanh.Text.Trim());
                formchuyennv.Owner = this;
                formchuyennv.Show();
                //this.chiNhanhBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.cN_NGANHANG);
                //nhanVienBindingSource.ResetCurrentItem();
                //nhanVienGridControl.Refresh();

                //this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;
                //this.nhanVienTableAdapter.Update(this.cN_NGANHANG);

                //this.nhanVienTableAdapter.Update
                
            }
            else
            {
                return;
            }
            //this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionstring;
            //this.nhanVienTableAdapter.Fill(this.cN_NGANHANG.NhanVien);
            //btnPhucHoi_ItemClick(sender, e);
            //this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}