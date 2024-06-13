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

namespace NGANHANG.Forms
{
    public partial class ChuyenNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private string text1 = "";
        private string text2 = "";

        public ChuyenNhanVien(string text1, string text2)
        {

            InitializeComponent();
            this.text1 = text1;
            this.text2 = text2;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số mã nhân viên mới", "", MessageBoxButtons.OK);
                textBox1.Focus();
                return;
            }
            String manv = textBox1.Text;
            String maCN = "";
            if (text2 == "BENTHANH")
            {
                maCN = "TANDINH";
            }
            if (text2 == "TANDINH")
            {
                maCN = "BENTHANH";
            }
            if (KT_MaNhanVien.KiemTraMaNhanVien(textBox1.Text.Trim()) == 1)
            {
                MessageBox.Show("Mã nhân viên bị trùng. Vui lòng nhập lại");
                return;
            }
            else
            {
                if (KT_MaNhanVien.ChuyenChiNhanhNhanVien(text1.Trim(), textBox1.Text.Trim(), maCN.Trim()) == 0)
                {
                    MessageBox.Show("Chuyển chi nhánh thành công. Với Mã nhân viên mới là: " + manv);

                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Thất bại");

                    return;
                }
            }



        }

        private void ChuyenNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void ChuyenNhanVien_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }
    }
}