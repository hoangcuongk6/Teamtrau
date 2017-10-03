using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Garco10.SystemModule.Forms;
using C1.Win.C1FlexGrid;
using M10_CTL;
using Garco10.SystemModule.HeThong;
using C1.Win.C1List;
using VSCM.Base.Utils;
using M10_System;
using M10_QLCV;

namespace Garco10.Presenter.QLCV.DanhMuc
{
    public partial class frmPhanCap_DonVi : Form
    {
        public frmPhanCap_DonVi()
        {
            InitializeComponent();
        }
        string[] ds_DonVi_TrucThuoc;
        int id_DonVi;
        private void frmPhanCap_DonVi_Load(object sender, EventArgs e)
        {
            LoadCombo_DSDonVi();
            
        }
        public void LoadCombo_DSDonVi()
        {
            var cmb = cmbDonVi;
            cmb.Tag = 0;
            clsDM_DonVi cls = new clsDM_DonVi();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.Sort = "ID_DonVi ASC";
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_DonVi";
            cmb.Properties.ValueMember = "ID_DonVi";
            if (dt.DefaultView.ToTable().Rows.Count == 1) cmb.EditValue = dt.DefaultView.ToTable().Rows[0]["ID_DonVi"];
            else cmb.EditValue = null;
            cmb.Tag = 1;
        }
        public void LoadCombo_DSDonVi_TrucThuoc(int id_DonVi)
        {
            var cmb = cmbDonViTrucThuoc;
            cmb.Tag = 0;
            clsDM_DonVi cls = new clsDM_DonVi();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.Sort = "ID_DonVi ASC";
            dt.DefaultView.RowFilter = "TonTai = 1 and ID_DonVi <> "+id_DonVi+"";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_DonVi";
            cmb.Properties.ValueMember = "ID_DonVi";
            if (dt.DefaultView.ToTable().Rows.Count == 1) cmb.EditValue = dt.DefaultView.ToTable().Rows[0]["ID_DonVi"];
            else cmb.EditValue = null;
            cmb.Tag = 1;
        }

        private void cmbDonVi_EditValueChanged(object sender, EventArgs e)
        {
            id_DonVi =int.Parse( cmbDonVi.EditValue.ToString());
            LoadCombo_DSDonVi_TrucThuoc(id_DonVi);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ds_DonVi_TrucThuoc = cmbDonViTrucThuoc.Properties.GetCheckedItems().ToString().Split(',');
            clsDonVi_PhanCap cls = new clsDonVi_PhanCap();
            cls.ID_DonVi_CapTren = id_DonVi;
            cls.DeleteWID_DonVi_CapTrenLogic();
            for (int i = 0; i < ds_DonVi_TrucThuoc.Length; ++i)
            {
                cls.ID_DonVi_CapDuoi = int.Parse(ds_DonVi_TrucThuoc[i]);
                DataTable dt = cls.SelectOne();
                if (dt.Rows.Count == 0)
                {
                    cls.Insert();
                }
                else
                {
                    
                }
            }

        }
    }
}
