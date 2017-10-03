using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Garco10.ConnectionProviders;

namespace Garco10.DataAccess.QLCV.Global
{
    public class GlobalVariables
    {
        public static int uID_TenDangNhap = 0;
        public static string uTenDangNhap = "";
        public static string uTenDayDu = "";
        public static int uID_ChiNhanh = 0;
        public static int uID_BoPhan;
        public static int uID_ChucVu;
        public static string uTen_ChiNhanh = "";
        public static string uTen_BoPhan = "";

        public static string strCurrentUser_Name = "";
        public static int iCurrentUser = 0;

        public static int Crytography_MalgoV = 5;

        public static string DBName = "M10_QLCV";

        public static string ConnectionString_PM = clsConnecionString.ConnectionString_QLCV;

        public static DateTime GetCurrentDateTime()
        {
            SqlConnection oConn = new SqlConnection();
            oConn.ConnectionString = ConnectionString_PM;
            oConn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oConn;
            cmd.CommandText = "SELECT GETDATE()";

            DateTime daReturn = (DateTime)cmd.ExecuteScalar();
            cmd.Dispose();
            oConn.Close();
            oConn.Dispose();

            return daReturn;
        }

        public static int GetID_NhanSu()
        {
            string strConn = ConnectionString_PM;
            DataTable dt = new DataTable();
            SqlConnection oConn = new SqlConnection();
            oConn.ConnectionString = strConn;
            oConn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oConn;
            cmd.CommandText = "GetID_NhanSu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_TaiKhoanDangNhap", SystemModule.HeThong.GlobalVariables.uID_TaiKhoanDangNhap));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int ID = int.Parse(dt.Rows[0]["ID_NhanSu"].ToString());
            cmd.Dispose();
            oConn.Close();
            oConn.Dispose();

            return ID;   
        }
        public static int GetID_DonVi_CuaTkDangNhap()
        {
            string strConn = ConnectionString_PM;
            DataTable dt = new DataTable();
            SqlConnection oConn = new SqlConnection();
            oConn.ConnectionString = strConn;
            oConn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oConn;
            cmd.CommandText = "[dbo].[GetID_DonVi]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_TaiKhoanDangNhap", SystemModule.HeThong.GlobalVariables.uID_TaiKhoanDangNhap));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int ID = int.Parse(dt.Rows[0]["ID_DonVi"].ToString());
            cmd.Dispose();
            oConn.Close();
            oConn.Dispose();

            return ID;
        }
        public static string Get_HoTen_NhanSu()
        {
            string strConn = ConnectionString_PM;
            DataTable dt = new DataTable();
            SqlConnection oConn = new SqlConnection();
            oConn.ConnectionString = strConn;
            oConn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = oConn;
            cmd.CommandText = "Get_HoTen_NhanSu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID_TaiKhoanDangNhap", SystemModule.HeThong.GlobalVariables.uID_TaiKhoanDangNhap));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            string HoTen = dt.Rows[0]["TenDayDu"].ToString();
            cmd.Dispose();
            oConn.Close();
            oConn.Dispose();

            return HoTen;   
        }

        public static string TimeAgo(DateTime dateTime)
        {
            string result = string.Empty;
            var timeSpan = DateTime.Now.Subtract(dateTime);

            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                result = string.Format("{0} giây trước", timeSpan.Seconds);
            }
            else if (timeSpan <= TimeSpan.FromMinutes(60))
            {
                result = timeSpan.Minutes > 1 ?
                    String.Format("Khoảng {0} phút trước", timeSpan.Minutes) :
                    "Khoảng một phút trước";
            }
            else if (timeSpan <= TimeSpan.FromHours(24))
            {
                result = timeSpan.Hours > 1 ?
                    String.Format("Khoảng {0} giờ trước", timeSpan.Hours) :
                    "Khoảng một giờ trước";
            }
            else if (timeSpan <= TimeSpan.FromDays(30))
            {
                result = timeSpan.Days > 1 ?
                    String.Format("Khoảng {0} ngày trước", timeSpan.Days) :
                    "Ngày hôm qua";
            }
            else if (timeSpan <= TimeSpan.FromDays(365))
            {
                result = timeSpan.Days > 30 ?
                    String.Format("Khoảng {0} tháng trước", timeSpan.Days / 30) :
                    "Tháng trước";
            }
            else
            {
                result = timeSpan.Days > 365 ?
                    String.Format("Khoảng {0} năm trước", timeSpan.Days / 365) :
                    "Một năm trước";
            }

            return result;
        }

        public static void ErrorLogging(Exception ex)
        {
            string strPath = @"D:\\Garco10_QLCV\Log.txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========End============= " + DateTime.Now);

            }
        }
        public static void ReadError()
        {
            string strPath = @"D:\Garco10_QLCV\Log.txt";
            using (StreamReader sr = new StreamReader(strPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
