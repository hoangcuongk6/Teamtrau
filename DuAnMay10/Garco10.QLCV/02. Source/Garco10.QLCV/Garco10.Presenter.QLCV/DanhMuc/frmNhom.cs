using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using VSCM.Base.Utils;

namespace Garco10.Presenter.QLCV.DanhMuc
{
    public partial class frmNhom : FormBaseGarco10
    {
        private frmNhom_Ban m_frmNhom_Ban;
        private bool m_bCapNhat;
        private int m_iID_Nhom;

        public frmNhom_Ban frmQLTD
        {
            set { m_frmNhom_Ban = value; }
        }

        public frmNhom()
        {
            InitializeComponent();
            Load_cmbNhomCha();
        }

        public frmNhom(int ID_Nhom)
        {
            InitializeComponent();
            Load_cmbNhomCha();
            cmbNhomCha.EditValue = ID_Nhom;
        }

        public frmNhom(int ID_Nhom, bool bCapNhat)
        {
            InitializeComponent();
            m_iID_Nhom = ID_Nhom;
            m_bCapNhat = bCapNhat;
            Load_cmbNhomCha();
        }

        private void GetData()
        {
            clsNhom cls = new clsNhom();
            cls.ID_Nhom = Convert.ToInt32(m_iID_Nhom);
            DataTable dt = cls.SelectOne();
            if (dt.Rows.Count>0)
            {
                txtNhom.EditValue = dt.Rows[0]["Ten_Nhom"];
                cmbNhomCha.EditValue = dt.Rows[0]["ID_Nhom_Cha"];
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
            var cmb = cmbNhomCha;
            cmb.Tag = 0;
            clsNhom cls = new clsNhom();
            DataTable dt;
            //if (!m_bCapNhat)
            //{
            //    dt = cls.SelectAll();
            //}
            //else
            //{
            //    dt = cls.SelectAll_ParentNodes(m_iID_Nhom);
            //}
            dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt.DefaultView.Sort = "ID_Nhom ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_Nhom";
            cmb.Properties.ValueMember = "ID_Nhom";
            cmb.Tag = 1;
        }

        private bool IsValid()
        {
            string strTen_Nhom = txtNhom.Text.ToLower().Trim();
            if (strTen_Nhom == "")
            {
                BaseMessages.ShowWarningMessage("Chưa nhập tên nhóm !!!");
                return false;
            }
            
            return true;
        }

        private void SaveData()
        {
            if (!IsValid()) return;
            clsNhom cls = new clsNhom();
            cls.Ten_Nhom = txtNhom.Text;
            cls.ID_Nhom_Cha = ((cmbNhomCha.EditValue ?? "").ToString() == "") ? SqlInt32.Null : Convert.ToInt32(cmbNhomCha.EditValue);
            cls.TonTai = true;
            if (m_bCapNhat)
            {
                cls.ID_Nhom = m_iID_Nhom;
                cls.Update();
                BaseMessages.ShowInformationMessage("Cập nhật thành công !!!");
            }
            else
            {
                cls.Insert();
                BaseMessages.ShowInformationMessage("Thêm mới thành công !!!");
            }
            
            if (m_frmNhom_Ban != null) m_frmNhom_Ban.LoadfgBan_Nhom();
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
