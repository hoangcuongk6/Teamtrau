using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Garco10.SystemModule.Forms;
using M10_HRM;
using Garco10.SystemModule.HeThong;
using DevExpress.XtraCharts;
using VSCM.Base.Utils;
using M10_System;
using VSCM.Base.Controls;

namespace Garco10.Presenter.QLCV.DanhMuc
{
    public partial class frmChonNhanSu : FormBaseGarco10
    {
        public int iID_NhanSu = 0 ;
        public string sMaNS = "", sTen_DonVi = "", sTen_BoPhan ="", sTen_LoaiHopDong ="";
        public Int16 siID_ChucVu = 0;
        public bool bIs_Save;
        public String sHoTen = "", sTen_ChucVu = "";

        Int16 m_byID_BoPhan = 0;
        int m_iID_DonVi = 0 ; 
        public int iID_DonVi = 0, iID_BoPhan = 0;
        HRM_Enumerations.NS_TrangThai_HopDong m_TrangThaiHD = HRM_Enumerations.NS_TrangThai_HopDong.DangDiLam;
        HRM_Enumerations.NS_TrangThai_DiLam m_TrangThaiDiLam = HRM_Enumerations.NS_TrangThai_DiLam.TatCa;


        public frmChonNhanSu()
        {
            InitializeComponent();
        }

        public frmChonNhanSu(int ID_DonVi)
        {
            InitializeComponent();
            m_iID_DonVi = ID_DonVi;
        }
        public void Set_DonVi_BoPhan(int ID_DonVi, int ID_BoPhan)
        {
            cmbDonVi.EditValue = ID_DonVi;
            cmbBoPhan.EditValue = ID_BoPhan;
        }

        public frmChonNhanSu(HRM_Enumerations.NS_TrangThai_HopDong trangThaiHD, HRM_Enumerations.NS_TrangThai_DiLam trangThaiDiLam )
        {
            InitializeComponent();
            m_TrangThaiHD = trangThaiHD;
            m_TrangThaiDiLam = trangThaiDiLam;
        }

        private void frmChonNhanSu_Load(object sender, EventArgs e)
        {
            fgNhanSu.AutoSetColumnFilter();
            if (m_iID_DonVi == 0)
            {
                //NhanSuMethod.Load_cmbDonVi_TheoQuyen(cmbDonVi, true);
                LoadcmbDonVi();
            }
            else
                //Load_cmbDonVi_TheoQuyen(cmbDonVi, true);
                LoadcmbDonVi();
        }

        private void LoadcmbDonVi()
        {
            var cmb = cmbDonVi;
            cmb.Tag = 0;
            var cls = new clsDM_DonVi();
            var dt = cls.SelectAll();
            dt.DefaultView.Sort = "STT_DonVi ASC";
            dt.DefaultView.RowFilter = "TonTai = 1 AND SuDung = 1";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_DonVi";
            cmb.Properties.ValueMember = "ID_DonVi";
            if (dt.DefaultView.ToTable().Rows.Count == 1) cmb.EditValue = dt.DefaultView.ToTable().Rows[0]["ID_DonVi"];
            else cmb.EditValue = null;
            cmb.Tag = 1;
        }
        public void Load_cmbDonVi_TheoQuyen(VSCM.Base.Controls.ucSearchLookupEdit cmb, bool p)
        {
            cmb.Tag = 0;
            clsDM_DonVi cls = new clsDM_DonVi();
            DataTable dt = cls.SelectAll();
            dt = GlobalMethod.CheckQuyenDonVi(dt);
            if (dt.Rows.Count > 1)
            {
                DataRow row;
                row = dt.NewRow();
                row["ID_DonVi"] = "0";
                row["Ten_DonVi"] = "Tất cả";
                row["SuDung"] = 1;
                row["TonTai"] = 1;
                dt.Rows.Add(row);
            }

            dt.DefaultView.RowFilter = "SuDung = 1 AND TonTai = 1 AND ID_DonVi <> " + iID_DonVi;
            dt.DefaultView.Sort = "STT_DonVi ASC";

            cmb.Properties.DataSource = dt.DefaultView.ToTable();
            cmb.Properties.ValueMember = "ID_DonVi";
            cmb.Properties.DisplayMember = "Ten_DonVi";
            cmb.Tag = 1;

            if (dt.DefaultView.ToTable().Rows.Count == 1) cmb.EditValue = dt.DefaultView.ToTable().Rows[0]["ID_DonVi"];
        }

