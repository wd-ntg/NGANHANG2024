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
            string role = Program.mGroup;

            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("frmCreateLogin_DuplicateLOGIN", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TENLOGIN", loginName);
                cmd.Parameters.AddWithValue("ROLE", role);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();
                return (int)returnParameter.Value;

            }

        }

        public static int TaoLogin(string loginName, string loginPass, string username,  string role)
        {
            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("frmCreateLogin_CreateLoginForEmployee", conn))
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

        public static int XoaLogin(string tenLogin, string maNhanVien)
        {

            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("frmCreateLogin_DeleteLoginForEmployee", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("LGNAME", tenLogin);
                cmd.Parameters.AddWithValue("USRNAME", maNhanVien);

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
