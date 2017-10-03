using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using VSCM.Base.Forms;
using VSCM.Base.Utils;
using Garco10.ConnectionProviders;
using M10_QLCV;

namespace Garco10.DataAccess.QLCV.Global
{
    /// <summary>
    ///     Lớp hỗ trợ việc quản lý file
    /// </summary>
    public static class FTP_FilesManager
    {
        public enum FTP_FileType
        {
            All = 0,
            TaiLieuChung = 1,
            TaiLieuNoiBo = 2
        }

        public enum FTP_FileType_Group
        {
            QLCV = 3
        }

        public enum FTP_PhanMem : byte
        {
            //NhanSu = 2,
            //DonHang = 3,
            //KyThuat = 4,
            //SanXuat = 5,
            QuanLyCongViec = 6,
        }

        public static string ThuMucDownload = @"D:\Garco10_ERP_Files";
        public static string FTP_Server = "ftp.garco10.com.vn";
        public static string FTP_UserName = "qtsx";
        public static string FTP_PassWord = "qtsx@$";
        public static string FTP_Port = "21";
        public static string FTP_RootDirectory = "";

        private static string Get_RootDirectory(FTP_PhanMem pm)
        {
            var sReturn = "";
            switch (pm)
            {
                //case FTP_PhanMem.QuanLyCongViec:
                //    sReturn = "QuanLyCongViec";
                //    break;
                //case FTP_PhanMem.NhanSu:
                //    sReturn = "NhanSu";
                //    break;
                //case FTP_PhanMem.DonHang:
                //    sReturn = "DonHang";
                //    break;
                //case FTP_PhanMem.KyThuat:
                //    sReturn = "KyThuat";
                //    break;
                //case FTP_PhanMem.SanXuat:
                //    sReturn = "SanXuat";
                //    break;
                //case FTP_PhanMem.QuanLyCongViec_M10:
                //    sReturn = "QuanLyCongViec_M10";
                //    break;
                case FTP_PhanMem.QuanLyCongViec:
                    sReturn = "QuanLyCongViec";
                    break;
            }
            return sReturn;
        }

