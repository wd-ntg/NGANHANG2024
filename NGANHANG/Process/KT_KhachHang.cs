using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.Process
{
    class KT_KhachHang
    {
        public static void TaoKhachHang(string cmnd, string ho, string ten, string diaChi, string phai, string ngayCap, string sdt, string maCN)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("frmKhachHang_CreateCustomer", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CMND", cmnd);
                cmd.Parameters.AddWithValue("HO", ho);
                cmd.Parameters.AddWithValue("TEN", ten); // Bổ sung trường TEN
                cmd.Parameters.AddWithValue("DIACHI", diaChi); // Bổ sung trường ĐỊA CHỈ
                cmd.Parameters.AddWithValue("PHAI", phai); // Bổ sung trường PHÁI
                cmd.Parameters.AddWithValue("NGAYCAP", ngayCap); // Bổ sung trường NGÀY CẤP
                cmd.Parameters.AddWithValue("SODT", sdt); // Bổ sung trường SỐ ĐIỆN THOẠI 
                cmd.Parameters.AddWithValue("MACN", maCN); // Bổ sung trường MÃ CHI NHÁNH

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

            public static int KiemTraSoCMND(string cmnd)
            {
                using (SqlConnection conn = new SqlConnection(Program.connectionstring))
                using (SqlCommand cmd = new SqlCommand("frmKhachHang_DuplicateCMND", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CMND", cmnd);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra xem có dữ liệu trả về không
                    if (reader.HasRows)
                    {
                        reader.Close();
                        conn.Close();
                        return 1;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return 0;
                    }
                }
            }

        public static int KiemTraGiaoDichKhachHang(string cmnd)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("frmKhachHang_ExistsGD", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CMND", cmnd);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Kiểm tra xem có dữ liệu trả về không
                if (reader.HasRows)
                {
                    reader.Close();
                    conn.Close();
                    return 1;
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    return 0;
                }
            }
        }

        public static void XoaKhachHangNonGiaoDich(string cmnd)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("frmKhachHang_DeleteAccountNonGD", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CMND", cmnd);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

    }
}
