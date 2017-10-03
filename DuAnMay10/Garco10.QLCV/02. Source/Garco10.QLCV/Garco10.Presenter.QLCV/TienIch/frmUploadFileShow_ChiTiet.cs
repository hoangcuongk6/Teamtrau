using System;
using Garco10.DataAccess.QLCV.Global;
using M10_QLCV;
using VSCM.Base.Utils;
using VSCM.Base.Forms;

namespace Garco10.Presenter.QLCV.TienIch
{
    public partial class frmUploadFileShow_ChiTiet : FormBase
    {
        public bool IsUpload;
        private readonly FTP_FilesManager.FTP_FileType m_FileType;
        private readonly FTP_FilesManager.FTP_FileType_Group m_FileType_Group;
        private readonly short m_iFileType;
        private readonly int m_iID_Files;
        private FTP_FilesManager.FTP_PhanMem m_PhanMem;
        private readonly string m_sFileName = "";
        private readonly string m_sGhiChu = "";
        private string m_sFilter = "";

        public frmUploadFileShow_ChiTiet(FTP_FilesManager.FTP_PhanMem phanMem,
            FTP_FilesManager.FTP_FileType_Group fileType_Group,
            FTP_FilesManager.FTP_FileType FileType,
            short fileType,
            string FileName,
            string GhiChu,
            int ID_File)
        {
            InitializeComponent();
            m_PhanMem = phanMem;
            m_iFileType = fileType;
            m_FileType = FileType;
            m_FileType_Group = fileType_Group;
            m_iID_Files = ID_File;
            m_sFileName = FileName;
            m_sGhiChu = GhiChu;
        }

        /// <summary>
        ///     Chuổi để lọc FileType, có dạng là 1,2,3,4
        /// </summary>
        public string sFilter
        {
            set { m_sFilter = value; }
        }

        private void frmUploadFileShow_ChiTiet_Load(object sender, EventArgs e)
        {
            Load_cmbFileType();
            txtFileName.Text = m_sFileName;
            txtGhiChu.Text = m_sGhiChu;
        }

        private void Load_cmbFileType()
        {
            cmbFiletype.Tag = 0;

            var cls = new clsFTP_FileType();
            var dt = cls.SelectAll();
            var sFilter = "ID_FileType_Group = " + (short) m_FileType_Group + " AND ( " + (short) m_FileType +
                          "= 0  OR ID_FileType = " + (short) m_FileType + ")";
            if (m_sFilter != "") sFilter += " AND ID_FileType IN (" + m_sFilter + ")";
            dt.DefaultView.RowFilter = sFilter;
            dt = dt.DefaultView.ToTable();
            cmbFiletype.Properties.DataSource = dt;
            cmbFiletype.Properties.DisplayMember = "FileType_Name";
            cmbFiletype.Properties.ValueMember = "ID_FileType";
            cmbFiletype.EditValue = m_iFileType;
            cmbFiletype.Tag = 1;
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (cmbFiletype.Properties.GetIndexByKeyValue(cmbFiletype.EditValue) < 0)
            {
                BaseMessages.ShowWarningMessage("Chưa chọn loại file");
                return;
            }

            var oFile = new clsFTP_Files();
            oFile.ID_Files = m_iID_Files;
            oFile.SelectOne();
            oFile.ID_FileType = short.Parse(cmbFiletype.EditValue.ToString());
            oFile.GhiChu = txtGhiChu.Text;
            if (oFile.Update())
            {
                IsUpload = true;
                Close();
            }
        }
    }
}