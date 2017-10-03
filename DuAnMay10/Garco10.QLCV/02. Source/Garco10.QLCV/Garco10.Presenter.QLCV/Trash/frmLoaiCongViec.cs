using System;
using System.Data;
using System.Data.SqlTypes;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using VSCM.Base.Utils;

namespace Garco10.Presenter.QLCV.DanhMuc
{
    public partial class frmLoaiCongViec : FormBaseGarco10
    {
        private frmDM_LoaiCongViec m_DM_LoaiCV;
        private bool m_bCapNhat;
        private int m_iID_LoaiCV;

        public frmDM_LoaiCongViec frmDM_LoaiCongViec
        {
            set { m_DM_LoaiCV = value; }
        }

        public frmLoaiCongViec()
        {
            InitializeComponent();
            Load_cmbNhomCha();
            chkSuDung.Checked=true;
        }

        public frmLoaiCongViec(int ID_LoaiCV)
        {
            InitializeComponent();
            Load_cmbNhomCha();
            chkSuDung.Checked = true;
            cmbLoaiCVCha.EditValue = ID_LoaiCV;
        }

        public frmLoaiCongViec(int ID_LoaiCV, bool bCapNhat)
        {
            InitializeComponent();
            m_iID_LoaiCV = ID_LoaiCV;
            m_bCapNhat = bCapNhat;
            Load_cmbNhomCha();
        }

        private void GetData()
        {
            clsDM_LoaiCV cls = new clsDM_LoaiCV();
            cls.ID_LoaiCV = Convert.ToInt32(m_iID_LoaiCV);
            DataTable dt = cls.SelectOne();
            if (dt.Rows.Count>0)
            {
                txtLoaiCV.EditValue = dt.Rows[0]["Ten_LoaiCV"];
                cmbLoaiCVCha.EditValue = dt.Rows[0]["ID_LoaiCV_Cha"];
                chkSuDung.Checked = bool.Parse(dt.Rows[0]["SuDung"].ToString());
            }
        }

        private void frmNhom_Load(object sender, EventArgs e)
        {
            if (m_bCapNhat)
            {
                GetData();
            }
        }

        private void Load_cmbNhomCha()
        {
            var cmb = cmbLoaiCVCha;
            cmb.Tag = 0;
            clsDM_LoaiCV cls = new clsDM_LoaiCV();
            DataTable dt;
            if (m_bCapNhat)
                dt = cls.SelectAll_ParentNodes(m_iID_LoaiCV);
            else
                dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt.DefaultView.Sort = "Ten_LoaiCV ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_LoaiCV";
            cmb.Properties.ValueMember = "ID_LoaiCV";
            cmb.Tag = 1;
        }

        private bool IsValid()
        {
            string strTen_Nhom = txtLoaiCV.Text.ToLower().Trim();
            if (strTen_Nhom == "")
            {
                BaseMessages.ShowWarningMessage("Chưa nhập tên loại công việc !!!");
                return false;
            }
            
            return true;
        }

        private void SaveData()
        {
            if (!IsValid()) return;
            clsDM_LoaiCV cls = new clsDM_LoaiCV();
            cls.Ten_LoaiCV = txtLoaiCV.Text;
            if (chkSuDung.Checked)
            {
                cls.SuDung = true;
            }
            else
            {
                cls.SuDung = false;
            }
            cls.TonTai = true;
            cls.ID_LoaiCV_Cha = ((cmbLoaiCVCha.EditValue ?? "").ToString() == "") ? SqlInt32.Null : Convert.ToInt32(cmbLoaiCVCha.EditValue);
            cls.TonTai = true;
            if (m_bCapNhat)
            {
                cls.ID_LoaiCV = m_iID_LoaiCV;
                cls.Update();
                BaseMessages.ShowInformationMessage("Cập nhật thành công !!!");
            }
            else
            {
                cls.Insert();
                BaseMessages.ShowInformationMessage("Thêm mới thành công !!!");
            }

            if (m_DM_LoaiCV != null) m_DM_LoaiCV.LoadData();
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            SaveData();
        }
    }
}
