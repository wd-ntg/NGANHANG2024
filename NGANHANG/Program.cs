using NGANHANG.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data;

namespace NGANHANG
{
    static class Program
    {
        public static string connectionstring;
        public static string TenServer;
        public static string TenDataBase = "NGANHANG";
        public static int mChiNhanh;
        public static BindingSource ChiNhanhbds;
        public static SqlDataReader myReader;

        //Tên login đang đăng nhập
        public static String loginDN = "";
        public static String passwordDN = "";

        //Tài khoản HTKN
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static String mlogin = "";
        public static String password = "";

        public static String username = "";
        public static String mGroup = "";
        public static String mHoten = "";

        public static NhanVien formNhanVien;
        public static KhachHang formKhachHang;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DevExpress.UserSkins.Bo
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Application.Run(new Login());
        }
    }
}
