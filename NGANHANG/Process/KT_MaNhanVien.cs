using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.Process
{
    class KT_MaNhanVien
    {
        public static int KiemTraMaNhanVien(string maNV)
        {

            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("SP_KiemTraMaNhanVien", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MANV", maNV);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return (int)returnParameter.Value;
            }


        }

        public static int KiemTraTrangThaiXoa(string maNV)
        {

            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("SP_KiemTraTrangThaiXoa", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MANV", maNV);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return (int)returnParameter.Value;
            }


        }

        public static int ChuyenChiNhanhNhanVien(String maNV,String maNVmoi,String chiNhanh)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("sp_chuyenchinhanh", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("manv", maNV);
                cmd.Parameters.AddWithValue("mamoi", maNVmoi);
                cmd.Parameters.AddWithValue("chinhanhmoi", chiNhanh);
                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return (int)returnParameter.Value;
            }
        }
    }
}
