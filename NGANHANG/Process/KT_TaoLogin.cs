using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.Process
{
    class KT_TaoLogin
    {
        public static int KiemTraTaoLogin(string loginName, string username)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("SP_CheckLogin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("LOGIN", loginName);
                cmd.Parameters.AddWithValue("USER", username);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();
                return (int)returnParameter.Value;

            }

        }

        public static int TaoLogin(string loginName, string loginPass, string username, string role)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("SP_TaoTaiKhoan", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("LGNAME", loginName);
                cmd.Parameters.AddWithValue("PASS", loginPass);
                cmd.Parameters.AddWithValue("USERNAME", username);
                cmd.Parameters.AddWithValue("ROLE", role);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();
                return (int)returnParameter.Value;

            }

        }

        public static int XoaLogin(string maNV)
        {

            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("Xoa_Login", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MANV", maNV);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    return -1;
                }
                conn.Close();
                return (int)returnParameter.Value;
            }


        }
    }
}
