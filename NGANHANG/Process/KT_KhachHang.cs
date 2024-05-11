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
        public static int KiemTraSoCMND(string cmnd)
        {

            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("SP_KiemTraSoCMND", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("SOCMND", cmnd);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return (int)returnParameter.Value;
            }


        }

        public static int KiemTraXoaKhachHang(string cmnd)
        {

            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("SP_KiemTraXoaKhachHang", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CMND", cmnd);

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
