using System;
using System.Data;
using System.Windows.Forms;
using VSCM.Base.Utils;
using Garco10.DataAccess.QLCV.Global;
using M10_QLCV;
using VSCM.Base.Forms;

namespace Garco10.Presenter.QLCV.TienIch
{
    public partial class frmUploadFileShow : FormBase
    {
        Int16 m_iFileType_Group = 0;
        Int16 m_iFileType = 0;
        String m_sFileIdentity = "0";
        String m_sFilterView_FileType = "", m_sFilterEdit_FileType = "";
        FTP_FilesManager.FTP_PhanMem m_phanmem;
        private bool m_bQuyenCapNhat = false;
        private int m_iID_CongViec;

        public frmUploadFileShow()
        {
            InitializeComponent();
            fgFile.AutoSetColumnFilter();
        }

        public frmUploadFileShow(bool quyenCapNhat,FTP_FilesManager.FTP_PhanMem phanmem,FTP_FilesManager.FTP_FileType_Group fileType_Group,FTP_FilesManager.FTP_FileType fileType,String fileIdentity)
        {
            InitializeComponent();
            fgFile.AutoSetColumnFilter();
            m_bQuyenCapNhat = quyenCapNhat;
            m_phanmem = phanmem;
            m_iFileType_Group = (Int16)fileType_Group;
            m_iFileType = (Int16)fileType;
            m_sFileIdentity = fileIdentity;
        }


        private void frmUploadFileShow_Load(object sender, EventArgs e)
        {
            Load_fg();
        }

        private void Load_fgAdd()
        {
            var fg = fgFile;
            fg.Tag = "0";
            fg.BeginUpdate();

            clsFTP_Files oFile = new clsFTP_Files();
            DataTable dt = oFile.SelectDanhSachFiles(m_iFileType_Group, m_iFileType,m_sFileIdentity);
            if (m_sFilterView_FileType != "")
            {
                dt.DefaultView.RowFilter = "FileType in (" + m_sFilterView_FileType + ")";
                dt = dt.DefaultView.ToTable();
            }
            fg.SetDataSource(dt, true);
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = "1";
        }

        private void Load_fg()
        {
            var fg = fgFile;
            fg.Tag = "0";
            fg.BeginUpdate();

            clsFTP_Files oFile = new clsFTP_Files();
            DataTable dt = oFile.SelectDanhSachFiles(m_iFileType_Group, m_iFileType, m_sFileIdentity);
            if (m_sFilterView_FileType != "")
            {
                dt.DefaultView.RowFilter = "FileType in (" + m_sFilterView_FileType + ")";
                dt = dt.DefaultView.ToTable();
            }
            fg.SetDataSource(dt, true);
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = "1";
        }

        private void cmdDownload_Click(object sender, EventArgs e)
        {
            var fg = fgFile;
            if (fg.Row < fg.Rows.Fixed) return;

            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.InitialDirectory = @"C:\";
            oSaveFileDialog.FileName = fg.GetDataDisplay(fg.Row, "FileName");
            oSaveFileDialog.Filter = "Files| *." + fgFile.GetDataDisplay(fg.Row, "FileName").Substring(fg.GetDataDisplay(fg.Row, "FileName").LastIndexOf(".") + 1,
                                                                                                            fg.GetDataDisplay(fg.Row, "FileName").Length - fg.GetDataDisplay(fg.Row, "FileName").LastIndexOf(".") - 1);
            if (oSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int iID_Files = fg.GetIntValue(fg.Row, "ID_Files");
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(oSaveFileDialog.FileName.ToString());
                bool bIsOverwrite = oSaveFileDialog.OverwritePrompt;

                VSCM.Base.Forms.WaitForm.ShowSplashScreen();
                bool bDownloadSuccess = FTP_FilesManager.Download_TaiLieuDinhKem(iID_Files, fileInfo.DirectoryName, fileInfo.Name, bIsOverwrite);
                VSCM.Base.Forms.WaitForm.CloseForm();
                if (bDownloadSuccess) BaseMessages.ShowInformationMessage("Đã tải xong!");
            }
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            var fg = fgFile;
            if (!m_bQuyenCapNhat || fg.Row < fg.Rows.Fixed) return;
            if (BaseMessages.ShowDeleteQuestionMessage() == DialogResult.No) return;
            if (FTP_FilesManager.Delete_TaiLieu(fg.GetIntValue(fg.Row, "ID_Files")))
            {
                BaseMessages.ShowInformationMessage("Xóa thành công!");
                Load_fg();
            }
            else
            {
                BaseMessages.ShowWarningMessage("Không kết nối được đến máy chủ!");
            }
        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            if (!m_bQuyenCapNhat)
            {
                BaseMessages.ShowNoRolesMessage();
                return;
            }
            //if (m_sFileIdentity == "0" || !m_bQuyenCapNhat) return;
            frmUploadFile frm = new frmUploadFile((FTP_FilesManager.FTP_PhanMem)m_phanmem,
                                                  (FTP_FilesManager.FTP_FileType_Group)m_iFileType_Group,
                                                  (FTP_FilesManager.FTP_FileType)m_iFileType,
                                                  m_sFileIdentity);
            frm.sFilter = m_sFilterEdit_FileType == "" ? m_sFilterView_FileType : m_sFilterEdit_FileType;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.IsUpload)
            {
                Load_fg();
            }

        }

        private void fgFile_DoubleClick(object sender, EventArgs e)
        {
            if (fgFile.Row < fgFile.Rows.Fixed) return;
            FTP_FilesManager.OpenFile_TaiLieuDinhKem( fgFile.GetIntValue(fgFile.Row, "ID_Files"),
                                                      fgFile.GetDataDisplay(fgFile.Row, "FilePath"),
                                                      fgFile.GetDataDisplay(fgFile.Row, "FileName"));
        }      

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (fgFile.Row < fgFile.Rows.Fixed) return;
            frmUploadFileShow_ChiTiet frm = new frmUploadFileShow_ChiTiet( (FTP_FilesManager.FTP_PhanMem)m_phanmem,
                                                                           (FTP_FilesManager.FTP_FileType_Group)m_iFileType_Group,
                                                                           (FTP_FilesManager.FTP_FileType)m_iFileType,
                                                                           (Int16)fgFile.GetIntValue(fgFile.Row, "ID_FileType"),
                                                                           fgFile.GetDataDisplay(fgFile.Row, "FileName"),
                                                                           fgFile.GetDataDisplay(fgFile.Row, "GhiChu"),
                                                                           fgFile.GetIntValue(fgFile.Row, "ID_Files"));
            frm.sFilter = m_sFilterEdit_FileType == "" ? m_sFilterView_FileType : m_sFilterEdit_FileType;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.IsUpload)
            {
                Load_fg();
            }

        }

        public string sFilterView_FileType
        {
            set
            {
                m_sFilterView_FileType = value;
            }
        }

        public string sFilterEdit_FileType
        {
            set
            {
                m_sFilterEdit_FileType = value;
            }
        }

    }
}
