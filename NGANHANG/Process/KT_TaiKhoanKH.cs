using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.Process
{
    class KT_TaiKhoanKH
    {
        public static int KiemTraTonTaiTaiKhoan(string cmnd)
        {

            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("SP_KiemTraTaoTaiKhoan", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CMND", cmnd);
                //cmd.Parameters.AddWithValue("MACN", maCN);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return (int)returnParameter.Value;
            }


        }

        public static int KiemTraSoTaiKhoan(string sotk)
        {

            using (SqlConnection conn = new SqlConnection(Program.connectionstring))
            using (SqlCommand cmd = new SqlCommand("SP_KiemTraSoTaiKhoan", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("SOTK", sotk);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return (int)returnParameter.Value;
            }


        }

        //public static int CapNhatSoDuTaiKhoan(string cmnd, string sotk,  string loaigd, string ngaygd, Double sotien, string manv)
        //public static int CapNhatSoDuTaiKhoan(string cmnd, string sotk, string loaigd, string ngaygd, Double sotien, string manv)
        public static int CapNhatSoDuTaiKhoan(string sotk, string loaigd, string ngaygd, Double sotien, string manv)
        {

            SqlConnection conn = new SqlConnection(Program.connectionstring);

            SqlCommand command = new SqlCommand("SP_CapNhatSoDuTaiKhoan", conn);
            command.CommandType = CommandType.StoredProcedure;



            command.Parameters.Add(new SqlParameter("@SOTK", SqlDbType.NChar)).Value = sotk;
            command.Parameters.Add(new SqlParameter("@LOAIGD", SqlDbType.NChar)).Value = loaigd;
            command.Parameters.Add(new SqlParameter("@NGAYGD", SqlDbType.NChar)).Value = ngaygd;
            command.Parameters.Add(new SqlParameter("@SOTIEN", SqlDbType.Money)).Value = sotien;
            command.Parameters.Add(new SqlParameter("@MANV", SqlDbType.NChar)).Value = manv;
            //command.Parameters.Add(new SqlParameter("@CMND", SqlDbType.NChar)).Value = cmnd;

            var returnParameter = command.Parameters.Add("@result", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            return (int)returnParameter.Value;



        }

        public static List<string> ThongTinTaiKhoanKhachHang(string cmnd)
        {
            List<string> list = new List<string>();

            using (SqlConnection con = new SqlConnection(Program.connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ThongTinTaiKhoanKhacHang", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CMND", SqlDbType.NChar)).Value = cmnd;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    try
                    {
                        dr.Read();
                        list.Add(dr.GetString(0));
                        list.Add(dr.GetString(1));
                        list.Add(dr.GetString(2));
                        list.Add(dr.GetString(3));
                        list.Add(dr.GetString(4));
                        list.Add(dr.GetString(5));
                    }
                    catch (System.InvalidOperationException e)
                    {
                        list = null;
                        return list;
                    }


                    con.Close();
                }
            }
            return list;


        }

        public static int GD_ChuyenTienTaiKhoan(string sotkgui, string sotknhan, string ngaygd, Double sotienchuyen, string manv)
        {

            SqlConnection conn = new SqlConnection(Program.connectionstring);

            SqlCommand command = new SqlCommand("SP_CapNhatGDChuyenTien", conn);
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.Add(new SqlParameter("@SOTK_GUI", SqlDbType.NChar)).Value = sotkgui;
            command.Parameters.Add(new SqlParameter("@SOTK_NHAN", SqlDbType.NChar)).Value = sotknhan;
            command.Parameters.Add(new SqlParameter("@NGAYGD", SqlDbType.NChar)).Value = ngaygd;
            command.Parameters.Add(new SqlParameter("@SOTIENCHUYEN", SqlDbType.Money)).Value = sotienchuyen;
            command.Parameters.Add(new SqlParameter("@MANV", SqlDbType.NChar)).Value = manv;
            //command.Parameters.Add(new SqlParameter("@CMND", SqlDbType.NChar)).Value = cmnd;

            var returnParameter = command.Parameters.Add("@result", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            return (int)returnParameter.Value;


        }

    }
}