        private void TimKiem()
        {
            var fg = fgNhanSu;
            fg.Tag = 0;
            fg.BeginUpdate();
            clsNS_ThongTinNS cls = new clsNS_ThongTinNS();

            DataTable dt = cls.TimKiemTheoTenNS_MaNS(txtSearch_NhanSu.Text,
                                                     GlobalVariables.GetCurrentDateTime(),
                                                     m_TrangThaiHD,
                                                     m_TrangThaiDiLam);
            dt = GlobalMethod.CheckQuyenDonVi(dt);
            fg.SetDataSource(dt, true);
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void Load_fgNhanSu()
        {
            var fg = fgNhanSu;
            fg.Tag = 0;
            fg.BeginUpdate();
            clsNS_ThongTinNS cls = new clsNS_ThongTinNS();
            if (cmbDonVi.EditValue.ToString() != "0" && cmbDonVi.EditValue.ToString() != "") m_byID_BoPhan = Int16.Parse(cmbBoPhan.EditValue.ToString());
            else m_byID_BoPhan = 0;
            DataTable dt = cls.Select_DanhSachNhanSu_wDonVi_And_PhongBan(Int16.Parse(cmbDonVi.EditValue.ToString()),
                                                                         m_byID_BoPhan,
                                                                         GlobalVariables.GetCurrentDateTime(),
                                                                         HRM_Enumerations.NS_TrangThai_HopDong.DangDiLam,
                                                                         HRM_Enumerations.NS_TrangThai_DiLam.TatCa);
            //dt = GlobalMethod.CheckQuyenDonVi(dt);
            //fg.SetDataSource(dt, true);
            fg.SetDataSource(dt);
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void cmbDonVi_EditValueChanged(object sender, EventArgs e)
        {            
            if (cmbDonVi.EditValue == null)
            {
                cmbBoPhan.EditValue = null;
                cmbBoPhan.Properties.DataSource = null;
                fgNhanSu.ClearRows();
            }
            else
            {
                VSCM.Base.Forms.WaitForm.ShowSplashScreen();
                GlobalMethod.Load_cmbBoPhan(cmbBoPhan, cmbDonVi.EditValue.ToString(), true);
                cmbBoPhan.EditValue = 0;
                VSCM.Base.Forms.WaitForm.CloseForm();
            }
        }

        private void cmbBoPhan_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbBoPhan.EditValue == null) fgNhanSu.ClearRows();            
            else Load_fgNhanSu();            
        }    

        private void txtSearch_NhanSu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch_NhanSu.Text.Trim() != "")
                {
                    VSCM.Base.Forms.WaitForm.ShowSplashScreen();
                    TimKiem();
                    VSCM.Base.Forms.WaitForm.CloseForm();
                }
                else fgNhanSu.ClearRows();
            }
        }


        public override void RefreshForm()
        {
            VSCM.Base.Forms.WaitForm.ShowSplashScreen();
            Load_fgNhanSu();
            VSCM.Base.Forms.WaitForm.CloseForm();
        }

        private void fgNhanSu_DoubleClick(object sender, EventArgs e)
        {
            if (fgNhanSu.Row < fgNhanSu.Rows.Fixed) return;
            if (BaseMessages.ShowQuestionMessage("Chọn nhân sự này ?") == DialogResult.No) return;
            sHoTen = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Hoten");
            iID_NhanSu = fgNhanSu.GetIntValue(fgNhanSu.Row, "ID_NhanSu");
            //sTen_ChucVu = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Ten_ChucVu");
            //siID_ChucVu = (Int16)fgNhanSu.GetIntValue(fgNhanSu.Row, "ID_ChucVu");
            //sTen_DonVi = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Ten_DonVi");
            //sTen_BoPhan = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Ten_BoPhan");
            //sTen_LoaiHopDong = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Ten_LoaiHopDong");
            //iID_DonVi = fgNhanSu.GetIntValue(fgNhanSu.Row, "ID_DonVi");
            //iID_BoPhan = fgNhanSu.GetIntValue(fgNhanSu.Row, "ID_BoPhan");
            sMaNS = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "MaNS");
            bIs_Save = true;
            this.Close();
            
        }

        private void cmdChon_Click(object sender, EventArgs e)
        {
            if (fgNhanSu.Row < fgNhanSu.Rows.Fixed) return;
            if (BaseMessages.ShowQuestionMessage("Chọn nhân sự này ?") == DialogResult.No) return;
            sHoTen = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Hoten");
            iID_NhanSu = fgNhanSu.GetIntValue(fgNhanSu.Row, "ID_NhanSu");
            //sTen_ChucVu = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Ten_ChucVu");
            //siID_ChucVu = (Int16)fgNhanSu.GetIntValue(fgNhanSu.Row, "ID_ChucVu");
            //sTen_DonVi = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Ten_DonVi");
            //sTen_BoPhan = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Ten_BoPhan");
            //sTen_LoaiHopDong = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "Ten_LoaiHopDong");
            //iID_DonVi = fgNhanSu.GetIntValue(fgNhanSu.Row, "ID_DonVi");
            //iID_BoPhan = fgNhanSu.GetIntValue(fgNhanSu.Row, "ID_BoPhan");
            sMaNS = fgNhanSu.GetDataDisplay(fgNhanSu.Row, "MaNS");
            bIs_Save = true;
            this.Close();
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_NhanSu_EditValueChanged(object sender, EventArgs e)
        {
            fgNhanSu.Filter("MaNS", "Hoten", "CMND_So", txtSearch_NhanSu.Text);
        }

        public ucFlexGrid fgChon
        {
            get
            {
                return fgNhanSu;
            }
        }

    }
}
