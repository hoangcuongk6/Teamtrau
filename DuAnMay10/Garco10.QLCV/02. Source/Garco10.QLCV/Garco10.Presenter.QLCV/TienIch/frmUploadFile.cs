using System;
using System.Data;
using System.Windows.Forms;
using Garco10.DataAccess.QLCV.Global;
using M10_QLCV;
using VSCM.Base.Utils;
using VSCM.Base.Forms;
namespace Garco10.Presenter.QLCV.TienIch
{
    public partial class frmUploadFile : FormBase
    {
        public bool IsUpload = false;
        FTP_FilesManager.FTP_PhanMem m_PhanMem;
        FTP_FilesManager.FTP_FileType_Group m_FileType_Group;
        FTP_FilesManager.FTP_FileType m_FileType;
        String m_sFileIdentity;
        String m_sFilter = "";

        public frmUploadFile(FTP_FilesManager.FTP_PhanMem phanMem, FTP_FilesManager.FTP_FileType_Group fileType_Group, FTP_FilesManager.FTP_FileType fileType, String fileIdentity)
        {
            InitializeComponent();
            m_PhanMem = phanMem;
            m_FileType = fileType;
            m_FileType_Group = fileType_Group;
            m_sFileIdentity = fileIdentity;
        }

        private void frmUploadFile_Load(object sender, EventArgs e)
        {
            Load_cmbFileType();
        }

        private void Load_cmbFileType()
        {
            cmbFiletype.Tag = 0;

            clsFTP_FileType o = new clsFTP_FileType();
            DataTable dt = o.SelectAll();
            String sFilter = "ID_PhanMem = " + 6;
            //if (m_sFilter != "") sFilter += " AND ID_FileType IN (" + m_sFilter + ")";
            dt.DefaultView.RowFilter = sFilter;
            dt = dt.DefaultView.ToTable();
            cmbFiletype.Properties.DataSource = dt;
            cmbFiletype.Properties.DisplayMember = "FileType_Name";
            cmbFiletype.Properties.ValueMember = "ID_FileType";
            if (dt.Rows.Count > 0) cmbFiletype.EditValue = dt.Rows[0]["ID_FileType"];
            cmbFiletype.Tag = 1;
        }

        private void txtFileName_Click(object sender, EventArgs e)
        {
            OpenFileDialog fldDlg = new OpenFileDialog();
            if (fldDlg.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = fldDlg.FileName;
            }
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            if (cmbFiletype.Properties.GetIndexByKeyValue(cmbFiletype.EditValue) < 0)
            {
                BaseMessages.ShowWarningMessage("Chưa chọn loại file!");
                return;
            }

            if (txtFileName.Text == "")
            {
                BaseMessages.ShowWarningMessage("Chưa chọn file upload!");
                return;
            }

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(txtFileName.Text.Trim());

            SplashForm.ShowSplashScreen();
            if (FTP_FilesManager.UpLoad_TaiLieu(m_PhanMem, (FTP_FilesManager.FTP_FileType)((Int16)cmbFiletype.EditValue), m_sFileIdentity, fileInfo.DirectoryName, fileInfo.Name, txtGhiChu.Text.Trim()))
            {
                SplashForm.CloseForm();
                BaseMessages.ShowInformationMessage("Upload file thành công!");
                Close();
                //txtGhiChu.Text = "";
                //txtFileName.Text = "";
                IsUpload = true;
            }
            else
            {
                SplashForm.CloseForm();
            }
        }

        /// <summary>
        /// Chuổi để lọc FileType, có dạng là 1,2,3,4
        /// </summary>
        public string sFilter
        {           
            set
            {
                m_sFilter = value;
            }
        }


    }
}
