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
using System.Data.SqlClient;

namespace NGANHANG.Forms
{
    public partial class MoTaiKhoanKH : DevExpress.XtraEditors.XtraForm
    {
        private string chiNhanhTaoTK;

        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public MoTaiKhoanKH(string chinhanh)
        {
            InitializeComponent();
            this.chiNhanhTaoTK = chinhanh;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectionstring;
        }

        private void MoTaiKhoanKH_Load(object sender, EventArgs e)
        {
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectionstring;
            this.taiKhoanTableAdapter.Fill(this.cN_NGANHANG.TaiKhoan);
            this.Owner.Enabled = false;
            groupBox1.Enabled = false;
            tbSoDu.Text = "100000";
        }

        private void MoTaiKhoanKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
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

        private void HienThiThongTin(string cmnd)
        {
            List<string> list = new List<string>();
            list = KT_TaiKhoanKH.ThongTinTaiKhoanKhachHang(cmnd);
            if (list == null)
            {
                MessageBox.Show("Danh sách null");
            }
            else
            {
                groupBox1.Enabled = true;
                tbCMND.Enabled = tbHo.Enabled = tbSoDu.Enabled = tbTen.Enabled = rtbDiaChi.Enabled = tbSDT.Enabled = tbChiNhanh.Enabled = false;
                // tbCMND.Text = list[0];
                tbCMND.Text = list[0];
                tbHo.Text = list[1];
                tbTen.Text = list[2];
                rtbDiaChi.Text = list[3];
                tbSDT.Text = list[4];
                tbChiNhanh.Text = list[5];
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

        private void btnKiemTraThongTin_Click(object sender, EventArgs e)
        {
            if (tbNhapSoCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số chứng minh nhân dân khách hàng cần tạo tài khoản", "", MessageBoxButtons.OK);
                tbNhapSoCMND.Focus();
                return;
            }
            else if (!kiemTraSo(tbNhapSoCMND.Text))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ", "", MessageBoxButtons.OK);
                tbNhapSoCMND.Focus();
                return;
            }
            else if (tbNhapSoCMND.Text.Length > 10)
            {

            }
            if (KT_KhachHang.KiemTraSoCMND(tbNhapSoCMND.Text) == 0)
            {
                MessageBox.Show("Số CMND không tồn tại trong hệ thống! Vui lòng kiểm tra lại");
                tbNhapSoCMND.Focus();
                return;
            }
            //else if (KiemTraViTri_CMND(tbNhapSoCMND.Text.Trim()) != -1)
            //{
            //    MessageBox.Show("Khách hàng đã tồn tại tài khoản! Vui lòng nhập lại");
            //    tbNhapSoCMND.Focus();
            //    return;

            //}
            else
            {
                HienThiThongTin(tbNhapSoCMND.Text);
                HienThiDanhSachTaiKhoan(tbNhapSoCMND.Text);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {

            if (tbSoTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản");
                tbSoTK.Focus();
                return;
            }
            if (tbSoTK.Text.Length > 9)
            {
                MessageBox.Show("Số tài khoản tối đa là 9 số");
                tbSoTK.Focus();
                return;
            }
            else if (!kiemTraSo(tbSoTK.Text))
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ", "", MessageBoxButtons.OK);
                tbSoTK.Focus();
                return;
            }
            else if (KT_TaiKhoanKH.KiemTraSoTaiKhoan(tbSoTK.Text) == 1)
            {
                MessageBox.Show("Số tài khoản bị trùng! Vui lòng nhập lại");
                tbSoTK.Focus();
                return;
            }
            else
            {
                string dateTK = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss");

                Guid newGuid = Guid.NewGuid();

                taiKhoanBindingSource.AddNew();

                ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["SOTK"] = tbSoTK.Text;
                ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["CMND"] = tbCMND.Text;
                ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["SODU"] = tbSoDu.Text;
                ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["MACN"] = chiNhanhTaoTK;
                ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["NGAYMOTK"] = dateTK;
                ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Count - 1])["rowguid"] = newGuid;

                taiKhoanBindingSource.EndEdit();
                taiKhoanBindingSource.ResetCurrentItem();

                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectionstring;

                if (this.taiKhoanTableAdapter.Update(this.cN_NGANHANG.TaiKhoan) == 1)
                {
                    MessageBox.Show("Tạo tài khoản khách hàng thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản khách hàng không thành công");
                    return;
                }

            }
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cN_NGANHANG);

        }

