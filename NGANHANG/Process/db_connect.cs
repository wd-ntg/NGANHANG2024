using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.Process
{
    class db_connect
    {
        public static bool KTDangNhap(String loginName, String password)
        {
            Program.connectionstring = "Server=" + Program.TenServer + ";initial catalog=" + Program.TenDataBase
                                               + ";User id=" + loginName + ";Password=" + password;
            SqlConnection sqlConnection = new SqlConnection(Program.connectionstring);
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static void ThongTinTaiKhoanDangNhap()
        {
            SqlConnection conn = new SqlConnection(Program.connectionstring);
            /*string strLenh = "EXEC SP_ThongTinTaiKhoanDangNhap '" + Program.mlogin + "'";*/

            string strLenh = "EXEC frmLogin_GetEmployeeInfoFromLoginName '" + Program.mlogin + "'";

            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Program.myReader = sqlcmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return;
            }

            // Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                Program.username = Program.myReader.GetString(0);
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
            }
            catch (System.Data.SqlTypes.SqlNullValueException)
            {
                Program.username = "";
                Program.mHoten = "";
                Program.mGroup = "";
            }
            Program.myReader.Close();
            conn.Close();

        }
    }
}