        private static bool FTP_MakeDir(string NewDirName, string ParentFolder)
        {
            //Tạo thư mục mới
            var reqFTP = default(FtpWebRequest);
            try
            {
                //reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + "QuanLyCongViec2"));
                reqFTP = (FtpWebRequest) WebRequest.Create(
                    new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + NewDirName));
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(FTP_UserName, FTP_PassWord);
                var response = (FtpWebResponse) reqFTP.GetResponse();
                var ftpStream = response.GetResponseStream();
                ftpStream.Close();
                response.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool FTP_RemoveDir(string DirName, string ParentFolder)
        {
            //Xóa thư mục
            var reqFTP = default(FtpWebRequest);
            try
            {
                reqFTP = (FtpWebRequest) WebRequest.Create(
                    new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + DirName));
                reqFTP.Method = WebRequestMethods.Ftp.RemoveDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(FTP_UserName, FTP_PassWord);
                var response = (FtpWebResponse) reqFTP.GetResponse();
                var ftpStream = response.GetResponseStream();
                ftpStream.Close();
                response.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool FTP_DirectoryExists(string DirName, string ParentFolder)
        {
            //Kiểm tra xem một thư mục đã tồn tại hay chưa
            var IsExists = true;
            var reqFTP = default(FtpWebRequest);
            try
            {
                reqFTP = (FtpWebRequest) WebRequest.Create(
                    new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + DirName));
                reqFTP.Method = WebRequestMethods.Ftp.PrintWorkingDirectory;
                reqFTP.Credentials = new NetworkCredential(FTP_UserName, FTP_PassWord);
                var response = (FtpWebResponse) reqFTP.GetResponse();
                var ftpStream = response.GetResponseStream();
                ftpStream.Close();
                response.Close();
            }
            catch (Exception)
            {
                IsExists = false;
            }
            return IsExists;
        }

        private static bool FTP_Rename(string currentFileName, string newFileName, string ParentFolder)
        {
            //Đổi tên file
            var reqFTP = default(FtpWebRequest);
            try
            {
                reqFTP = (FtpWebRequest) WebRequest.Create(
                    new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + currentFileName));
                reqFTP.Method = WebRequestMethods.Ftp.Rename;
                reqFTP.RenameTo = newFileName;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(FTP_UserName, FTP_PassWord);
                var response = (FtpWebResponse) reqFTP.GetResponse();
                var ftpStream = response.GetResponseStream();
                ftpStream.Close();
                response.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="FileName">Đường dẫn file</param>
        /// <param name="ParentFolder"></param>
        /// <returns></returns>
        private static bool FTP_Upload(string FileName, string ParentFolder)
        {
            //Upload file
            var fileInf = new FileInfo(FileName);
            var reqFTP = default(FtpWebRequest);
            //Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest) WebRequest.Create(
                new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + fileInf.Name));
            //Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential(FTP_UserName, FTP_PassWord);
            //By default KeepAlive is true, where the control connection is not closed after a command is executed.
            reqFTP.KeepAlive = false;
            //Specify the command to be executed
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            //Specify the data transfer type
            reqFTP.UseBinary = true;
            //Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;
            //The buffer size is set to 2kb
            var buffLength = 2048;
            var buff = new byte[buffLength + 1];
            var contentLen = 0;
            //Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            using (var fs = fileInf.OpenRead())
            {
                try
                {
                    //Stream to which the file to be upload is written
                    var strm = reqFTP.GetRequestStream();
                    //Read from the file stream 2kb at a time
                    contentLen = fs.Read(buff, 0, buffLength);
                    //Till Stream content ends
                    while (contentLen != 0)
                    {
                        //Write Content from the file stream to the FTP Upload Stream
                        strm.Write(buff, 0, contentLen);
                        contentLen = fs.Read(buff, 0, buffLength);
                    }
                    //Close the file stream and the Request Stream
                    strm.Close();
                    fs.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            //Force clean up
            //GC.Collect();
        }

        private static bool FTP_Delete(string FileName, string ParentFolder)
        {
            //Xóa file
            try
            {
                var reqFTP = default(FtpWebRequest);
                reqFTP = (FtpWebRequest) WebRequest.Create(
                    new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + FileName));
                reqFTP.Credentials = new NetworkCredential(FTP_UserName, FTP_PassWord);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                reqFTP.UseBinary = true;
                var result = string.Empty;
                var response = (FtpWebResponse) reqFTP.GetResponse();
                var size = response.ContentLength;
                var datastream = response.GetResponseStream();
                var sr = new StreamReader(datastream);
                result = sr.ReadToEnd();
                sr.Close();
                datastream.Close();
                response.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static string[] FTP_GetFilesDetailList(string FolderName, string ParentFolder)
        {
            //Lấy danh sách chi tiết file
            string[] downloadFiles = null;
            try
            {
                var result = new StringBuilder();
                var reqFTP = default(FtpWebRequest);
                reqFTP = (FtpWebRequest) WebRequest.Create(
                    new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + FolderName + "/"));
                reqFTP.Credentials = new NetworkCredential(FTP_UserName, FTP_PassWord);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                var response = reqFTP.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());
                var line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf("\\"), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\\');
            }
            catch (Exception)
            {
                downloadFiles = null;
                return downloadFiles;
            }
        }

        private static bool FTP_Download(string FilePathSave, string FileNameSave, string ParentFolder, string FileName)
        {
            //Download file
            var reqFTP = default(FtpWebRequest);
            try
            {
                //filePath = <<The full path where the file is to be created.>>, 
                //fileName = <<Name of the file to be created(Need not be the name of the file on FTP server).>>
                var outputStream = new FileStream(FilePathSave + "\\\\" + FileNameSave, FileMode.Create);
                //FileStream outputStream = new FileStream(DuongDanFileDownload, FileMode.Create);
                reqFTP = (FtpWebRequest) WebRequest.Create(
                    new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + FileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(FTP_UserName, FTP_PassWord);
                var response = (FtpWebResponse) reqFTP.GetResponse();
                var ftpStream = response.GetResponseStream();
                var cl = response.ContentLength;
                var bufferSize = 2048;
                var readCount = 0;
                var buffer = new byte[bufferSize + 1];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static string[] FTP_GetFilesList(string FolderName, string ParentFolder)
        {
            //Lấy danh sách file
            string[] downloadFiles = null;
            try
            {
                var result = new StringBuilder();
                var reqFTP = default(FtpWebRequest);
                reqFTP = (FtpWebRequest) WebRequest.Create(
                    new Uri("ftp://" + FTP_Server + ":" + FTP_Port + "/" + ParentFolder + "/" + FolderName + "/"));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(FTP_UserName, FTP_PassWord);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                var response = reqFTP.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());
                var line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\\");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf("\\"), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\\');
            }
            catch (Exception)
            {
                downloadFiles = null;
                return downloadFiles;
            }
        }


        public static bool UpLoad_TaiLieu(FTP_PhanMem phanMem, FTP_FileType fileType, string fileIdentity,
            string filePath, string fileName, string GhiChu)
        {
            try
            {
                if (IsFileInUse(filePath, fileName))
                {
                    BaseMessages.ShowWarningMessage("Không được mở file tải lên!");
                    return false;
                }
                var iID_Files = 0;
                var sRootDic = "";

                sRootDic = Get_RootDirectory(phanMem);
                //sTenFile = fileName.Substring(fileName.LastIndexOf(@"\") + 1, fileName.Length - (fileName.LastIndexOf(@"\") + 1));

                var oFile = new clsFTP_Files();
                //Insert file
                try
                {
                    oFile.ID_FileType = (short) fileType;
                    oFile.FilePath = "";
                    oFile.FileName = fileName;
                    oFile.FileIdentity = fileIdentity;
                    //oFile.TaiKhoan_Lap = oFile.TaiKhoan_SuaCuoi = (short) GlobalVariables.uID_TenDangNhap;
                    oFile.TaiKhoan_Lap = oFile.TaiKhoan_SuaCuoi = (short)GlobalVariables.GetID_NhanSu();
                    oFile.Ngay_Lap = oFile.Ngay_SuaCuoi = GlobalVariables.GetCurrentDateTime();
                    oFile.GhiChu = GhiChu;
                    oFile.TonTai = false;
                    oFile.Insert();
                    iID_Files = oFile.ID_Files.Value;
                }
                catch
                {
                    BaseMessages.ShowWarningMessage("Không kết nối được máy chủ!");
                    return false;
                }
                //Tạo thư mục chứa DL
                if (!FTP_MakeDir(iID_Files.ToString(), sRootDic))
                {
                    oFile.Delete();
                    BaseMessages.ShowWarningMessage("Không kết nối được FileServer!");
                    return false;
                }

                sRootDic = sRootDic + "/" + iID_Files;
                if (!FTP_Upload(filePath + @"\" + fileName, sRootDic))
                {
                    oFile.Delete();
                    BaseMessages.ShowWarningMessage("Không kết nối được FileServer!");
                    return false;
                }

                oFile.FilePath = sRootDic;
                oFile.TonTai = true;
                oFile.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public static bool UpLoad_TaiLieuDungChung(FTP_PhanMem phanMem, FTP_FileType fileType, string fileIdentity,
            string filePath, string fileName, string GhiChu)
        {
            try
            {
                if (IsFileInUse(filePath, fileName))
                {
                    BaseMessages.ShowWarningMessage("Không được mở file tải lên!");
                    return false;
                }
                var iID_Files = 0;
                var sRootDic = "";

                sRootDic = Get_RootDirectory(phanMem);
                //sTenFile = fileName.Substring(fileName.LastIndexOf(@"\") + 1, fileName.Length - (fileName.LastIndexOf(@"\") + 1));

                var oFile = new clsFTP_Files();
                //Insert file
                try
                {
                    oFile.ID_FileType = (short)fileType;
                    oFile.FilePath = "";
                    oFile.FileName = fileName;
                    oFile.FileIdentity = fileIdentity;
                    oFile.TaiKhoan_Lap = oFile.TaiKhoan_SuaCuoi = (short)GlobalVariables.iCurrentUser;
                    oFile.Ngay_Lap = oFile.Ngay_SuaCuoi = GlobalVariables.GetCurrentDateTime();
                    oFile.GhiChu = GhiChu;
                    oFile.TonTai = false;
                    oFile.Insert();
                    iID_Files = oFile.ID_Files.Value;
                }
                catch
                {
                    BaseMessages.ShowWarningMessage("Không kết nối được máy chủ!");
                    return false;
                }
                //Tạo thư mục chứa DL
                if (!FTP_MakeDir(iID_Files.ToString(), sRootDic))
                {
                    oFile.Delete();
                    BaseMessages.ShowWarningMessage("Không kết nối được FileServer!");
                    return false;
                }

                sRootDic = sRootDic + "/" + iID_Files;
                if (!FTP_Upload(filePath + @"\" + fileName, sRootDic))
                {
                    oFile.Delete();
                    BaseMessages.ShowWarningMessage("Không kết nối được FileServer!");
                    return false;
                }

                oFile.FilePath = sRootDic;
                oFile.TonTai = true;
                oFile.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }


        public static bool Delete_TaiLieu(int idFile)
        {
            try
            {
                var oFile = new clsFTP_Files();
                oFile.ID_Files = idFile;
                oFile.SelectOne();
                oFile.TaiKhoan_SuaCuoi = (short) GlobalVariables.iCurrentUser;
                oFile.Ngay_SuaCuoi = GlobalVariables.GetCurrentDateTime();
                oFile.TonTai = false;
                oFile.Update();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="idFile"></param>
        /// <param name="FileNameSave">Toàn bộ đường dẫn file, như C:\1.doc</param>
        /// <param name="IsOverWrite"></param>
        /// <returns></returns>
        public static bool Download_TaiLieuDinhKem(int idFile, string FilePathSave, string FileNameSave,
            bool IsOverWrite)
        {
            if (IsOverWrite && IsFileInUse(FilePathSave, FileNameSave))
            {
                BaseMessages.ShowWarningMessage("File ghi đè đang sử dụng!");
                return false;
            }
            //return true;
            try
            {
                var oFile = new clsFTP_Files();
                oFile.ID_Files = idFile;
                oFile.SelectOne();
                var sFilePath = oFile.FilePath.Value;
                var sFileName = oFile.FileName.Value;
                return FTP_Download(FilePathSave, FileNameSave, sFilePath, sFileName);
            }
            catch
            {
                return false;
            }
        }

        public static bool OpenFile(string FilePath, string FileName)
        {
            //Nhiệm vụ: mở một file
            var psi = new Process();
            if (!File.Exists(ThuMucDownload + @"\" + FilePath + @"\" + FileName)) return false;
            psi.StartInfo.WorkingDirectory = ThuMucDownload + @"\" + FilePath.Replace(@"/", @"\");
            psi.StartInfo.FileName = FileName;
            try
            {
                if (!psi.Start()) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Kiển tra xem file có đang mở hay không
        private static bool IsFileInUse(string FilePath, string FileName)
        {
            var file = new FileInfo(FilePath.Replace(@"/", @"\") + @"\" + FileName);
            if (!File.Exists(file.FullName)) return false;
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        public static bool OpenFile_TaiLieuDinhKem(int ID_Files, string FilePath, string FileName)
        {
            var bReturn = false;
            var sFolderSave = ThuMucDownload + @"\" + FilePath;

            if (IsFileInUse(sFolderSave, FileName))
            {
                BaseMessages.ShowWarningMessage("File đang sử dụng!");
                return false;
            }

            if (File.Exists(sFolderSave + @"\" + FileName))
            {
                var fl = new FileInfo(sFolderSave + @"\" + FileName);
                if (fl.CreationTime == fl.LastWriteTime)
                    return OpenFile(FilePath, FileName);
                File.Delete(sFolderSave + @"\" + FileName);
            }

            if (!Directory.Exists(sFolderSave))
                Directory.CreateDirectory(sFolderSave);

            SplashForm.ShowSplashScreen();
            if (Download_TaiLieuDinhKem(ID_Files, sFolderSave, FileName, true))
                bReturn = OpenFile(FilePath, FileName);
            SplashForm.CloseForm();
            return bReturn;
        }
    }
}