        private void taiKhoanBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cN_NGANHANG);

        }

        private void tbNhapSoCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void dsTaiKhoanKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HienThiDanhSachTaiKhoan(string cmnd)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            {
                conn.ConnectionString = Program.connectionstring; // Gán chuỗi kết nối vào đây

                using (SqlCommand cmd = new SqlCommand("DS_TaiKhoanKH", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CMND", cmnd);

                    adapter = new SqlDataAdapter(cmd);
                    dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    dataDS_TaiKhoanKH.DataSource = dataTable;
                }
            }
        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã nhấp vào một ô dữ liệu hay không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataDS_TaiKhoanKH.Rows[e.RowIndex];

                // Kiểm tra xem dữ liệu có tồn tại trong các ô trên dòng được chọn không
                if (selectedRow.Cells["SOTK"].Value != null &&
                    selectedRow.Cells["SODU"].Value != null &&
                    selectedRow.Cells["MACN"].Value != null)
                {
                    // Lấy giá trị của các ô trong dòng được chọn
                    string soTK = selectedRow.Cells["SOTK"].Value.ToString();
                    string soDu = selectedRow.Cells["SODU"].Value.ToString();
                    string chiNhanh = selectedRow.Cells["MACN"].Value.ToString();
             

                    // Chuyển đổi giá trị của soDu thành kiểu decimal
                    if (decimal.TryParse(soDu, out decimal soDuValue))
                    {
                        // Gán giá trị cho các control trên form
                        txtSOTK.Text = soTK;
                        txtMACNSet.Text = chiNhanh;
                        numbSODU.Value = soDuValue;
                        CMND.Text = tbNhapSoCMND.Text;
                    }
                    else
                    {
                        // Xử lý lỗi nếu không thể chuyển đổi giá trị soDu thành kiểu decimal
                        MessageBox.Show("Giá trị Số dư không hợp lệ.");
                    }
                }
                else
                {
                    // Xử lý trường hợp dữ liệu không tồn tại trong các ô trên dòng được chọn
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
        }

        private void hieuChinhBtn_Click(object sender, EventArgs e)
        {
            hieuChinhBtn.Enabled = xoaBtn.Enabled = reloadTrangBtn.Enabled = false;
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
                MessageBox.Show("Dữ liệu đã được lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra khi lưu dữ liệu: " + ex.Message);
                Console.WriteLine("Lỗi xảy ra khi lưu dữ liệu: " + ex.Message);
            }
        }



        private void phucHoiBtn_Click(object sender, EventArgs e)
        {
           
        }


        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if (dataDS_TaiKhoanKH.SelectedRows.Count > 0)

            {

                phucHoiBtn.Enabled = reloadTrangBtn.Enabled = hieuChinhBtn.Enabled = false;

                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa các bản ghi đã chọn không?", "Xác nhận xóa", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataDS_TaiKhoanKH.SelectedRows)
                        {
                            // Xóa bản ghi được chọn
                            dataDS_TaiKhoanKH.Rows.Remove(row);
                        }
                        MessageBox.Show("Xóa dữ liệu thành công.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bản ghi để xóa.");
            }
        }



        private void reloadTrangBtn_Click(object sender, EventArgs e)
        {
            HienThiDanhSachTaiKhoan(tbNhapSoCMND.Text); // Gọi lại hàm hiển thị danh sách tài khoản với cùng thông tin CMND
        }

    }

}