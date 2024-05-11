﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG
{
    public class MyConfig
    {
        public static string RootServerName = Environment.MachineName;

        public const string ViewDSPMName = "V_DS_PHANMANH";
        public const string DisplayMemberDSPM = "TENCN";
        public const string ValueMemberDSPM = "TENSERVER";
        public const string FilterClauseDSPM = "FILTERCLAUSE";
        public const string PatternGetDepartId = @"(?<departId>[\w\d\s]{10})";

        public const string DatabaseName = "NGANHANG";
        public const string RemoteLogin = "HTKN";
        public const string RemotePassword = "123456";

        public const string CongTyGroupName = "congty";
        public const string ChiNhanhGroupName = "chinhanh";
        public const string UserGroupName = "user";

        public const string ExecSPThongTinDangNhap = "EXEC sp_login '{0}'";
        public const string ExecSPTaoTaiKhoan = "EXEC sp_createlogin '{0}', '{1}', '{2}', '{3}'";
        public const string ExecSPTimNhanVien = "EXEC sp_timnhanvien {0}";
        //public const string ExecSPTimVatTu = "EXEC sp_timvattu '{0}'";
        //public const string ExecSPTimKho = "EXEC sp_timkho '{0}'";
        //public const string ExecSPTimDDH = "EXEC sp_timddh '{0}'";
        //public const string ExecSPXoaLogin = "EXEC sp_removelogin '{0}'";
        //public const string ExecSPTimPhieuXuat = "EXEC sp_timphieuxuat '{0}'";
        //public const string ExecSPCapNhatPhieuNhap = "EXEC sp_capnhatphieunhap '{0}', '{1}', '{2}', '{3}'";
        //public const string ExecSPCheckInStockMaterial = "EXEC sp_checkinstockmaterial '{0}', '{1}', {2}";

        //public const string ExecSPTimPhieuNhap = "sp_timphieunhap";
        //public const string SpKiemTraNVCoTaiKhoan = "sp_timtaikhoannhanvien";
        public const string SpGetAllMaNV = "sp_getallmanv";
        //public const string SpGetDanhSachDVT = "sp_getdsdvt";
        public const string SpChuyenChiNhanh = "sp_chuyenchinhanh";
        //public const string SpThemNhanVien = "sp_addemployee";


        // Mã error khi exec sp raise error
        public const int ErrorMsgNumNotExistObject = 50001;
        public const int ErrorMsgNumEmployeeHaveLogin = 50002;
    }
}
