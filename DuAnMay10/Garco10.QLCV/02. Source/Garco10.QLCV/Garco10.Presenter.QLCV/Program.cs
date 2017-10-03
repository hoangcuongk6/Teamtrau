using System;
using System.Windows.Forms;
using System.Data;
using Garco10.ConnectionProviders;
using Garco10.SystemModule.HeThong;
using M10_System;
using VSCM.Base.Utils;


namespace Garco10.Presenter.QLCV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] SwitchKeys = { "/TenND", "/MatKhauND", "/TenMC", "/TenDangNhapMC", "/MatKhauMC", "/Internet" };
            string[] CommandLines = System.Environment.CommandLine.Split(SwitchKeys, StringSplitOptions.None);

            if (CommandLines.Length < 7)
            {
                BaseMessages.ShowErrorMessage("Sai tham số khởi tạo chương trình");
                return;
            }

            //Khởi tạo kết nối
            clsConnecionString.ConnectionString_System = string.Format("Data Source={0};Initial Catalog={1}; User ID={2}; Password={3}",
                                                                        CommandLines[3].Trim(),
                                                                        clsConnecionString.DBName_System,
                                                                        CommandLines[4].Trim(),
                                                                        CommandLines[5].Trim());

            if (CommandLines[6].Trim() == "Y") clsConnecionString.KetNoiInternet = true;
            Garco10.SystemModule.HeThong.GlobalVariables.uTenDangNhap = CommandLines[1].Trim().ToLower();
            clsConnecionString.CreateAllConnections();

            clsTaiKhoanDangNhap cls = new clsTaiKhoanDangNhap();
            cls.TenDangNhap = GlobalVariables.uTenDangNhap;
            DataTable dt = cls.Select_ThongTinTaiKhoan();

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                GlobalVariables.uID_TaiKhoanDangNhap = Int16.Parse(dr["ID_TaiKhoanDangNhap"].ToString());
                GlobalVariables.uID_ChucVu = Int16.Parse("0" + dr["ID_ChucVu"]);
                GlobalVariables.uID_DonVi = Int16.Parse("0" + dr["ID_DonVi"]);
                GlobalVariables.uID_BoPhan = Int16.Parse("0" + dr["ID_BoPhan"]);
                GlobalVariables.uTen_ChucVu = dr["Ten_ChucVu"].ToString();
                GlobalVariables.uTen_DonVi = dr["Ten_DonVi"].ToString();
                GlobalVariables.uTen_BoPhan = dr["Ten_BoPhan"].ToString();
                GlobalVariables.uTenDayDu = dr["TenDayDu"].ToString();
                GlobalVariables.uLoai_TaiKhoan = (Enumerations.Loai_TaiKhoan)int.Parse("0" + dr["Loai_TaiKhoan"]);
                GlobalVariables.uQuyen_TatCaDonVi = (bool)dr["Quyen_TatCaDonVi"];
                GlobalVariables.uTaiKhoan_DanhGia = (bool)dr["TaiKhoan_DanhGia"];
            }

            clsPQ_TaiKhoan_DonVi oDV = new clsPQ_TaiKhoan_DonVi();
            oDV.ID_TaiKhoanDangNhap = GlobalVariables.uID_TaiKhoanDangNhap;
            dt = oDV.Select_wTaiKhoan();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    GlobalVariables.uListQuyen_DonVi.Add(dr["ID_DonVi"].ToString());
                }
            }

            M10_System.clsFTP_Server o = new M10_System.clsFTP_Server();
            dt = o.SelectAll();
            String sLoaiServer = "FTP_Server_Local";
            if (Garco10.ConnectionProviders.clsConnecionString.KetNoiInternet) sLoaiServer = "FTP_Server_Internet";
            foreach (DataRow dr in dt.Rows)
            {
                Garco10.SystemModule.HeThong.FTP_FilesManager.FTP_Server = dr[sLoaiServer].ToString();
                Garco10.SystemModule.HeThong.FTP_FilesManager.FTP_UserName = dr["FTP_UserName"].ToString();
                Garco10.SystemModule.HeThong.FTP_FilesManager.FTP_PassWord = dr["FTP_PassWord"].ToString();
                Garco10.SystemModule.HeThong.FTP_FilesManager.FTP_Port = dr["FTP_Port"].ToString();
                break;
            }

            //Lấy CultureInfo của Win trước khi gán thành vi-VN của phần mềm                        
            System.Globalization.CultureInfo cultureinfo = new System.Globalization.CultureInfo("vi-VN", false);
            cultureinfo.NumberFormat.CurrencyDecimalSeparator = ".";
            cultureinfo.NumberFormat.CurrencyGroupSeparator = ",";
            cultureinfo.NumberFormat.NumberDecimalSeparator = ".";
            cultureinfo.NumberFormat.NumberGroupSeparator = ",";
            Application.CurrentCulture = cultureinfo;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new VSCM.Base.Classes.clsVietHoaDevGrid();

            Application.Run(new frmMain_QLCV());
        }
    }
}
