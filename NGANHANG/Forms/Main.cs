using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.Forms
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PHANMANH.V_DS_PHANMANH);

            tbMaNV.Text = "Mã nhân viên: " + Program.username;
            HoTen.Text = "   Họ tên: " + Program.mHoten;
            tbQuyen.Text = "   Nhóm: " + Program.mGroup;

            if (Program.mGroup == "NGANHANG")
            {
                ribbonPageGroup11.Visible = false;
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login f = new Login();
                f.Show();
            }
            else if (result == DialogResult.No)
            {
                return;
            }


        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(KhachHang));
            if (frm != null) frm.Activate();
            else
            {
                Program.formKhachHang = new KhachHang();
                Program.formKhachHang.MdiParent = this;
                Program.formKhachHang.Show();
            }
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(NhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Program.formNhanVien = new NhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
        }

        private void btnGiaoDich_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*Form frm = this.CheckExists(typeof(GiaoDich));
            if (frm != null) frm.Activate();
            else
            {
                GiaoDich f = new GiaoDich();
                f.MdiParent = this;
                f.Show();
            }*/
        }

        private void btnGDChuyenTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*Form frm = this.CheckExists(typeof(ChuyenTien));
            if (frm != null) frm.Activate();
            else
            {
                ChuyenTien f = new ChuyenTien();
                f.MdiParent = this;
                f.Show();
            }*/
        }


        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*Form frm = this.CheckExists(typeof(ThongKe));
            if (frm != null) frm.Activate();
            else
            {
                ThongKe f = new ThongKe();
                f.MdiParent = this;
                f.Show();
            }*/
        }

        private void btnTaoLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*Form frm = this.CheckExists(typeof(TaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                TaoLogin f = new TaoLogin();
                f.MdiParent = this;
                f.Show();
            }*/
        }
    }
}